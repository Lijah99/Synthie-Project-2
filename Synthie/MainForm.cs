using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Mark off what items are complete (e.g. x, done, checkmark, etc), and put a P if partially complete. If 'P' include how to test what is working for partial credit below the checklist line.

//Total available points:  100

//Total available points:  100

//__x__ 55  Tutorial completed
//__x___	20	Duration Fix
//__x___	25	Attack/Release
//__100___	Total (please add the points and include the total here)


namespace Synthie
{
    public partial class MainForm : Form
    {
        SynthieView view = new SynthieView();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Helper function to handle file output and/or automatic playback when gneration is done
        /// </summary>
        private void OnPostGeneration()
        {
            if (fileOutputItem.Checked)
            {
                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    view.Save(saveFileDlg.FileName, saveFileDlg.FilterIndex);
                }
                saveFileDlg.Dispose();
            }
            if (audioOutputItem.Checked)
            {
                view.Play();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            view.OnPaint(e.Graphics);
        }
        #region Menu Handlers
        private void audioOutputItem_Click(object sender, EventArgs e)
        {

            audioOutputItem.Checked = !audioOutputItem.Checked;
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileOutputItem_Click(object sender, EventArgs e)
        {
            fileOutputItem.Checked = !fileOutputItem.Checked;
        }

        private void hz1000Item_Click(object sender, EventArgs e)
        {
            view.OnGenerate1000hztone();
            OnPostGeneration();

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.Play();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.Stop();
        }
        #endregion

        private void synthesizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noiseGateCheck.Checked)
                view.NoiseGateThreshold = (double)numericNoiseGateThreshold.Value;
            if(reverbCheck.Checked)
            {
                double factor = (double)numericReverbFactor.Value;
                double duration = (double)numericReverbDuration.Value;
                view.setReverb(factor, duration);
            }
            if(flangerCheck.Checked)
            {
                double flangerDuration = (double)numericFlangerDelay.Value;
                view.setFlanger(flangerDuration / 1000);
            }
            if(chorusCheck.Checked)
            {
                double chorusVibrato = (double)numericChorus.Value;
                view.setChorus(chorusVibrato);
            }

            view.Generate();
            OnPostGeneration();
        }

        private void openScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                view.OpenScore(openFileDlg.FileName);
            }
        }

        private void noiseGateCheck_CheckedChanged(object sender, EventArgs e)
        {
            //activated
            if (noiseGateCheck.Checked)
            {
                view.NoiseGateThreshold = (double)numericNoiseGateThreshold.Value;
                view.ApplyNoiseGate = true;
            }
            else
                view.ApplyNoiseGate = false;
        }

        private void reverbCheck_CheckedChanged(object sender, EventArgs e)
        {
            view.switchReverb();
            double factor = (double)numericReverbFactor.Value;
            double duration = (double)numericReverbDuration.Value;
            view.setReverb(factor, duration);
        }

        private void flangerCheck_CheckedChanged(object sender, EventArgs e)
        {
            view.switchFlanger();
            double flangerDuration = (double)numericFlangerDelay.Value / 1000;
            view.setFlanger(flangerDuration);
        }

        private void chorusCheck_CheckedChanged(object sender, EventArgs e)
        {
            view.switchChorus();
            double chorusVibrato = (double)numericChorus.Value;
            view.setChorus(chorusVibrato);
        }

        private void resetReverb_Click(object sender, EventArgs e)
        {
            numericReverbFactor.Value = (decimal)0.5;
            numericReverbDuration.Value = (decimal)0.2;
        }

        private void numericFlangerDelay_ValueChanged(object sender, EventArgs e)
        {
            //placeholder
        }

        private void resetFlanger_Click(object sender, EventArgs e)
        {
            numericFlangerDelay.Value = (decimal)3;
        }

        private void chorusReset_Click(object sender, EventArgs e)
        {
            numericChorus.Value = (decimal)0.05;
        }
    }
}
