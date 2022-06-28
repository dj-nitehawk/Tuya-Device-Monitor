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
        this.Group1 = new System.Windows.Forms.GroupBox();
        this.label1 = new System.Windows.Forms.Label();
        this.Grid_Value = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.label4 = new System.Windows.Forms.Label();
        this.House_Value = new System.Windows.Forms.Label();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.label6 = new System.Windows.Forms.Label();
        this.AC_Value = new System.Windows.Forms.Label();
        this.Free = new System.Windows.Forms.GroupBox();
        this.label10 = new System.Windows.Forms.Label();
        this.Free_Value = new System.Windows.Forms.Label();
        this.Voltage_Value = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.Group1.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.Free.SuspendLayout();
        this.SuspendLayout();
        // 
        // Group1
        // 
        this.Group1.BackColor = System.Drawing.Color.Gainsboro;
        this.Group1.Controls.Add(this.label1);
        this.Group1.Controls.Add(this.Grid_Value);
        this.Group1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.Group1.ForeColor = System.Drawing.Color.DarkBlue;
        this.Group1.Location = new System.Drawing.Point(0, 0);
        this.Group1.Name = "Group1";
        this.Group1.Size = new System.Drawing.Size(132, 79);
        this.Group1.TabIndex = 0;
        this.Group1.TabStop = false;
        this.Group1.Text = "Grid Supply";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.label1.ForeColor = System.Drawing.Color.DimGray;
        this.label1.Location = new System.Drawing.Point(57, 52);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(20, 26);
        this.label1.TabIndex = 2;
        this.label1.Text = "W";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Grid_Value
        // 
        this.Grid_Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.Grid_Value.ForeColor = System.Drawing.Color.DarkRed;
        this.Grid_Value.Location = new System.Drawing.Point(33, 24);
        this.Grid_Value.Name = "Grid_Value";
        this.Grid_Value.Size = new System.Drawing.Size(70, 35);
        this.Grid_Value.TabIndex = 0;
        this.Grid_Value.Text = "0000";
        this.Grid_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // groupBox1
        // 
        this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.House_Value);
        this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
        this.groupBox1.Location = new System.Drawing.Point(0, 110);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(132, 75);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "House Load";
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.label4.ForeColor = System.Drawing.Color.DimGray;
        this.label4.Location = new System.Drawing.Point(55, 51);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(20, 26);
        this.label4.TabIndex = 2;
        this.label4.Text = "W";
        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // House_Value
        // 
        this.House_Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.House_Value.ForeColor = System.Drawing.Color.DarkRed;
        this.House_Value.Location = new System.Drawing.Point(30, 23);
        this.House_Value.Name = "House_Value";
        this.House_Value.Size = new System.Drawing.Size(70, 35);
        this.House_Value.TabIndex = 0;
        this.House_Value.Text = "0000";
        this.House_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // groupBox2
        // 
        this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
        this.groupBox2.Controls.Add(this.label6);
        this.groupBox2.Controls.Add(this.AC_Value);
        this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
        this.groupBox2.Location = new System.Drawing.Point(153, 0);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(170, 79);
        this.groupBox2.TabIndex = 2;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Air Conditioner";
        // 
        // label6
        // 
        this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.label6.ForeColor = System.Drawing.Color.DimGray;
        this.label6.Location = new System.Drawing.Point(74, 53);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(20, 26);
        this.label6.TabIndex = 2;
        this.label6.Text = "W";
        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AC_Value
        // 
        this.AC_Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.AC_Value.ForeColor = System.Drawing.Color.DarkRed;
        this.AC_Value.Location = new System.Drawing.Point(47, 25);
        this.AC_Value.Name = "AC_Value";
        this.AC_Value.Size = new System.Drawing.Size(72, 35);
        this.AC_Value.TabIndex = 0;
        this.AC_Value.Text = "0000";
        this.AC_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Free
        // 
        this.Free.BackColor = System.Drawing.Color.Gainsboro;
        this.Free.Controls.Add(this.label10);
        this.Free.Controls.Add(this.Free_Value);
        this.Free.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.Free.ForeColor = System.Drawing.Color.DarkBlue;
        this.Free.Location = new System.Drawing.Point(153, 110);
        this.Free.Name = "Free";
        this.Free.Size = new System.Drawing.Size(170, 75);
        this.Free.TabIndex = 3;
        this.Free.TabStop = false;
        this.Free.Text = "From PV/Batt";
        // 
        // label10
        // 
        this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.label10.ForeColor = System.Drawing.Color.DimGray;
        this.label10.Location = new System.Drawing.Point(72, 52);
        this.label10.Name = "label10";
        this.label10.Size = new System.Drawing.Size(20, 26);
        this.label10.TabIndex = 2;
        this.label10.Text = "W";
        this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Free_Value
        // 
        this.Free_Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.Free_Value.ForeColor = System.Drawing.Color.DarkRed;
        this.Free_Value.Location = new System.Drawing.Point(47, 24);
        this.Free_Value.Name = "Free_Value";
        this.Free_Value.Size = new System.Drawing.Size(71, 35);
        this.Free_Value.TabIndex = 0;
        this.Free_Value.Text = "0000";
        this.Free_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Voltage_Value
        // 
        this.Voltage_Value.BackColor = System.Drawing.Color.Transparent;
        this.Voltage_Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.Voltage_Value.ForeColor = System.Drawing.Color.DimGray;
        this.Voltage_Value.Location = new System.Drawing.Point(117, 77);
        this.Voltage_Value.Margin = new System.Windows.Forms.Padding(1);
        this.Voltage_Value.Name = "Voltage_Value";
        this.Voltage_Value.Size = new System.Drawing.Size(56, 27);
        this.Voltage_Value.TabIndex = 4;
        this.Voltage_Value.Text = "000";
        this.Voltage_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
        this.label2.ForeColor = System.Drawing.Color.Gray;
        this.label2.Location = new System.Drawing.Point(164, 77);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(20, 26);
        this.label2.TabIndex = 3;
        this.label2.Text = "V";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Main
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(325, 187);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.Group1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.Voltage_Value);
        this.Controls.Add(this.Free);
        this.Controls.Add(this.groupBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Main";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Tuya Power Monitor";
        this.TopMost = true;
        this.Load += new System.EventHandler(this.Main_Load);
        this.Resize += new System.EventHandler(this.Main_Resize);
        this.Group1.ResumeLayout(false);
        this.groupBox1.ResumeLayout(false);
        this.groupBox2.ResumeLayout(false);
        this.Free.ResumeLayout(false);
        this.ResumeLayout(false);

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
    private GroupBox Free;
    private Label label10;
    private Label Free_Value;
    private Label Voltage_Value;
    private Label label2;
}