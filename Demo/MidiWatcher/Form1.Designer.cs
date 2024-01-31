namespace MidiWatcher
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
            if(disposing && (components != null))
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
            this.channelListBox = new System.Windows.Forms.ListBox();
            this.channelMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.sysExGroupBox = new System.Windows.Forms.GroupBox();
            this.sysExRichTextBox = new System.Windows.Forms.RichTextBox();
            this.systemCommonGroupBox = new System.Windows.Forms.GroupBox();
            this.sysCommonListBox = new System.Windows.Forms.ListBox();
            this.sysRealtimeGroupBox = new System.Windows.Forms.GroupBox();
            this.sysRealtimeListBox = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Load = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.channelMessageGroupBox.SuspendLayout();
            this.sysExGroupBox.SuspendLayout();
            this.systemCommonGroupBox.SuspendLayout();
            this.sysRealtimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.SuspendLayout();
            // 
            // channelListBox
            // 
            this.channelListBox.FormattingEnabled = true;
            this.channelListBox.ItemHeight = 16;
            this.channelListBox.Location = new System.Drawing.Point(8, 23);
            this.channelListBox.Margin = new System.Windows.Forms.Padding(4);
            this.channelListBox.Name = "channelListBox";
            this.channelListBox.Size = new System.Drawing.Size(343, 180);
            this.channelListBox.TabIndex = 0;
            // 
            // channelMessageGroupBox
            // 
            this.channelMessageGroupBox.Controls.Add(this.channelListBox);
            this.channelMessageGroupBox.Location = new System.Drawing.Point(16, 15);
            this.channelMessageGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.channelMessageGroupBox.Name = "channelMessageGroupBox";
            this.channelMessageGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.channelMessageGroupBox.Size = new System.Drawing.Size(360, 217);
            this.channelMessageGroupBox.TabIndex = 1;
            this.channelMessageGroupBox.TabStop = false;
            this.channelMessageGroupBox.Text = "Channel Messages";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(765, 318);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(765, 354);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 28);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // sysExGroupBox
            // 
            this.sysExGroupBox.Controls.Add(this.sysExRichTextBox);
            this.sysExGroupBox.Location = new System.Drawing.Point(384, 15);
            this.sysExGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.sysExGroupBox.Name = "sysExGroupBox";
            this.sysExGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.sysExGroupBox.Size = new System.Drawing.Size(489, 217);
            this.sysExGroupBox.TabIndex = 4;
            this.sysExGroupBox.TabStop = false;
            this.sysExGroupBox.Text = "SysEx Messages";
            // 
            // sysExRichTextBox
            // 
            this.sysExRichTextBox.Location = new System.Drawing.Point(8, 23);
            this.sysExRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sysExRichTextBox.Name = "sysExRichTextBox";
            this.sysExRichTextBox.Size = new System.Drawing.Size(472, 180);
            this.sysExRichTextBox.TabIndex = 7;
            this.sysExRichTextBox.Text = "";
            // 
            // systemCommonGroupBox
            // 
            this.systemCommonGroupBox.Controls.Add(this.sysCommonListBox);
            this.systemCommonGroupBox.Location = new System.Drawing.Point(16, 239);
            this.systemCommonGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.systemCommonGroupBox.Name = "systemCommonGroupBox";
            this.systemCommonGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.systemCommonGroupBox.Size = new System.Drawing.Size(360, 217);
            this.systemCommonGroupBox.TabIndex = 5;
            this.systemCommonGroupBox.TabStop = false;
            this.systemCommonGroupBox.Text = "System Common Messages";
            // 
            // sysCommonListBox
            // 
            this.sysCommonListBox.FormattingEnabled = true;
            this.sysCommonListBox.ItemHeight = 16;
            this.sysCommonListBox.Location = new System.Drawing.Point(8, 23);
            this.sysCommonListBox.Margin = new System.Windows.Forms.Padding(4);
            this.sysCommonListBox.Name = "sysCommonListBox";
            this.sysCommonListBox.Size = new System.Drawing.Size(343, 180);
            this.sysCommonListBox.TabIndex = 0;
            // 
            // sysRealtimeGroupBox
            // 
            this.sysRealtimeGroupBox.Controls.Add(this.sysRealtimeListBox);
            this.sysRealtimeGroupBox.Location = new System.Drawing.Point(392, 239);
            this.sysRealtimeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.sysRealtimeGroupBox.Name = "sysRealtimeGroupBox";
            this.sysRealtimeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.sysRealtimeGroupBox.Size = new System.Drawing.Size(357, 217);
            this.sysRealtimeGroupBox.TabIndex = 6;
            this.sysRealtimeGroupBox.TabStop = false;
            this.sysRealtimeGroupBox.Text = "System Realtime Messages";
            // 
            // sysRealtimeListBox
            // 
            this.sysRealtimeListBox.FormattingEnabled = true;
            this.sysRealtimeListBox.ItemHeight = 16;
            this.sysRealtimeListBox.Location = new System.Drawing.Point(8, 23);
            this.sysRealtimeListBox.Margin = new System.Windows.Forms.Padding(4);
            this.sysRealtimeListBox.Name = "sysRealtimeListBox";
            this.sysRealtimeListBox.Size = new System.Drawing.Size(343, 180);
            this.sysRealtimeListBox.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(765, 390);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Input Thread";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(765, 418);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 20);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Event Context";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(764, 282);
            this.Load.Margin = new System.Windows.Forms.Padding(4);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(100, 28);
            this.Load.TabIndex = 9;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.loadButton1_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(765, 253);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(99, 22);
            this.Port.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Midi In Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sysRealtimeGroupBox);
            this.Controls.Add(this.systemCommonGroupBox);
            this.Controls.Add(this.sysExGroupBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.channelMessageGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Midi Watcher";
            this.channelMessageGroupBox.ResumeLayout(false);
            this.sysExGroupBox.ResumeLayout(false);
            this.systemCommonGroupBox.ResumeLayout(false);
            this.sysRealtimeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox channelListBox;
        private System.Windows.Forms.GroupBox channelMessageGroupBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.GroupBox sysExGroupBox;
        private System.Windows.Forms.GroupBox systemCommonGroupBox;
        private System.Windows.Forms.ListBox sysCommonListBox;
        private System.Windows.Forms.GroupBox sysRealtimeGroupBox;
        private System.Windows.Forms.ListBox sysRealtimeListBox;
        private System.Windows.Forms.RichTextBox sysExRichTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.NumericUpDown Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

