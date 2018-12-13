namespace WindowsFormsSample1
{
    partial class MainForm
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
            this.m_panelMenuButtons = new System.Windows.Forms.Panel();
            this.m_buttonFile = new System.Windows.Forms.Button();
            this.m_buttonOpen = new System.Windows.Forms.Button();
            this.m_buttonUndo = new System.Windows.Forms.Button();
            this.m_buttonRedo = new System.Windows.Forms.Button();
            this.m_buttonSave = new System.Windows.Forms.Button();
            this.m_buttonMessage = new System.Windows.Forms.Button();
            this.m_panelBottom = new System.Windows.Forms.Panel();
            this.m_buttonSettings = new System.Windows.Forms.Button();
            this.m_panelMenuButtons.SuspendLayout();
            this.m_panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_panelMenuButtons
            // 
            this.m_panelMenuButtons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.m_panelMenuButtons.Controls.Add(this.m_buttonMessage);
            this.m_panelMenuButtons.Controls.Add(this.m_buttonSave);
            this.m_panelMenuButtons.Controls.Add(this.m_buttonRedo);
            this.m_panelMenuButtons.Controls.Add(this.m_buttonUndo);
            this.m_panelMenuButtons.Controls.Add(this.m_buttonOpen);
            this.m_panelMenuButtons.Controls.Add(this.m_buttonFile);
            this.m_panelMenuButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_panelMenuButtons.Location = new System.Drawing.Point(0, 0);
            this.m_panelMenuButtons.Name = "m_panelMenuButtons";
            this.m_panelMenuButtons.Size = new System.Drawing.Size(1574, 100);
            this.m_panelMenuButtons.TabIndex = 0;
            // 
            // m_buttonFile
            // 
            this.m_buttonFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_buttonFile.Location = new System.Drawing.Point(0, 0);
            this.m_buttonFile.Name = "m_buttonFile";
            this.m_buttonFile.Size = new System.Drawing.Size(126, 100);
            this.m_buttonFile.TabIndex = 0;
            this.m_buttonFile.Text = "File";
            this.m_buttonFile.UseVisualStyleBackColor = true;
            // 
            // m_buttonOpen
            // 
            this.m_buttonOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_buttonOpen.Location = new System.Drawing.Point(126, 0);
            this.m_buttonOpen.Name = "m_buttonOpen";
            this.m_buttonOpen.Size = new System.Drawing.Size(126, 100);
            this.m_buttonOpen.TabIndex = 1;
            this.m_buttonOpen.Text = "Open";
            this.m_buttonOpen.UseVisualStyleBackColor = true;
            // 
            // m_buttonUndo
            // 
            this.m_buttonUndo.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_buttonUndo.Location = new System.Drawing.Point(252, 0);
            this.m_buttonUndo.Name = "m_buttonUndo";
            this.m_buttonUndo.Size = new System.Drawing.Size(126, 100);
            this.m_buttonUndo.TabIndex = 2;
            this.m_buttonUndo.Text = "Undo";
            this.m_buttonUndo.UseVisualStyleBackColor = true;
            // 
            // m_buttonRedo
            // 
            this.m_buttonRedo.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_buttonRedo.Location = new System.Drawing.Point(378, 0);
            this.m_buttonRedo.Name = "m_buttonRedo";
            this.m_buttonRedo.Size = new System.Drawing.Size(126, 100);
            this.m_buttonRedo.TabIndex = 3;
            this.m_buttonRedo.Text = "Redo";
            this.m_buttonRedo.UseVisualStyleBackColor = true;
            // 
            // m_buttonSave
            // 
            this.m_buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_buttonSave.Location = new System.Drawing.Point(504, 0);
            this.m_buttonSave.Name = "m_buttonSave";
            this.m_buttonSave.Size = new System.Drawing.Size(126, 100);
            this.m_buttonSave.TabIndex = 4;
            this.m_buttonSave.Text = "Save";
            this.m_buttonSave.UseVisualStyleBackColor = true;
            // 
            // m_buttonMessage
            // 
            this.m_buttonMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_buttonMessage.Location = new System.Drawing.Point(630, 0);
            this.m_buttonMessage.Name = "m_buttonMessage";
            this.m_buttonMessage.Size = new System.Drawing.Size(126, 100);
            this.m_buttonMessage.TabIndex = 5;
            this.m_buttonMessage.Text = "Message";
            this.m_buttonMessage.UseVisualStyleBackColor = true;
            // 
            // m_panelBottom
            // 
            this.m_panelBottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_panelBottom.Controls.Add(this.m_buttonSettings);
            this.m_panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_panelBottom.Location = new System.Drawing.Point(0, 665);
            this.m_panelBottom.Name = "m_panelBottom";
            this.m_panelBottom.Size = new System.Drawing.Size(1574, 64);
            this.m_panelBottom.TabIndex = 1;
            // 
            // m_buttonSettings
            // 
            this.m_buttonSettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_buttonSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.m_buttonSettings.Location = new System.Drawing.Point(1385, 0);
            this.m_buttonSettings.Name = "m_buttonSettings";
            this.m_buttonSettings.Size = new System.Drawing.Size(189, 64);
            this.m_buttonSettings.TabIndex = 0;
            this.m_buttonSettings.Text = "Settings";
            this.m_buttonSettings.UseVisualStyleBackColor = false;
            this.m_buttonSettings.Click += new System.EventHandler(this.OnButtonSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 729);
            this.Controls.Add(this.m_panelBottom);
            this.Controls.Add(this.m_panelMenuButtons);
            this.Name = "MainForm";
            this.Text = "Sample Application";
            this.m_panelMenuButtons.ResumeLayout(false);
            this.m_panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_panelMenuButtons;
        private System.Windows.Forms.Button m_buttonOpen;
        private System.Windows.Forms.Button m_buttonFile;
        private System.Windows.Forms.Button m_buttonUndo;
        private System.Windows.Forms.Button m_buttonSave;
        private System.Windows.Forms.Button m_buttonRedo;
        private System.Windows.Forms.Button m_buttonMessage;
        private System.Windows.Forms.Panel m_panelBottom;
        private System.Windows.Forms.Button m_buttonSettings;
    }
}

