using com.clusterrr.TuyaNet;

namespace SakoMonitor;

internal class Device : TuyaDevice
{
    public double Watts { get; set; }
    public double Voltage { get; set; }

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
        await ReadStatus();
        watts.Text = Watts.ToString();
    }

    private async Task ReadStatus()
    {
        try
        {
            var dps = await GetDpsAsync();

            if (dps.ContainsKey(DP.Watts))
                Watts = Math.Round(Convert.ToDouble(dps[DP.Watts]) / 10, 0);

            if (dps.ContainsKey(DP.Voltage))
                Voltage = Math.Round(Convert.ToDouble(dps[DP.Voltage]) / 10, 0);
        }
        catch
        {
            return;
        }
    }
}
