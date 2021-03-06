using com.clusterrr.TuyaNet;
using System.Net.Sockets;

namespace SakoMonitor;

internal class Device : TuyaDevice
{
    public double Watts { get; set; }
    public double Voltage { get; set; }
    public Label LabelToUpdate { get; set; }
    public bool Enabled { get; set; } = true;

    private DateTime tryAgainAt;

    public Device(
        string ip,
        string localKey,
        string deviceId,
        TuyaProtocolVersion protocolVersion = TuyaProtocolVersion.V33,
        int port = 6668,
        int receiveTimeout = 250
        ) : base(ip, localKey, deviceId, protocolVersion, port, receiveTimeout)
    {
        _ = Task.Run(async () =>
        {
            while (true)
            {
                await Task.Delay(1500);
                if (Enabled && DateTime.Now > tryAgainAt)
                    await Update();
            }
        });
    }

    private async Task Update()
    {
        try
        {
            Dictionary<int, object>? dps = await GetDpsAsync();

            if (dps.ContainsKey(DP.Watts))
            {
                Watts = Math.Round(Convert.ToDouble(dps[DP.Watts]) / 10, 0);
                LabelToUpdate.Text = Watts.ToString();
            }

            if (dps.ContainsKey(DP.Voltage))
            {
                Voltage = Math.Round(Convert.ToDouble(dps[DP.Voltage]) / 10, 0);
            }
        }
        catch (SocketException ex)
        {
            if (ex.SocketErrorCode == SocketError.TimedOut)
            {
                tryAgainAt = DateTime.Now.AddSeconds(45);
                Watts = 0;
                Voltage = 0;
            }
        }
    }
}
