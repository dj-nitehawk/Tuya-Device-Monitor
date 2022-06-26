namespace SakoMonitor;

public partial class Main : Form
{
    //see here for the proceedure to obtain the local-keys of your devices
    //https://github.com/ClusterM/tuyanet#how-to-obtain-local-key

    private readonly Device grid = new("192.168.1.23", "0579bb27e3c60cdc", "83330616a4e57c13e21c") { PermanentConnection = true };
    private readonly Device ac = new("192.168.1.24", "88a31d7051f7799a", "bf46713b278690de85auaz") { PermanentConnection = true };
    private readonly Device house = new("192.168.1.25", "a26f8adb63258f9e", "63530822d8bfc0134df1") { PermanentConnection = true };

    public Main() => InitializeComponent();

    private async void Main_Load(object sender, EventArgs e)
    {
        while (true)
        {
            if (WindowState == FormWindowState.Normal)
            {
                _ = grid.UpdateLabels(Grid_Value);
                _ = house.UpdateLabels(House_Value);
                _ = ac.UpdateLabels(AC_Value);
                UpdateFreeEnergyLabel(grid, house);
                Voltage_Value.Text = house.Voltage.ToString();
            }
            await Task.Delay(1000);
        }
    }

    private void UpdateFreeEnergyLabel(Device grid, Device house)
    {
        double diff = house.Watts - grid.Watts;

        if (diff < -50)
        {
            Free_Value.Text = diff.ToString();
            Free_Value.ForeColor = Color.DarkRed;
            Free.Text = "Charging Batt";
        }
        else if (diff > 50)
        {
            Free_Value.Text = diff.ToString();
            Free_Value.ForeColor = Color.DarkGreen;
            Free.Text = "From PV/Batt";
        }
    }
}
