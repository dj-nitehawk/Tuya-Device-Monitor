namespace SakoMonitor;

public partial class Main : Form
{
    //see here for the proceedure to obtain the local-keys of your devices
    //https://github.com/ClusterM/tuyanet#how-to-obtain-local-key

    private readonly Device grid = new("192.168.1.23", "692dab0ca5da5082", "bfacd5992b46f177235vz5") { PermanentConnection = true };
    private readonly Device ac = new("192.168.1.24", "88a31d7051f7799a", "bf46713b278690de85auaz") { PermanentConnection = true };
    private readonly Device house = new("192.168.1.25", "a26f8adb63258f9e", "63530822d8bfc0134df1") { PermanentConnection = true };

    private const double threshold = 50;

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
                UpdateFreeEnergyLabel(grid, house);
                Voltage_Value.Text = house.Voltage.ToString();
                await Task.Delay(1500);
            }
        });
    }

    private void UpdateFreeEnergyLabel(Device grid, Device house)
    {
        double diff = house.Watts - grid.Watts;

        if (diff < -threshold)
        {
            Free_Value.Text = diff.ToString();
            Free_Value.ForeColor = Color.DarkRed;
            Free.Text = "Charging Batt";
        }
        else if (diff > threshold)
        {
            Free_Value.Text = diff.ToString();
            Free_Value.ForeColor = Color.DarkGreen;
            Free.Text = "From PV/Batt";
        }
        else
        {
            Free_Value.Text = "0";
            Free_Value.ForeColor = Color.DarkRed;
            Free.Text = "From PV/Batt";
        }
    }

    private void Main_Resize(object sender, EventArgs e)
    {
        ac.Enabled = !ac.Enabled;
        grid.Enabled = !grid.Enabled;
        house.Enabled = !house.Enabled;
    }
}
