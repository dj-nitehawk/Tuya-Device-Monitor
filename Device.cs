using com.clusterrr.TuyaNet;
using System.Net.Sockets;

namespace SakoMonitor;

internal class Device : TuyaDevice
{
    public double Watts { get; set; }
    public double Voltage { get; set; }
    public Label LabelToUpdate { get; set; } = null!;
    public bool Enabled { get; set; } = true;

    private DateTime tryAgainAt;

    public Device(string ip,
                  string localKey,
                  string deviceId,
                  TuyaProtocolVersion protocolVersion = TuyaProtocolVersion.V33,
                  int port = 6668,
                  int receiveTimeout = 250) : base(ip, localKey, deviceId, protocolVersion, port, receiveTimeout)
    {
        _ = Task.Run(async () =>
        {
            while (true)
            {
                if (Enabled && DateTime.Now > tryAgainAt)
                    await Update();

                await Task.Delay(2000);
            }
        });
    }

    private async Task Update()
    {
        try
        {
            Dictionary<int, object>? dps = await GetDpsAsync();

            if (dps.TryGetValue(DP.Watts, out object? watts))
            {
                Watts = Math.Round(Convert.ToDouble(watts) / 10, 0);
                LabelToUpdate.Text = Watts.ToString();
            }

            if (dps.TryGetValue(DP.Voltage, out object? voltage))
            {
                Voltage = Math.Round(Convert.ToDouble(voltage) / 10, 0);
            }
        }
        catch (SocketException ex)
        {
            if (ex.SocketErrorCode == SocketError.TimedOut)
            {
                tryAgainAt = DateTime.Now.AddSeconds(30);
                Watts = 0;
                Voltage = 0;
            }
        }
    }
}
