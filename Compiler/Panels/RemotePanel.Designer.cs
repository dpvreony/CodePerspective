﻿namespace XBuilder.Panels
{
    partial class RemotePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectionTimer = new System.Windows.Forms.Timer(this.components);
            this.BandwidthLabel = new System.Windows.Forms.Label();
            this.SyncSpeedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:Port";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(60, 17);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(157, 20);
            this.AddressTextBox.TabIndex = 1;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(61, 69);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(58, 104);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(274, 90);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Connect Status";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(60, 154);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(156, 23);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Open Viewer";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(61, 43);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(156, 20);
            this.KeyTextBox.TabIndex = 6;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(142, 69);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 7;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectionTimer
            // 
            this.ConnectionTimer.Enabled = true;
            this.ConnectionTimer.Interval = 500;
            this.ConnectionTimer.Tick += new System.EventHandler(this.ConnectionTimer_Tick);
            // 
            // BandwidthLabel
            // 
            this.BandwidthLabel.AutoSize = true;
            this.BandwidthLabel.Location = new System.Drawing.Point(58, 194);
            this.BandwidthLabel.Name = "BandwidthLabel";
            this.BandwidthLabel.Size = new System.Drawing.Size(57, 13);
            this.BandwidthLabel.TabIndex = 8;
            this.BandwidthLabel.Text = "Bandwidth";
            // 
            // SyncSpeedLabel
            // 
            this.SyncSpeedLabel.AutoSize = true;
            this.SyncSpeedLabel.Location = new System.Drawing.Point(58, 219);
            this.SyncSpeedLabel.Name = "SyncSpeedLabel";
            this.SyncSpeedLabel.Size = new System.Drawing.Size(94, 13);
            this.SyncSpeedLabel.TabIndex = 9;
            this.SyncSpeedLabel.Text = "Syncs per Second";
            // 
            // RemotePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SyncSpeedLabel);
            this.Controls.Add(this.BandwidthLabel);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RemotePanel";
            this.Size = new System.Drawing.Size(335, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Timer ConnectionTimer;
        private System.Windows.Forms.Label BandwidthLabel;
        private System.Windows.Forms.Label SyncSpeedLabel;
    }
}
