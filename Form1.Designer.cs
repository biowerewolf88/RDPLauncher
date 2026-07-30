namespace RDPLauncher;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        cmbProfiles = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        lblMain = new Label();
        lblBackup = new Label();
        lblActive = new Label();
        lblStatus = new Label();
        btnRefresh = new Button();
        btnConnect = new Button();
        lblMainDot = new Label();
        lblBackupDot = new Label();
        label6 = new Label();
        lblLastCheck = new Label();
        btnAbout = new Label();
        label7 = new Label();
        SuspendLayout();
        // 
        // cmbProfiles
        // 
        cmbProfiles.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProfiles.FormattingEnabled = true;
        resources.ApplyResources(cmbProfiles, "cmbProfiles");
        cmbProfiles.Name = "cmbProfiles";
        cmbProfiles.SelectedIndexChanged += cmbProfiles_SelectedIndexChanged;
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.Name = "label1";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        resources.ApplyResources(label2, "label2");
        label2.Name = "label2";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        resources.ApplyResources(label3, "label3");
        label3.Name = "label3";
        // 
        // label4
        // 
        resources.ApplyResources(label4, "label4");
        label4.Name = "label4";
        // 
        // label5
        // 
        resources.ApplyResources(label5, "label5");
        label5.Name = "label5";
        // 
        // lblMain
        // 
        resources.ApplyResources(lblMain, "lblMain");
        lblMain.Name = "lblMain";
        lblMain.Click += lblMain_Click;
        // 
        // lblBackup
        // 
        resources.ApplyResources(lblBackup, "lblBackup");
        lblBackup.Name = "lblBackup";
        // 
        // lblActive
        // 
        resources.ApplyResources(lblActive, "lblActive");
        lblActive.Name = "lblActive";
        // 
        // lblStatus
        // 
        resources.ApplyResources(lblStatus, "lblStatus");
        lblStatus.Name = "lblStatus";
        // 
        // btnRefresh
        // 
        resources.ApplyResources(btnRefresh, "btnRefresh");
        btnRefresh.Name = "btnRefresh";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnConnect
        // 
        btnConnect.BackColor = Color.LightGreen;
        resources.ApplyResources(btnConnect, "btnConnect");
        btnConnect.Name = "btnConnect";
        btnConnect.UseVisualStyleBackColor = false;
        btnConnect.Click += btnConnect_Click;
        // 
        // lblMainDot
        // 
        lblMainDot.ForeColor = Color.Gray;
        resources.ApplyResources(lblMainDot, "lblMainDot");
        lblMainDot.Name = "lblMainDot";
        // 
        // lblBackupDot
        // 
        lblBackupDot.ForeColor = Color.Gray;
        resources.ApplyResources(lblBackupDot, "lblBackupDot");
        lblBackupDot.Name = "lblBackupDot";
        // 
        // label6
        // 
        label6.BackColor = SystemColors.Control;
        resources.ApplyResources(label6, "label6");
        label6.Name = "label6";
        // 
        // lblLastCheck
        // 
        resources.ApplyResources(lblLastCheck, "lblLastCheck");
        lblLastCheck.Name = "lblLastCheck";
        // 
        // btnAbout
        // 
        resources.ApplyResources(btnAbout, "btnAbout");
        btnAbout.Name = "btnAbout";
        btnAbout.Click += label7_Click;
        // 
        // label7
        // 
        resources.ApplyResources(label7, "label7");
        label7.Name = "label7";
        // 
        // Form1
        // 
        AcceptButton = btnConnect;
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label7);
        Controls.Add(btnAbout);
        Controls.Add(lblLastCheck);
        Controls.Add(label6);
        Controls.Add(lblBackupDot);
        Controls.Add(lblMainDot);
        Controls.Add(btnConnect);
        Controls.Add(btnRefresh);
        Controls.Add(lblStatus);
        Controls.Add(lblActive);
        Controls.Add(lblBackup);
        Controls.Add(lblMain);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(cmbProfiles);
        MaximizeBox = false;
        Name = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion

    private ComboBox cmbProfiles;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label lblMain;
    private Label lblBackup;
    private Label lblActive;
    private Label lblStatus;
    private Button btnRefresh;
    private Button btnConnect;
    private Label lblMainDot;
    private Label lblBackupDot;
    private Label label6;
    private Label lblLastCheck;
    private Label btnAbout;
    private Label label7;
}
