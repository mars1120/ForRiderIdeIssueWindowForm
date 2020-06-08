using System;
using System.Windows.Forms;

namespace WindowsFormsAppForIde
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HalNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ForceEjectBtn = new System.Windows.Forms.Button();
            this.SlotIdxNum = new System.Windows.Forms.NumericUpDown();
            this.SlotPanel = new System.Windows.Forms.Panel();
            this.EngineerModeCheckBox = new System.Windows.Forms.CheckBox();
            this.FwCmdBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SlotIdxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // HalNotifyIcon
            // 
            this.HalNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("HalNotifyIcon.Icon")));
            this.HalNotifyIcon.Text = "HalNotifyIcon";
            this.HalNotifyIcon.Visible = true;
            this.HalNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnNotifyIconDoubleClick);
            // 
            // ForceEjectBtn
            // 
            this.ForceEjectBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ForceEjectBtn.Location = new System.Drawing.Point(12, 35);
            this.ForceEjectBtn.Name = "ForceEjectBtn";
            this.ForceEjectBtn.Size = new System.Drawing.Size(159, 38);
            this.ForceEjectBtn.TabIndex = 0;
            this.ForceEjectBtn.Text = "Eject Battery in Slot";
            this.ForceEjectBtn.UseVisualStyleBackColor = false;
            this.ForceEjectBtn.Click += new System.EventHandler(this.ForceEjectBtn_Click);
            // 
            // SlotIdxNum
            // 
            this.SlotIdxNum.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SlotIdxNum.Location = new System.Drawing.Point(177, 35);
            this.SlotIdxNum.Name = "SlotIdxNum";
            this.SlotIdxNum.Size = new System.Drawing.Size(61, 36);
            this.SlotIdxNum.TabIndex = 1;
            // 
            // SlotPanel
            // 
            this.SlotPanel.Location = new System.Drawing.Point(13, 180);
            this.SlotPanel.Name = "SlotPanel";
            this.SlotPanel.Size = new System.Drawing.Size(1503, 590);
            this.SlotPanel.TabIndex = 2;
            // 
            // EngineerModeCheckBox
            // 
            this.EngineerModeCheckBox.AutoSize = true;
            this.EngineerModeCheckBox.Checked = true;
            this.EngineerModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EngineerModeCheckBox.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EngineerModeCheckBox.Location = new System.Drawing.Point(13, 80);
            this.EngineerModeCheckBox.Name = "EngineerModeCheckBox";
            this.EngineerModeCheckBox.Size = new System.Drawing.Size(264, 28);
            this.EngineerModeCheckBox.TabIndex = 3;
            this.EngineerModeCheckBox.Text = "Enable Engineering Mode";
            this.EngineerModeCheckBox.UseVisualStyleBackColor = true;
            this.EngineerModeCheckBox.CheckedChanged += new System.EventHandler(this.EngineerModeCheckBox_CheckedChanged);
            // 
            // FwCmdBtn
            // 
            this.FwCmdBtn.BackColor = System.Drawing.SystemColors.Control;
            this.FwCmdBtn.Location = new System.Drawing.Point(244, 33);
            this.FwCmdBtn.Name = "FwCmdBtn";
            this.FwCmdBtn.Size = new System.Drawing.Size(159, 38);
            this.FwCmdBtn.TabIndex = 4;
            this.FwCmdBtn.Text = "Open Fw Commands";
            this.FwCmdBtn.UseVisualStyleBackColor = false;
            this.FwCmdBtn.Click += new System.EventHandler(this.FwCmdBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(409, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Shutdown Ups";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DbgView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1521, 807);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FwCmdBtn);
            this.Controls.Add(this.EngineerModeCheckBox);
            this.Controls.Add(this.SlotPanel);
            this.Controls.Add(this.SlotIdxNum);
            this.Controls.Add(this.ForceEjectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DbgView";
            this.Text = "VmaClient.HwAccessLayer";

            ((System.ComponentModel.ISupportInitialize)(this.SlotIdxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FwCmdBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EngineerModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ForceEjectBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnNotifyIconDoubleClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.NotifyIcon HalNotifyIcon;
        private System.Windows.Forms.Button ForceEjectBtn;
        private System.Windows.Forms.NumericUpDown SlotIdxNum;
        private System.Windows.Forms.Panel SlotPanel;
        private System.Windows.Forms.CheckBox EngineerModeCheckBox;
        private System.Windows.Forms.Button FwCmdBtn;
        private System.Windows.Forms.Button button1;
    }
}

