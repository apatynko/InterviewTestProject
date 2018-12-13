namespace WindowsFormsSample1
{
    partial class SettingsForm
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
            this.m_checkedListBoxMenuButtons = new System.Windows.Forms.CheckedListBox();
            this.m_buttonMoveUp = new System.Windows.Forms.Button();
            this.m_buttonMoveDown = new System.Windows.Forms.Button();
            this.m_buttonOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_buttonCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_checkedListBoxMenuButtons
            // 
            this.m_checkedListBoxMenuButtons.FormattingEnabled = true;
            this.m_checkedListBoxMenuButtons.Location = new System.Drawing.Point(10, 10);
            this.m_checkedListBoxMenuButtons.Name = "m_checkedListBoxMenuButtons";
            this.m_checkedListBoxMenuButtons.Size = new System.Drawing.Size(309, 602);
            this.m_checkedListBoxMenuButtons.TabIndex = 0;
            // 
            // m_buttonMoveUp
            // 
            this.m_buttonMoveUp.Location = new System.Drawing.Point(330, 204);
            this.m_buttonMoveUp.Name = "m_buttonMoveUp";
            this.m_buttonMoveUp.Size = new System.Drawing.Size(144, 60);
            this.m_buttonMoveUp.TabIndex = 1;
            this.m_buttonMoveUp.Text = "Up";
            this.m_buttonMoveUp.UseVisualStyleBackColor = true;
            // 
            // m_buttonMoveDown
            // 
            this.m_buttonMoveDown.Location = new System.Drawing.Point(330, 284);
            this.m_buttonMoveDown.Name = "m_buttonMoveDown";
            this.m_buttonMoveDown.Size = new System.Drawing.Size(144, 60);
            this.m_buttonMoveDown.TabIndex = 2;
            this.m_buttonMoveDown.Text = "Down";
            this.m_buttonMoveDown.UseVisualStyleBackColor = true;
            // 
            // m_buttonOK
            // 
            this.m_buttonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_buttonOK.Location = new System.Drawing.Point(357, 0);
            this.m_buttonOK.Name = "m_buttonOK";
            this.m_buttonOK.Size = new System.Drawing.Size(144, 60);
            this.m_buttonOK.TabIndex = 3;
            this.m_buttonOK.Text = "OK";
            this.m_buttonOK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_buttonCancel);
            this.panel1.Controls.Add(this.m_buttonOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 711);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 60);
            this.panel1.TabIndex = 4;
            // 
            // m_buttonCancel
            // 
            this.m_buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_buttonCancel.Location = new System.Drawing.Point(213, 0);
            this.m_buttonCancel.Name = "m_buttonCancel";
            this.m_buttonCancel.Size = new System.Drawing.Size(144, 60);
            this.m_buttonCancel.TabIndex = 4;
            this.m_buttonCancel.Text = "Cancel";
            this.m_buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 771);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_buttonMoveDown);
            this.Controls.Add(this.m_buttonMoveUp);
            this.Controls.Add(this.m_checkedListBoxMenuButtons);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox m_checkedListBoxMenuButtons;
        private System.Windows.Forms.Button m_buttonMoveUp;
        private System.Windows.Forms.Button m_buttonMoveDown;
        private System.Windows.Forms.Button m_buttonOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button m_buttonCancel;
    }
}