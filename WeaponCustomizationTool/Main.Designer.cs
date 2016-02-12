namespace WeaponCustomizationTool {
	partial class Main {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.folderExtractDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.folderModsDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtConsole = new System.Windows.Forms.TextBox();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.btnProcessFolders = new System.Windows.Forms.Button();
			this.btnBrowseModsFolder = new System.Windows.Forms.Button();
			this.txtModsFolder = new System.Windows.Forms.TextBox();
			this.modFolderLabel = new System.Windows.Forms.Label();
			this.btnBrowseExtractFolder = new System.Windows.Forms.Button();
			this.txtExtractFolder = new System.Windows.Forms.TextBox();
			this.extractFolderLabel = new System.Windows.Forms.Label();
			this.extractPanel = new System.Windows.Forms.Panel();
			this.modFolderPanel = new System.Windows.Forms.Panel();
			this.processPanel = new System.Windows.Forms.Panel();
			this.progressLabel = new System.Windows.Forms.Label();
			this.optionsLabel = new System.Windows.Forms.Label();
			this.optionsPanel = new System.Windows.Forms.Panel();
			this.checkboxThirdperson = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.extractPanel.SuspendLayout();
			this.modFolderPanel.SuspendLayout();
			this.processPanel.SuspendLayout();
			this.optionsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtConsole);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(4, 172);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 396);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Console Log";
			// 
			// txtConsole
			// 
			this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtConsole.HideSelection = false;
			this.txtConsole.Location = new System.Drawing.Point(3, 16);
			this.txtConsole.MaxLength = 2000000000;
			this.txtConsole.Multiline = true;
			this.txtConsole.Name = "txtConsole";
			this.txtConsole.ReadOnly = true;
			this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtConsole.Size = new System.Drawing.Size(450, 377);
			this.txtConsole.TabIndex = 0;
			this.txtConsole.WordWrap = false;
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(4, 4);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(367, 21);
			this.progressBar.TabIndex = 1;
			// 
			// btnProcessFolders
			// 
			this.btnProcessFolders.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnProcessFolders.Location = new System.Drawing.Point(377, 4);
			this.btnProcessFolders.Name = "btnProcessFolders";
			this.btnProcessFolders.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnProcessFolders.Size = new System.Drawing.Size(75, 21);
			this.btnProcessFolders.TabIndex = 4;
			this.btnProcessFolders.Text = "Process";
			this.btnProcessFolders.UseVisualStyleBackColor = true;
			this.btnProcessFolders.Click += new System.EventHandler(this.btnProcessFolders_Click);
			// 
			// btnBrowseModsFolder
			// 
			this.btnBrowseModsFolder.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnBrowseModsFolder.Location = new System.Drawing.Point(377, 4);
			this.btnBrowseModsFolder.Name = "btnBrowseModsFolder";
			this.btnBrowseModsFolder.Size = new System.Drawing.Size(75, 21);
			this.btnBrowseModsFolder.TabIndex = 1;
			this.btnBrowseModsFolder.Text = "Browse";
			this.btnBrowseModsFolder.UseVisualStyleBackColor = true;
			this.btnBrowseModsFolder.Click += new System.EventHandler(this.btnBrowseModsFolder_Click);
			// 
			// txtModsFolder
			// 
			this.txtModsFolder.AcceptsReturn = true;
			this.txtModsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtModsFolder.Location = new System.Drawing.Point(4, 4);
			this.txtModsFolder.Name = "txtModsFolder";
			this.txtModsFolder.Size = new System.Drawing.Size(367, 20);
			this.txtModsFolder.TabIndex = 0;
			this.txtModsFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtModsFolder_KeyDown);
			// 
			// modFolderLabel
			// 
			this.modFolderLabel.AutoSize = true;
			this.modFolderLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.modFolderLabel.Location = new System.Drawing.Point(4, 46);
			this.modFolderLabel.Name = "modFolderLabel";
			this.modFolderLabel.Size = new System.Drawing.Size(111, 13);
			this.modFolderLabel.TabIndex = 2;
			this.modFolderLabel.Text = "Mod Overrides Folder:";
			// 
			// btnBrowseExtractFolder
			// 
			this.btnBrowseExtractFolder.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnBrowseExtractFolder.Location = new System.Drawing.Point(377, 4);
			this.btnBrowseExtractFolder.Name = "btnBrowseExtractFolder";
			this.btnBrowseExtractFolder.Size = new System.Drawing.Size(75, 21);
			this.btnBrowseExtractFolder.TabIndex = 0;
			this.btnBrowseExtractFolder.Text = "Browse";
			this.btnBrowseExtractFolder.UseVisualStyleBackColor = true;
			this.btnBrowseExtractFolder.Click += new System.EventHandler(this.btnBrowseExtractFolder_Click);
			// 
			// txtExtractFolder
			// 
			this.txtExtractFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtExtractFolder.Location = new System.Drawing.Point(3, 5);
			this.txtExtractFolder.Name = "txtExtractFolder";
			this.txtExtractFolder.Size = new System.Drawing.Size(368, 20);
			this.txtExtractFolder.TabIndex = 1;
			this.txtExtractFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExtractFolder_KeyDown);
			// 
			// extractFolderLabel
			// 
			this.extractFolderLabel.AutoSize = true;
			this.extractFolderLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.extractFolderLabel.Location = new System.Drawing.Point(4, 4);
			this.extractFolderLabel.Name = "extractFolderLabel";
			this.extractFolderLabel.Size = new System.Drawing.Size(75, 13);
			this.extractFolderLabel.TabIndex = 0;
			this.extractFolderLabel.Text = "Extract Folder:";
			// 
			// extractPanel
			// 
			this.extractPanel.Controls.Add(this.btnBrowseExtractFolder);
			this.extractPanel.Controls.Add(this.txtExtractFolder);
			this.extractPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.extractPanel.Location = new System.Drawing.Point(4, 17);
			this.extractPanel.Name = "extractPanel";
			this.extractPanel.Padding = new System.Windows.Forms.Padding(4);
			this.extractPanel.Size = new System.Drawing.Size(456, 29);
			this.extractPanel.TabIndex = 7;
			// 
			// modFolderPanel
			// 
			this.modFolderPanel.Controls.Add(this.btnBrowseModsFolder);
			this.modFolderPanel.Controls.Add(this.txtModsFolder);
			this.modFolderPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.modFolderPanel.Location = new System.Drawing.Point(4, 59);
			this.modFolderPanel.Name = "modFolderPanel";
			this.modFolderPanel.Padding = new System.Windows.Forms.Padding(4);
			this.modFolderPanel.Size = new System.Drawing.Size(456, 29);
			this.modFolderPanel.TabIndex = 8;
			// 
			// processPanel
			// 
			this.processPanel.Controls.Add(this.progressBar);
			this.processPanel.Controls.Add(this.btnProcessFolders);
			this.processPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.processPanel.Location = new System.Drawing.Point(4, 143);
			this.processPanel.Name = "processPanel";
			this.processPanel.Padding = new System.Windows.Forms.Padding(4);
			this.processPanel.Size = new System.Drawing.Size(456, 29);
			this.processPanel.TabIndex = 9;
			// 
			// progressLabel
			// 
			this.progressLabel.AutoSize = true;
			this.progressLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.progressLabel.Location = new System.Drawing.Point(4, 130);
			this.progressLabel.Name = "progressLabel";
			this.progressLabel.Size = new System.Drawing.Size(51, 13);
			this.progressLabel.TabIndex = 10;
			this.progressLabel.Text = "Progress:";
			// 
			// optionsLabel
			// 
			this.optionsLabel.AutoSize = true;
			this.optionsLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.optionsLabel.Location = new System.Drawing.Point(4, 88);
			this.optionsLabel.Name = "optionsLabel";
			this.optionsLabel.Size = new System.Drawing.Size(46, 13);
			this.optionsLabel.TabIndex = 11;
			this.optionsLabel.Text = "Options:";
			// 
			// optionsPanel
			// 
			this.optionsPanel.Controls.Add(this.checkboxThirdperson);
			this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.optionsPanel.Location = new System.Drawing.Point(4, 101);
			this.optionsPanel.Name = "optionsPanel";
			this.optionsPanel.Padding = new System.Windows.Forms.Padding(4);
			this.optionsPanel.Size = new System.Drawing.Size(456, 29);
			this.optionsPanel.TabIndex = 10;
			// 
			// checkboxThirdperson
			// 
			this.checkboxThirdperson.AutoSize = true;
			this.checkboxThirdperson.Dock = System.Windows.Forms.DockStyle.Left;
			this.checkboxThirdperson.Location = new System.Drawing.Point(4, 4);
			this.checkboxThirdperson.Name = "checkboxThirdperson";
			this.checkboxThirdperson.Size = new System.Drawing.Size(166, 21);
			this.checkboxThirdperson.TabIndex = 0;
			this.checkboxThirdperson.Text = "Include Third-person Models?";
			this.checkboxThirdperson.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 572);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.processPanel);
			this.Controls.Add(this.progressLabel);
			this.Controls.Add(this.optionsPanel);
			this.Controls.Add(this.optionsLabel);
			this.Controls.Add(this.modFolderPanel);
			this.Controls.Add(this.modFolderLabel);
			this.Controls.Add(this.extractPanel);
			this.Controls.Add(this.extractFolderLabel);
			this.MinimumSize = new System.Drawing.Size(240, 200);
			this.Name = "Main";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Text = "Weapon Customizer Processor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.extractPanel.ResumeLayout(false);
			this.extractPanel.PerformLayout();
			this.modFolderPanel.ResumeLayout(false);
			this.modFolderPanel.PerformLayout();
			this.processPanel.ResumeLayout(false);
			this.optionsPanel.ResumeLayout(false);
			this.optionsPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderExtractDialog;
		private System.Windows.Forms.FolderBrowserDialog folderModsDialog;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtConsole;
		private System.Windows.Forms.Button btnProcessFolders;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.TextBox txtModsFolder;
		private System.Windows.Forms.Button btnBrowseModsFolder;
		private System.Windows.Forms.Label modFolderLabel;
		private System.Windows.Forms.TextBox txtExtractFolder;
		private System.Windows.Forms.Button btnBrowseExtractFolder;
		private System.Windows.Forms.Label extractFolderLabel;
		private System.Windows.Forms.Panel extractPanel;
		private System.Windows.Forms.Panel modFolderPanel;
		private System.Windows.Forms.Panel processPanel;
		private System.Windows.Forms.Label progressLabel;
		private System.Windows.Forms.Label optionsLabel;
		private System.Windows.Forms.Panel optionsPanel;
		private System.Windows.Forms.CheckBox checkboxThirdperson;
	}
}

