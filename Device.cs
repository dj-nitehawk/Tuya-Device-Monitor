using com.clusterrr.TuyaNet;
using System.Net.Sockets;

namespace SakoMonitor;

internal class Device : TuyaDevice
{
    public double Watts { get; set; }
    public double Voltage { get; set; }

    private DateTime tryAgainAt;

    public Device(
        string ip,
        string localKey,
        string deviceId,
        TuyaProtocolVersion protocolVersion = TuyaProtocolVersion.V33,
        int port = 6668,
        int receiveTimeout = 250
        ) : base(ip, localKey, deviceId, protocolVersion, port, receiveTimeout) { }

    public async Task UpdateLabels(Label watts)
    {
        if (DateTime.Now < tryAgainAt)
        {
            return;
        }

        await ReadStatus();
        watts.Text = Watts.ToString();
    }

    private async Task ReadStatus()
    {
        try
        {
            Dictionary<int, object>? dps = await GetDpsAsync();

            if (dps.ContainsKey(DP.Watts))
            {
                Watts = Math.Round(Convert.ToDouble(dps[DP.Watts]) / 10, 0);
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
