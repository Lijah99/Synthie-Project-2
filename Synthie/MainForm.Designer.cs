namespace Synthie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOutputItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioOutputItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hz1000Item = new System.Windows.Forms.ToolStripMenuItem();
            this.synthesizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.noiseGateCheck = new System.Windows.Forms.CheckBox();
            this.effectsLabel = new System.Windows.Forms.Label();
            this.numericNoiseGateThreshold = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoiseGateThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.generateToolStripMenuItem,
            this.playbackToolStripMenuItem,
            this.openScoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(93, 22);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOutputItem,
            this.audioOutputItem,
            this.toolStripSeparator1,
            this.hz1000Item,
            this.synthesizerToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // fileOutputItem
            // 
            this.fileOutputItem.Name = "fileOutputItem";
            this.fileOutputItem.Size = new System.Drawing.Size(180, 22);
            this.fileOutputItem.Text = "File Output";
            this.fileOutputItem.Click += new System.EventHandler(this.fileOutputItem_Click);
            // 
            // audioOutputItem
            // 
            this.audioOutputItem.Checked = true;
            this.audioOutputItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.audioOutputItem.Name = "audioOutputItem";
            this.audioOutputItem.Size = new System.Drawing.Size(180, 22);
            this.audioOutputItem.Text = "Audio Output";
            this.audioOutputItem.Click += new System.EventHandler(this.audioOutputItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // hz1000Item
            // 
            this.hz1000Item.Name = "hz1000Item";
            this.hz1000Item.Size = new System.Drawing.Size(180, 22);
            this.hz1000Item.Text = "1000Hz Tone";
            this.hz1000Item.Click += new System.EventHandler(this.hz1000Item_Click);
            // 
            // synthesizerToolStripMenuItem
            // 
            this.synthesizerToolStripMenuItem.Name = "synthesizerToolStripMenuItem";
            this.synthesizerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.synthesizerToolStripMenuItem.Text = "Synthesizer";
            this.synthesizerToolStripMenuItem.Click += new System.EventHandler(this.synthesizerToolStripMenuItem_Click);
            // 
            // playbackToolStripMenuItem
            // 
            this.playbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.playbackToolStripMenuItem.Text = "Playback";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // openScoreToolStripMenuItem
            // 
            this.openScoreToolStripMenuItem.Name = "openScoreToolStripMenuItem";
            this.openScoreToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.openScoreToolStripMenuItem.Text = "Open Score";
            this.openScoreToolStripMenuItem.Click += new System.EventHandler(this.openScoreToolStripMenuItem_Click);
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Filter = "Wave Files (*.wav)|*.wav| MP3 (*.mp3)|*.mp3";
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "Score files (*.score)|*.score|All Files (*.*)|*.*";
            // 
            // noiseGateCheck
            // 
            this.noiseGateCheck.AutoSize = true;
            this.noiseGateCheck.Location = new System.Drawing.Point(18, 58);
            this.noiseGateCheck.Name = "noiseGateCheck";
            this.noiseGateCheck.Size = new System.Drawing.Size(176, 17);
            this.noiseGateCheck.TabIndex = 1;
            this.noiseGateCheck.Text = "Noise Gate: Minimum Threshold";
            this.noiseGateCheck.UseVisualStyleBackColor = true;
            this.noiseGateCheck.CheckedChanged += new System.EventHandler(this.noiseGateCheck_CheckedChanged);
            // 
            // effectsLabel
            // 
            this.effectsLabel.AutoSize = true;
            this.effectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.effectsLabel.Location = new System.Drawing.Point(12, 24);
            this.effectsLabel.Name = "effectsLabel";
            this.effectsLabel.Size = new System.Drawing.Size(99, 31);
            this.effectsLabel.TabIndex = 2;
            this.effectsLabel.Text = "Effects";
            // 
            // numericNoiseGateThreshold
            // 
            this.numericNoiseGateThreshold.DecimalPlaces = 2;
            this.numericNoiseGateThreshold.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericNoiseGateThreshold.Location = new System.Drawing.Point(200, 55);
            this.numericNoiseGateThreshold.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNoiseGateThreshold.Name = "numericNoiseGateThreshold";
            this.numericNoiseGateThreshold.Size = new System.Drawing.Size(120, 20);
            this.numericNoiseGateThreshold.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericNoiseGateThreshold);
            this.Controls.Add(this.effectsLabel);
            this.Controls.Add(this.noiseGateCheck);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Synthie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoiseGateThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileOutputItem;
        private System.Windows.Forms.ToolStripMenuItem audioOutputItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem hz1000Item;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.ToolStripMenuItem synthesizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScoreToolStripMenuItem;
        private System.Windows.Forms.CheckBox noiseGateCheck;
        private System.Windows.Forms.Label effectsLabel;
        private System.Windows.Forms.NumericUpDown numericNoiseGateThreshold;
    }
}

