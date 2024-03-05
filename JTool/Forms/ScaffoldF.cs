using JTool.Entities;
using JTool.Helpers;
using System.Diagnostics;
using System.Text.Json;

namespace JTool {
    public partial class ScaffoldF : Form {

        private Settings _settings;
        private Settings _latestSavedSettings;
        public ScaffoldF() {
            InitializeComponent();
            _settings = new Settings();
            _latestSavedSettings = new Settings();
            LoadSettingsFromFile();
        }

        private void LoadSettingsFromFile() {
            string filePath = "settings.json";
            if (File.Exists(filePath)) {
                string jsonString = File.ReadAllText(filePath);
                try {
                    _settings = JsonSerializer.Deserialize<Settings>(jsonString) ?? new Settings();
                    SetUI(_settings);
                } catch (JsonException ex) {
                    MessageBox.Show($"Error deserializing JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } catch (Exception ex) {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } else {
                UpdateSettingsFromUI();
                MessageBox.Show("Settings file not found. Please configure settings and save.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _latestSavedSettings = GetSettingsFromInputs();
        }

        #region Buttons_Click
        private async void btnScaffold_Click(object sender, EventArgs e) {
            var scaffoldHelper = new ScaffoldHelper(GetSettingsFromInputs());
            textOutputLog.AppendText("[" + DateTime.Now.ToString() + "]: Scaffold Operation Started..." + Environment.NewLine, Color.Blue);
            ShowEndOfLogger();
            try {
                string connectionString = textConnectionString.Text;
                string outputDir = textOutputDir.Text;
                string contextDir = textContextDir.Text;
                string projectDir = textProjectDirectory.Text;
                string flags = scaffoldHelper.BuildFlagString();

                string command = $"dotnet ef dbcontext scaffold \"{connectionString}\" Microsoft.EntityFrameworkCore.SqlServer --context-dir {contextDir} --output-dir {outputDir} {flags} --project {projectDir} ";

                ProcessStartInfo startInfo = new ProcessStartInfo {
                    FileName = "cmd.exe",
                    Arguments = $"/C \"{command}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    WorkingDirectory = projectDir,
                    CreateNoWindow = true,
                };

                using (Process process = new Process()) {
                    process.StartInfo = startInfo;
                    process.Start();

                    Task<string> outputTask = process.StandardOutput.ReadToEndAsync();
                    Task<string> errorTask = process.StandardError.ReadToEndAsync();
                    await Task.WhenAll(outputTask, errorTask);
                    string output = await outputTask;
                    string error = await errorTask;
                    textOutputLog.AppendText(output);
                    textOutputLog.AppendText(error);

                    Color color = process.ExitCode == 0 ? Color.Green : Color.OrangeRed;
                    textOutputLog.AppendText("Exit code: " + process.ExitCode + Environment.NewLine, color);
                }
            } catch (Exception ex) {
                textOutputLog.AppendText("An error occurred: " + ex.Message + Environment.NewLine, Color.Red);
            }

            textOutputLog.AppendText("[" + DateTime.Now.ToString() + "]: Scaffold Operation Finished." + Environment.NewLine + Environment.NewLine, Color.Blue);
            ShowEndOfLogger();
        }
        private void btnBrowseProjDir_Click(object sender, EventArgs e) {
            if (fbProjDirectory.ShowDialog() == DialogResult.OK) {
                textProjectDirectory.Text = fbProjDirectory.SelectedPath;
            }
        }
        private void btnSave_Click(object sender, EventArgs e) {
            UpdateSettingsFromUI();
            if (_settings.Equals(_latestSavedSettings)) return;
            _latestSavedSettings = GetSettingsFromInputs();

            string jsonString = JsonSerializer.Serialize(_settings);

            string filePath = "Settings.json";
            File.WriteAllText(filePath, jsonString);

            MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnClearLog_Click(object sender, EventArgs e) {
            textOutputLog.Text = String.Empty;
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        #region UI_Interactions
        private void SetUI(Settings settings) {
            textConnectionString.Text = settings.ConString;
            textProjectDirectory.Text = settings.ProjectDirectory;
            cbNoOnConfiguring.Checked = settings.ScaffoldFlags.NoOnConfiguring;
            cbForce.Checked = settings.ScaffoldFlags.Force;
            cbDataAnnotations.Checked = settings.ScaffoldFlags.DataAnnotations;
            textOutputDir.Text = settings.ScaffoldFlags.OutputDir;
            textContextDir.Text = settings.ScaffoldFlags.ContextDir;
        }
        private void UpdateSettingsFromUI() {
            _settings.ConString = textConnectionString.Text;
            _settings.ProjectDirectory = textProjectDirectory.Text;
            _settings.ScaffoldFlags.ContextDir = textContextDir.Text;
            _settings.ScaffoldFlags.OutputDir = textOutputDir.Text;
            _settings.ScaffoldFlags.NoOnConfiguring = cbNoOnConfiguring.Checked;
            _settings.ScaffoldFlags.Force = cbForce.Checked;
            _settings.ScaffoldFlags.DataAnnotations = cbDataAnnotations.Checked;
        }
        private Settings GetSettingsFromInputs() {
            var inputSettings = new Settings();
            inputSettings.ConString = textConnectionString.Text;
            inputSettings.ProjectDirectory = textProjectDirectory.Text;
            inputSettings.ScaffoldFlags.ContextDir = textContextDir.Text;
            inputSettings.ScaffoldFlags.OutputDir = textOutputDir.Text;
            inputSettings.ScaffoldFlags.NoOnConfiguring = cbNoOnConfiguring.Checked;
            inputSettings.ScaffoldFlags.Force = cbForce.Checked;
            inputSettings.ScaffoldFlags.DataAnnotations = cbDataAnnotations.Checked;
            return inputSettings;
        }
        private void ShowEndOfLogger() {
            textOutputLog.SelectionStart = textOutputLog.Text.Length;
            textOutputLog.ScrollToCaret();
        }
        #endregion
    }
}