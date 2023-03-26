namespace SakoMonitor;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Main());

        //Task.Run(async () =>
        //{
        //    var api = new TuyaApi(region: TuyaApi.Region.CentralEurope, accessId: "", apiSecret: "");
        //    var device = await api.GetDeviceInfoAsync("bfacd5992b46f177235vz5");
        //    Console.WriteLine($"Device: {device.Name}, device ID: {device.Id}, local key: {device.LocalKey}");
        //}).GetAwaiter().GetResult();
    }
}