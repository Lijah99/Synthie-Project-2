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
            this.reverbCheck = new System.Windows.Forms.CheckBox();
            this.flangerCheck = new System.Windows.Forms.CheckBox();
            this.chorusCheck = new System.Windows.Forms.CheckBox();
            this.numericReverbFactor = new System.Windows.Forms.NumericUpDown();
            this.reverbFactorLabel = new System.Windows.Forms.Label();
            this.numericReverbDuration = new System.Windows.Forms.NumericUpDown();
            this.reverbDurationLabel = new System.Windows.Forms.Label();
            this.resetReverb = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoiseGateThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReverbFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReverbDuration)).BeginInit();
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
            1,
            0,
            0,
            131072});
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
            // reverbCheck
            // 
            this.reverbCheck.AutoSize = true;
            this.reverbCheck.Location = new System.Drawing.Point(18, 84);
            this.reverbCheck.Name = "reverbCheck";
            this.reverbCheck.Size = new System.Drawing.Size(90, 17);
            this.reverbCheck.TabIndex = 4;
            this.reverbCheck.Text = "Apply Reverb";
            this.reverbCheck.UseVisualStyleBackColor = true;
            this.reverbCheck.CheckedChanged += new System.EventHandler(this.reverbCheck_CheckedChanged);
            // 
            // flangerCheck
            // 
            this.flangerCheck.AutoSize = true;
            this.flangerCheck.Location = new System.Drawing.Point(18, 119);
            this.flangerCheck.Name = "flangerCheck";
            this.flangerCheck.Size = new System.Drawing.Size(90, 17);
            this.flangerCheck.TabIndex = 5;
            this.flangerCheck.Text = "Apply Flanger";
            this.flangerCheck.UseVisualStyleBackColor = true;
            this.flangerCheck.CheckedChanged += new System.EventHandler(this.flangerCheck_CheckedChanged);
            // 
            // chorusCheck
            // 
            this.chorusCheck.AutoSize = true;
            this.chorusCheck.Location = new System.Drawing.Point(18, 142);
            this.chorusCheck.Name = "chorusCheck";
            this.chorusCheck.Size = new System.Drawing.Size(88, 17);
            this.chorusCheck.TabIndex = 6;
            this.chorusCheck.Text = "Apply Chorus";
            this.chorusCheck.UseVisualStyleBackColor = true;
            this.chorusCheck.CheckedChanged += new System.EventHandler(this.chorusCheck_CheckedChanged);
            // 
            // numericReverbFactor
            // 
            this.numericReverbFactor.DecimalPlaces = 2;
            this.numericReverbFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericReverbFactor.Location = new System.Drawing.Point(114, 81);
            this.numericReverbFactor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericReverbFactor.Name = "numericReverbFactor";
            this.numericReverbFactor.Size = new System.Drawing.Size(41, 20);
            this.numericReverbFactor.TabIndex = 7;
            this.numericReverbFactor.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // reverbFactorLabel
            // 
            this.reverbFactorLabel.AutoSize = true;
            this.reverbFactorLabel.Location = new System.Drawing.Point(161, 84);
            this.reverbFactorLabel.Name = "reverbFactorLabel";
            this.reverbFactorLabel.Size = new System.Drawing.Size(99, 13);
            this.reverbFactorLabel.TabIndex = 8;
            this.reverbFactorLabel.Text = "Reverb Factor (0-1)";
            // 
            // numericReverbDuration
            // 
            this.numericReverbDuration.DecimalPlaces = 2;
            this.numericReverbDuration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericReverbDuration.Location = new System.Drawing.Point(266, 81);
            this.numericReverbDuration.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericReverbDuration.Name = "numericReverbDuration";
            this.numericReverbDuration.Size = new System.Drawing.Size(41, 20);
            this.numericReverbDuration.TabIndex = 9;
            this.numericReverbDuration.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // reverbDurationLabel
            // 
            this.reverbDurationLabel.AutoSize = true;
            this.reverbDurationLabel.Location = new System.Drawing.Point(313, 84);
            this.reverbDurationLabel.Name = "reverbDurationLabel";
            this.reverbDurationLabel.Size = new System.Drawing.Size(129, 13);
            this.reverbDurationLabel.TabIndex = 10;
            this.reverbDurationLabel.Text = "Reverb Duration (0-2 sec)";
            // 
            // resetReverb
            // 
            this.resetReverb.Location = new System.Drawing.Point(448, 79);
            this.resetReverb.Name = "resetReverb";
            this.resetReverb.Size = new System.Drawing.Size(75, 23);
            this.resetReverb.TabIndex = 11;
            this.resetReverb.Text = "Reset";
            this.resetReverb.UseVisualStyleBackColor = true;
            this.resetReverb.Click += new System.EventHandler(this.resetReverb_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetReverb);
            this.Controls.Add(this.reverbDurationLabel);
            this.Controls.Add(this.numericReverbDuration);
            this.Controls.Add(this.reverbFactorLabel);
            this.Controls.Add(this.numericReverbFactor);
            this.Controls.Add(this.chorusCheck);
            this.Controls.Add(this.flangerCheck);
            this.Controls.Add(this.reverbCheck);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericReverbFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReverbDuration)).EndInit();
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
        private System.Windows.Forms.CheckBox reverbCheck;
        private System.Windows.Forms.CheckBox flangerCheck;
        private System.Windows.Forms.CheckBox chorusCheck;
        private System.Windows.Forms.NumericUpDown numericReverbFactor;
        private System.Windows.Forms.Label reverbFactorLabel;
        private System.Windows.Forms.NumericUpDown numericReverbDuration;
        private System.Windows.Forms.Label reverbDurationLabel;
        private System.Windows.Forms.Button resetReverb;
    }
}

