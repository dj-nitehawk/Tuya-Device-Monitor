//using com.clusterrr.TuyaNet;
//using System.Diagnostics;

namespace SakoMonitor;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        //Task.Run(async () =>
        //{
        //    var api = new TuyaApi(region: TuyaApi.Region.CentralEurope, accessId: "xxx", apiSecret: "xxx");
        //    var device = await api.GetDeviceInfoAsync("xxx");
        //    Debug.WriteLine($"Device: {device.Name}, device ID: {device.Id}, local key: {device.LocalKey}");
        //}).GetAwaiter().GetResult();

        ApplicationConfiguration.Initialize();
        Application.Run(new Main());
    }
}