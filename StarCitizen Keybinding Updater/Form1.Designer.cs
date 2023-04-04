namespace StarCitizen_Keybinding_Updater
{
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
            this.browseBackupButton = new System.Windows.Forms.Button();
            this.clearLocationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backupLocationLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.liveLocationLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ptuLocationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.browseLiveButton = new System.Windows.Forms.Button();
            this.ClearLiveButton = new System.Windows.Forms.Button();
            this.ClearPtuButton = new System.Windows.Forms.Button();
            this.browsePtuButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.UpdatePtuButton = new System.Windows.Forms.Button();
            this.UpdateLiveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OutcomeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseBackupButton
            // 
            this.browseBackupButton.Location = new System.Drawing.Point(21, 130);
            this.browseBackupButton.Name = "browseBackupButton";
            this.browseBackupButton.Size = new System.Drawing.Size(75, 23);
            this.browseBackupButton.TabIndex = 0;
            this.browseBackupButton.Text = "Browse";
            this.browseBackupButton.UseVisualStyleBackColor = true;
            this.browseBackupButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // clearLocationButton
            // 
            this.clearLocationButton.BackColor = System.Drawing.Color.RosyBrown;
            this.clearLocationButton.Location = new System.Drawing.Point(135, 130);
            this.clearLocationButton.Name = "clearLocationButton";
            this.clearLocationButton.Size = new System.Drawing.Size(93, 23);
            this.clearLocationButton.TabIndex = 3;
            this.clearLocationButton.Text = "Clear Location";
            this.clearLocationButton.UseVisualStyleBackColor = false;
            this.clearLocationButton.Click += new System.EventHandler(this.ClearLocationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backup location:";
            // 
            // backupLocationLabel
            // 
            this.backupLocationLabel.Location = new System.Drawing.Point(14, 28);
            this.backupLocationLabel.Name = "backupLocationLabel";
            this.backupLocationLabel.Size = new System.Drawing.Size(174, 69);
            this.backupLocationLabel.TabIndex = 2;
            this.backupLocationLabel.Text = "unknown";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.backupLocationLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 108);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.liveLocationLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(286, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 108);
            this.panel2.TabIndex = 5;
            // 
            // liveLocationLabel
            // 
            this.liveLocationLabel.Location = new System.Drawing.Point(14, 28);
            this.liveLocationLabel.Name = "liveLocationLabel";
            this.liveLocationLabel.Size = new System.Drawing.Size(174, 69);
            this.liveLocationLabel.TabIndex = 2;
            this.liveLocationLabel.Text = "unknown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "LIVE location:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.ptuLocationLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(552, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 108);
            this.panel3.TabIndex = 6;
            // 
            // ptuLocationLabel
            // 
            this.ptuLocationLabel.Location = new System.Drawing.Point(14, 28);
            this.ptuLocationLabel.Name = "ptuLocationLabel";
            this.ptuLocationLabel.Size = new System.Drawing.Size(174, 69);
            this.ptuLocationLabel.TabIndex = 2;
            this.ptuLocationLabel.Text = "unknown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "PTU location:";
            // 
            // browseLiveButton
            // 
            this.browseLiveButton.Location = new System.Drawing.Point(286, 130);
            this.browseLiveButton.Name = "browseLiveButton";
            this.browseLiveButton.Size = new System.Drawing.Size(75, 23);
            this.browseLiveButton.TabIndex = 7;
            this.browseLiveButton.Text = "Browse";
            this.browseLiveButton.UseVisualStyleBackColor = true;
            this.browseLiveButton.Click += new System.EventHandler(this.browseLiveButton_Click);
            // 
            // ClearLiveButton
            // 
            this.ClearLiveButton.BackColor = System.Drawing.Color.RosyBrown;
            this.ClearLiveButton.Location = new System.Drawing.Point(400, 130);
            this.ClearLiveButton.Name = "ClearLiveButton";
            this.ClearLiveButton.Size = new System.Drawing.Size(93, 23);
            this.ClearLiveButton.TabIndex = 8;
            this.ClearLiveButton.Text = "Clear Location";
            this.ClearLiveButton.UseVisualStyleBackColor = false;
            this.ClearLiveButton.Click += new System.EventHandler(this.ClearLiveButton_Click);
            // 
            // ClearPtuButton
            // 
            this.ClearPtuButton.BackColor = System.Drawing.Color.RosyBrown;
            this.ClearPtuButton.Location = new System.Drawing.Point(666, 130);
            this.ClearPtuButton.Name = "ClearPtuButton";
            this.ClearPtuButton.Size = new System.Drawing.Size(93, 23);
            this.ClearPtuButton.TabIndex = 9;
            this.ClearPtuButton.Text = "Clear Location";
            this.ClearPtuButton.UseVisualStyleBackColor = false;
            this.ClearPtuButton.Click += new System.EventHandler(this.ClearPtuButton_Click);
            // 
            // browsePtuButton
            // 
            this.browsePtuButton.Location = new System.Drawing.Point(552, 130);
            this.browsePtuButton.Name = "browsePtuButton";
            this.browsePtuButton.Size = new System.Drawing.Size(75, 23);
            this.browsePtuButton.TabIndex = 10;
            this.browsePtuButton.Text = "Browse";
            this.browsePtuButton.UseVisualStyleBackColor = true;
            this.browsePtuButton.Click += new System.EventHandler(this.browsePtuButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(246, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(328, 30);
            this.Title.TabIndex = 11;
            this.Title.Text = "Star Citizen Keybinding Updater";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.ClearLiveButton);
            this.panel4.Controls.Add(this.ClearPtuButton);
            this.panel4.Controls.Add(this.browsePtuButton);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.browseBackupButton);
            this.panel4.Controls.Add(this.clearLocationButton);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.browseLiveButton);
            this.panel4.Location = new System.Drawing.Point(15, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(773, 158);
            this.panel4.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(363, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Configuration";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.UpdatePtuButton);
            this.panel5.Controls.Add(this.UpdateLiveButton);
            this.panel5.Location = new System.Drawing.Point(301, 371);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 70);
            this.panel5.TabIndex = 14;
            // 
            // UpdatePtuButton
            // 
            this.UpdatePtuButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.UpdatePtuButton.Location = new System.Drawing.Point(110, 3);
            this.UpdatePtuButton.Name = "UpdatePtuButton";
            this.UpdatePtuButton.Size = new System.Drawing.Size(89, 64);
            this.UpdatePtuButton.TabIndex = 1;
            this.UpdatePtuButton.Text = "Update PTU with Backup";
            this.UpdatePtuButton.UseVisualStyleBackColor = false;
            this.UpdatePtuButton.Click += new System.EventHandler(this.UpdatePtuButton_Click);
            // 
            // UpdateLiveButton
            // 
            this.UpdateLiveButton.BackColor = System.Drawing.Color.GreenYellow;
            this.UpdateLiveButton.Location = new System.Drawing.Point(8, 3);
            this.UpdateLiveButton.Name = "UpdateLiveButton";
            this.UpdateLiveButton.Size = new System.Drawing.Size(89, 64);
            this.UpdateLiveButton.TabIndex = 0;
            this.UpdateLiveButton.Text = "Update LIVE with Backup";
            this.UpdateLiveButton.UseVisualStyleBackColor = false;
            this.UpdateLiveButton.Click += new System.EventHandler(this.UpdateLiveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(377, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Execution";
            // 
            // OutcomeLabel
            // 
            this.OutcomeLabel.AutoSize = true;
            this.OutcomeLabel.Location = new System.Drawing.Point(301, 350);
            this.OutcomeLabel.Name = "OutcomeLabel";
            this.OutcomeLabel.Size = new System.Drawing.Size(0, 15);
            this.OutcomeLabel.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::StarCitizen_Keybinding_Updater.Properties.Resources.SC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.OutcomeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::StarCitizen_Keybinding_Updater.Properties.Resources.SCSync;
            this.Name = "Form1";
            this.Text = "Star Citizen Keybinding Updater";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button browseBackupButton;
        private Label label1;
        private Label backupLocationLabel;
        private Button clearLocationButton;
        private Panel panel1;
        private Panel panel2;
        private Label liveLocationLabel;
        private Label label4;
        private Panel panel3;
        private Label ptuLocationLabel;
        private Label label6;
        private Button browseLiveButton;
        private Button ClearLiveButton;
        private Button ClearPtuButton;
        private Button browsePtuButton;
        private Label Title;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Button UpdatePtuButton;
        private Button UpdateLiveButton;
        private Label label3;
        private Label OutcomeLabel;
    }
}