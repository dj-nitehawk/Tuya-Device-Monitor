namespace SakoMonitor;

partial class Main
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Group1 = new GroupBox();
        label1 = new Label();
        Grid_Value = new Label();
        groupBox1 = new GroupBox();
        label4 = new Label();
        House_Value = new Label();
        label2 = new Label();
        Voltage_Value = new Label();
        groupBox2 = new GroupBox();
        label6 = new Label();
        AC_Value = new Label();
        Group1.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // Group1
        // 
        Group1.BackColor = Color.Gainsboro;
        Group1.Controls.Add(label1);
        Group1.Controls.Add(Grid_Value);
        Group1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        Group1.ForeColor = Color.DarkBlue;
        Group1.Location = new Point(1, 1);
        Group1.Name = "Group1";
        Group1.Size = new Size(258, 31);
        Group1.TabIndex = 0;
        Group1.TabStop = false;
        Group1.Text = "Grid Supply";
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = Color.DimGray;
        label1.Location = new Point(181, 1);
        label1.Name = "label1";
        label1.Size = new Size(20, 26);
        label1.TabIndex = 2;
        label1.Text = "W";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Grid_Value
        // 
        Grid_Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        Grid_Value.ForeColor = Color.DarkRed;
        Grid_Value.Location = new Point(129, -3);
        Grid_Value.Name = "Grid_Value";
        Grid_Value.Size = new Size(57, 35);
        Grid_Value.TabIndex = 0;
        Grid_Value.Text = "000";
        Grid_Value.TextAlign = ContentAlignment.MiddleRight;
        // 
        // groupBox1
        // 
        groupBox1.BackColor = Color.Gainsboro;
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(House_Value);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(Voltage_Value);
        groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        groupBox1.ForeColor = Color.DarkBlue;
        groupBox1.Location = new Point(1, 33);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(258, 33);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "House Load";
        // 
        // label4
        // 
        label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label4.ForeColor = Color.DimGray;
        label4.Location = new Point(181, 1);
        label4.Name = "label4";
        label4.Size = new Size(20, 26);
        label4.TabIndex = 2;
        label4.Text = "W";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // House_Value
        // 
        House_Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        House_Value.ForeColor = Color.DarkRed;
        House_Value.Location = new Point(116, -4);
        House_Value.Name = "House_Value";
        House_Value.Size = new Size(70, 35);
        House_Value.TabIndex = 0;
        House_Value.Text = "0000";
        House_Value.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.Gray;
        label2.Location = new Point(237, 7);
        label2.Name = "label2";
        label2.Size = new Size(20, 15);
        label2.TabIndex = 3;
        label2.Text = "V";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Voltage_Value
        // 
        Voltage_Value.BackColor = Color.Transparent;
        Voltage_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        Voltage_Value.ForeColor = Color.DimGray;
        Voltage_Value.Location = new Point(199, 3);
        Voltage_Value.Margin = new Padding(1);
        Voltage_Value.Name = "Voltage_Value";
        Voltage_Value.Size = new Size(44, 23);
        Voltage_Value.TabIndex = 4;
        Voltage_Value.Text = "000";
        Voltage_Value.TextAlign = ContentAlignment.MiddleRight;
        // 
        // groupBox2
        // 
        groupBox2.BackColor = Color.Gainsboro;
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(AC_Value);
        groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        groupBox2.ForeColor = Color.DarkBlue;
        groupBox2.Location = new Point(1, 67);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(258, 31);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "My AirCon";
        // 
        // label6
        // 
        label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label6.ForeColor = Color.DimGray;
        label6.Location = new Point(181, 0);
        label6.Name = "label6";
        label6.Size = new Size(20, 26);
        label6.TabIndex = 2;
        label6.Text = "W";
        label6.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AC_Value
        // 
        AC_Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        AC_Value.ForeColor = Color.DarkRed;
        AC_Value.Location = new Point(115, -4);
        AC_Value.Name = "AC_Value";
        AC_Value.Size = new Size(72, 35);
        AC_Value.TabIndex = 0;
        AC_Value.Text = "0000";
        AC_Value.TextAlign = ContentAlignment.MiddleRight;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(260, 99);
        Controls.Add(groupBox2);
        Controls.Add(Group1);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Main";
        ShowIcon = false;
        ShowInTaskbar = false;
        SizeGripStyle = SizeGripStyle.Hide;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tuya Power Monitor";
        TopMost = true;
        Load += Main_Load;
        Resize += Main_Resize;
        Group1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox Group1;
    private Label label1;
    private Label Grid_Value;
    private GroupBox groupBox1;
    private Label label4;
    private Label House_Value;
    private GroupBox groupBox2;
    private Label label6;
    private Label AC_Value;
    private Label Voltage_Value;
    private Label label2;
}