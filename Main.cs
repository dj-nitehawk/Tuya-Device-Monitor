namespace SakoMonitor;

public partial class Main : Form
{
    //see here for the proceedure to obtain the local-keys of your devices
    //https://github.com/ClusterM/tuyanet#how-to-obtain-local-key

    private readonly Device grid = new("192.168.1.23", "8d5a42eb1aeb66b4", "bf68a2dbf6e09d0673nhrm") { PermanentConnection = true };
    private readonly Device ac = new("192.168.1.24", "0d3326d5ac7d718e", "bf46713b278690de85auaz") { PermanentConnection = true };
    private readonly Device house = new("192.168.1.25", "2e02e3117c8d97b9", "63530822d8bfc0134df1") { PermanentConnection = true };

    public Main() => InitializeComponent();

    private void Main_Load(object sender, EventArgs e)
    {
        CheckForIllegalCrossThreadCalls = false;

        grid.LabelToUpdate = Grid_Value;
        house.LabelToUpdate = House_Value;
        ac.LabelToUpdate = AC_Value;

        _ = Task.Run(async () =>
        {
            while (true)
            {
                Voltage_Value.Text = house.Voltage.ToString();
                await Task.Delay(2000);
            }
        });
    }

    private void Main_Resize(object sender, EventArgs e)
    {
        ac.Enabled = !ac.Enabled;
        grid.Enabled = !grid.Enabled;
        house.Enabled = !house.Enabled;
    }
}
