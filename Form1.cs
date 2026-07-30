using System.Diagnostics;
using System.IO;
namespace RDPLauncher;

public partial class Form1 : Form
{
    private AppConfig? config;
    private Settings settings = new();
    public Form1()
    {
        InitializeComponent();

        LoadConfig();
    }
    private void LoadConfig()
    {
        try
        {
            settings.Load();

            config = IniReader.Load(Path.Combine(Application.StartupPath, "config.ini"));

            cmbProfiles.Items.Clear();

            foreach (var profile in config.Profiles)
            {
                cmbProfiles.Items.Add(profile.Name);
            }

            if (cmbProfiles.Items.Count > 0)
            {
                if (settings.LastProfile >= 0 &&
                    settings.LastProfile < cmbProfiles.Items.Count)
                {
                    cmbProfiles.SelectedIndex = settings.LastProfile;
                }
                else
                {
                    cmbProfiles.SelectedIndex = 0;
                }
            }

            _ = RefreshStatus();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            lblStatus.Text = "Ошибка";
            lblStatus.ForeColor = Color.Red;
        }
    }
    private async Task RefreshStatus()
    {
        if (config == null)
            return;

        lblStatus.Text = "Проверка...";
        lblStatus.ForeColor = Color.DarkOrange;

        bool mainOk = await ServerChecker.CheckPortAsync(
            config.Servers.MainIP,
            config.Servers.MainPort);

        bool backupOk = await ServerChecker.CheckPortAsync(
            config.Servers.BackupIP,
            config.Servers.BackupPort);

        // Основной
        lblMainDot.ForeColor = mainOk ? Color.Green : Color.Red;
        lblMain.Text = mainOk ? "Онлайн" : "Недоступен";

        // Резервный
        lblBackupDot.ForeColor = backupOk ? Color.Green : Color.Red;
        lblBackup.Text = backupOk ? "Онлайн" : "Недоступен";

        if (mainOk)
        {
            lblActive.Text = "Основной";

            lblStatus.Text = "Готов к подключению";
            lblStatus.ForeColor = Color.Green;

            btnConnect.Enabled = true;
        }
        else if (backupOk)
        {
            lblActive.Text = "Резервный";

            lblStatus.Text = "Будет использован резервный сервер";
            lblStatus.ForeColor = Color.DarkOrange;

            btnConnect.Enabled = true;
        }
        else
        {
            lblActive.Text = "Нет";

            lblStatus.Text = "Оба сервера недоступны";
            lblStatus.ForeColor = Color.Red;

            btnConnect.Enabled = false;
        }

        lblLastCheck.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
    }
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        await RefreshStatus();
    }

    private async void btnConnect_Click(object sender, EventArgs e)
    {
        if (config == null)
            return;
        if (cmbProfiles.SelectedIndex < 0)
        {
            MessageBox.Show(
                "Выберите рабочее место.",
                "Внимание",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }
        await RefreshStatus();

        if (!btnConnect.Enabled)
            return;

        var profile = config.Profiles[cmbProfiles.SelectedIndex];

        string rdpFile;

        bool mainOk = await ServerChecker.CheckPortAsync(
            config.Servers.MainIP,
            config.Servers.MainPort);

        if (mainOk)
            rdpFile = profile.MainRdp;
        else
            rdpFile = profile.BackupRdp;

        string fullPath = Path.Combine(
            Application.StartupPath,
            rdpFile);

        if (!File.Exists(fullPath))
        {
            MessageBox.Show(
                $"Файл не найден:\n\n{rdpFile}",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = fullPath,
                UseShellExecute = true
            });

            if (config.Options.CloseAfterLaunch)
            {
                Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Не удалось запустить RDP.\n\n{ex.Message}",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void lblMain_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {
        using (var about = new AboutForm())
        {
            about.ShowDialog(this);
        }
    }

    private void cmbProfiles_SelectedIndexChanged(object sender, EventArgs e)
    {
        settings.LastProfile = cmbProfiles.SelectedIndex;
        settings.Save();
    }

    public OptionsConfig Options { get; set; } = new();
}
