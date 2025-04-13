namespace JTool {
    partial class ScaffoldF {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            textConnectionString = new TextBox();
            fbProjDirectory = new FolderBrowserDialog();
            textProjectDirectory = new TextBox();
            btnBrowseProjDir = new Button();
            btnScaffold = new Button();
            textOutputLog = new RichTextBox();
            textOutputDir = new TextBox();
            textContextDir = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            lbConnectionString = new Label();
            lbProjectDir = new Label();
            lbContextDirName = new Label();
            lbOutputDirName = new Label();
            cbNoOnConfiguring = new CheckBox();
            cbForce = new CheckBox();
            cbDataAnnotations = new CheckBox();
            btnClearLog = new Button();
            SuspendLayout();
            // 
            // textConnectionString
            // 
            textConnectionString.Location = new Point(121, 27);
            textConnectionString.Name = "textConnectionString";
            textConnectionString.Size = new Size(667, 23);
            textConnectionString.TabIndex = 2;
            textConnectionString.Text = "Connection String";
            // 
            // textProjectDirectory
            // 
            textProjectDirectory.Location = new Point(121, 56);
            textProjectDirectory.Name = "textProjectDirectory";
            textProjectDirectory.Size = new Size(586, 23);
            textProjectDirectory.TabIndex = 3;
            textProjectDirectory.Text = "Project Directory...";
            // 
            // btnBrowseProjDir
            // 
            btnBrowseProjDir.Location = new Point(713, 56);
            btnBrowseProjDir.Name = "btnBrowseProjDir";
            btnBrowseProjDir.Size = new Size(75, 23);
            btnBrowseProjDir.TabIndex = 4;
            btnBrowseProjDir.Text = "Browse...";
            btnBrowseProjDir.UseVisualStyleBackColor = true;
            btnBrowseProjDir.Click += btnBrowseProjDir_Click;
            // 
            // btnScaffold
            // 
            btnScaffold.Location = new Point(12, 410);
            btnScaffold.Name = "btnScaffold";
            btnScaffold.Size = new Size(122, 28);
            btnScaffold.TabIndex = 5;
            btnScaffold.Text = "Scaffold";
            btnScaffold.UseVisualStyleBackColor = true;
            btnScaffold.Click += btnScaffold_Click;
            // 
            // textOutputLog
            // 
            textOutputLog.AcceptsTab = true;
            textOutputLog.BackColor = SystemColors.InactiveBorder;
            textOutputLog.Location = new Point(12, 173);
            textOutputLog.Name = "textOutputLog";
            textOutputLog.ReadOnly = true;
            textOutputLog.Size = new Size(776, 189);
            textOutputLog.TabIndex = 6;
            textOutputLog.Text = "";
            // 
            // textOutputDir
            // 
            textOutputDir.Location = new Point(153, 125);
            textOutputDir.Name = "textOutputDir";
            textOutputDir.Size = new Size(198, 23);
            textOutputDir.TabIndex = 7;
            textOutputDir.Text = "Output Directory";
            // 
            // textContextDir
            // 
            textContextDir.Location = new Point(153, 96);
            textContextDir.Name = "textContextDir";
            textContextDir.Size = new Size(198, 23);
            textContextDir.TabIndex = 8;
            textContextDir.Text = "Context Directory";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(538, 410);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 28);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(666, 410);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 28);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbConnectionString
            // 
            lbConnectionString.AutoSize = true;
            lbConnectionString.Location = new Point(12, 27);
            lbConnectionString.Name = "lbConnectionString";
            lbConnectionString.Size = new Size(103, 15);
            lbConnectionString.TabIndex = 11;
            lbConnectionString.Text = "Connection String";
            // 
            // lbProjectDir
            // 
            lbProjectDir.AutoSize = true;
            lbProjectDir.Location = new Point(12, 59);
            lbProjectDir.Name = "lbProjectDir";
            lbProjectDir.Size = new Size(95, 15);
            lbProjectDir.TabIndex = 12;
            lbProjectDir.Text = "Project Directory";
            // 
            // lbContextDirName
            // 
            lbContextDirName.AutoSize = true;
            lbContextDirName.Location = new Point(12, 99);
            lbContextDirName.Name = "lbContextDirName";
            lbContextDirName.Size = new Size(135, 15);
            lbContextDirName.TabIndex = 13;
            lbContextDirName.Text = "Context Directory Name";
            // 
            // lbOutputDirName
            // 
            lbOutputDirName.AutoSize = true;
            lbOutputDirName.Location = new Point(16, 128);
            lbOutputDirName.Name = "lbOutputDirName";
            lbOutputDirName.Size = new Size(131, 15);
            lbOutputDirName.TabIndex = 14;
            lbOutputDirName.Text = "Output Directory Name";
            // 
            // cbNoOnConfiguring
            // 
            cbNoOnConfiguring.AutoSize = true;
            cbNoOnConfiguring.Location = new Point(471, 96);
            cbNoOnConfiguring.Name = "cbNoOnConfiguring";
            cbNoOnConfiguring.Size = new Size(138, 19);
            cbNoOnConfiguring.TabIndex = 15;
            cbNoOnConfiguring.Text = "No On Configuration";
            cbNoOnConfiguring.UseVisualStyleBackColor = true;
            // 
            // cbForce
            // 
            cbForce.AutoSize = true;
            cbForce.Location = new Point(471, 121);
            cbForce.Name = "cbForce";
            cbForce.Size = new Size(55, 19);
            cbForce.TabIndex = 16;
            cbForce.Text = "Force";
            cbForce.UseVisualStyleBackColor = true;
            // 
            // cbDataAnnotations
            // 
            cbDataAnnotations.AutoSize = true;
            cbDataAnnotations.Location = new Point(471, 146);
            cbDataAnnotations.Name = "cbDataAnnotations";
            cbDataAnnotations.Size = new Size(118, 19);
            cbDataAnnotations.TabIndex = 17;
            cbDataAnnotations.Text = "Data Annotations";
            cbDataAnnotations.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            btnClearLog.Location = new Point(713, 368);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(75, 23);
            btnClearLog.TabIndex = 18;
            btnClearLog.Text = "Clear Log";
            btnClearLog.UseVisualStyleBackColor = true;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // ScaffoldF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearLog);
            Controls.Add(cbDataAnnotations);
            Controls.Add(cbForce);
            Controls.Add(cbNoOnConfiguring);
            Controls.Add(lbOutputDirName);
            Controls.Add(lbContextDirName);
            Controls.Add(lbProjectDir);
            Controls.Add(lbConnectionString);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(textContextDir);
            Controls.Add(textOutputDir);
            Controls.Add(textOutputLog);
            Controls.Add(btnScaffold);
            Controls.Add(btnBrowseProjDir);
            Controls.Add(textProjectDirectory);
            Controls.Add(textConnectionString);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ScaffoldF";
            ShowIcon = false;
            Text = "Scaffold";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textConnectionString;
        private FolderBrowserDialog fbProjDirectory;
        private TextBox textProjectDirectory;
        private Button btnBrowseProjDir;
        private Button btnScaffold;
        private RichTextBox textOutputLog;
        private TextBox textOutputDir;
        private TextBox textContextDir;
        private Button btnSave;
        private Button btnClose;
        private Label lbConnectionString;
        private Label lbProjectDir;
        private Label lbContextDirName;
        private Label lbOutputDirName;
        private CheckBox cbNoOnConfiguring;
        private CheckBox cbForce;
        private CheckBox cbDataAnnotations;
        private Button btnClearLog;
    }
}