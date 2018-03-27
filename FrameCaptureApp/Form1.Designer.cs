using System;
using System.Windows.Forms;
using Ozeki.Media;

namespace FrameCaptureApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button connectBt;
        private Button disconnectBt;
        private TextBox secondText;
        private Label label1;
        private GroupBox groupBox1;
        private VideoViewerWF liveViewer;
        private VideoViewerWF liveViewer2;
        private VideoViewerWF liveViewer3;
        private Button startBt;
        private Button stopBt;

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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectBt = new System.Windows.Forms.Button();
            this.disconnectBt = new System.Windows.Forms.Button();
            this.secondText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.liveViewer = new Ozeki.Media.VideoViewerWF();
            this.liveViewer2 = new Ozeki.Media.VideoViewerWF();
            this.liveViewer3 = new Ozeki.Media.VideoViewerWF();
            this.startBt = new System.Windows.Forms.Button();
            this.stopBt = new System.Windows.Forms.Button();
            this.liveViewer4 = new Ozeki.Media.VideoViewerWF();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectBt
            // 
            this.connectBt.Location = new System.Drawing.Point(16, 11);
            this.connectBt.Margin = new System.Windows.Forms.Padding(4);
            this.connectBt.Name = "connectBt";
            this.connectBt.Size = new System.Drawing.Size(175, 28);
            this.connectBt.TabIndex = 0;
            this.connectBt.Text = "Connect to web camera";
            this.connectBt.UseVisualStyleBackColor = true;
            this.connectBt.Click += new System.EventHandler(this.connectBt_Click);
            // 
            // disconnectBt
            // 
            this.disconnectBt.Enabled = false;
            this.disconnectBt.Location = new System.Drawing.Point(931, 11);
            this.disconnectBt.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectBt.Name = "disconnectBt";
            this.disconnectBt.Size = new System.Drawing.Size(225, 28);
            this.disconnectBt.TabIndex = 2;
            this.disconnectBt.Text = "Disconnect from web camera";
            this.disconnectBt.UseVisualStyleBackColor = true;
            this.disconnectBt.Click += new System.EventHandler(this.disconnectBt_Click);
            // 
            // secondText
            // 
            this.secondText.Location = new System.Drawing.Point(440, 14);
            this.secondText.Margin = new System.Windows.Forms.Padding(4);
            this.secondText.Name = "secondText";
            this.secondText.Size = new System.Drawing.Size(140, 22);
            this.secondText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seconds between frames";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.liveViewer);
            this.groupBox1.Controls.Add(this.liveViewer2);
            this.groupBox1.Location = new System.Drawing.Point(16, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(564, 964);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live";
            // 
            // liveViewer
            // 
            this.liveViewer.BackColor = System.Drawing.Color.Black;
            this.liveViewer.ContextMenuEnabled = true;
            this.liveViewer.FlipMode = Ozeki.Media.FlipMode.None;
            this.liveViewer.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.liveViewer.FullScreenEnabled = true;
            this.liveViewer.Location = new System.Drawing.Point(6, 531);
            this.liveViewer.Margin = new System.Windows.Forms.Padding(4);
            this.liveViewer.Name = "liveViewer";
            this.liveViewer.RotateAngle = 0;
            this.liveViewer.Size = new System.Drawing.Size(492, 427);
            this.liveViewer.TabIndex = 0;
            this.liveViewer.Text = "liveViewer";
            // 
            // liveViewer2
            // 
            this.liveViewer2.BackColor = System.Drawing.Color.Black;
            this.liveViewer2.ContextMenuEnabled = true;
            this.liveViewer2.FlipMode = Ozeki.Media.FlipMode.None;
            this.liveViewer2.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.liveViewer2.FullScreenEnabled = true;
            this.liveViewer2.Location = new System.Drawing.Point(6, 19);
            this.liveViewer2.Name = "liveViewer2";
            this.liveViewer2.RotateAngle = 0;
            this.liveViewer2.Size = new System.Drawing.Size(492, 479);
            this.liveViewer2.TabIndex = 0;
            this.liveViewer2.Text = "liveViewer2";
            // 
            // liveViewer3
            // 
            this.liveViewer3.BackColor = System.Drawing.Color.Black;
            this.liveViewer3.ContextMenuEnabled = true;
            this.liveViewer3.FlipMode = Ozeki.Media.FlipMode.None;
            this.liveViewer3.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.liveViewer3.FullScreenEnabled = true;
            this.liveViewer3.Location = new System.Drawing.Point(7, 19);
            this.liveViewer3.Name = "liveViewer3";
            this.liveViewer3.RotateAngle = 0;
            this.liveViewer3.Size = new System.Drawing.Size(490, 479);
            this.liveViewer3.TabIndex = 0;
            this.liveViewer3.Text = "liveViewer3";
            // 
            // startBt
            // 
            this.startBt.Enabled = false;
            this.startBt.Location = new System.Drawing.Point(589, 11);
            this.startBt.Margin = new System.Windows.Forms.Padding(4);
            this.startBt.Name = "startBt";
            this.startBt.Size = new System.Drawing.Size(100, 28);
            this.startBt.TabIndex = 8;
            this.startBt.Text = "Start";
            this.startBt.UseVisualStyleBackColor = true;
            this.startBt.Click += new System.EventHandler(this.startBt_Click);
            // 
            // stopBt
            // 
            this.stopBt.Enabled = false;
            this.stopBt.Location = new System.Drawing.Point(697, 11);
            this.stopBt.Margin = new System.Windows.Forms.Padding(4);
            this.stopBt.Name = "stopBt";
            this.stopBt.Size = new System.Drawing.Size(100, 28);
            this.stopBt.TabIndex = 9;
            this.stopBt.Text = "Stop";
            this.stopBt.UseVisualStyleBackColor = true;
            this.stopBt.Click += new System.EventHandler(this.stopBt_Click);
            // 
            // liveViewer4
            // 
            this.liveViewer4.BackColor = System.Drawing.Color.Black;
            this.liveViewer4.ContextMenuEnabled = true;
            this.liveViewer4.FlipMode = Ozeki.Media.FlipMode.None;
            this.liveViewer4.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.liveViewer4.FullScreenEnabled = true;
            this.liveViewer4.Location = new System.Drawing.Point(8, 531);
            this.liveViewer4.Margin = new System.Windows.Forms.Padding(4);
            this.liveViewer4.Name = "liveViewer4";
            this.liveViewer4.RotateAngle = 0;
            this.liveViewer4.Size = new System.Drawing.Size(489, 425);
            this.liveViewer4.TabIndex = 0;
            this.liveViewer4.Text = "liveViewer4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.liveViewer4);
            this.groupBox2.Controls.Add(this.liveViewer3);
            this.groupBox2.Location = new System.Drawing.Point(589, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(565, 964);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frame capture";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1163, 1038);
            this.Controls.Add(this.stopBt);
            this.Controls.Add(this.startBt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondText);
            this.Controls.Add(this.disconnectBt);
            this.Controls.Add(this.connectBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frame capture";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private VideoViewerWF liveViewer4;
        private GroupBox groupBox2;
    }
}

