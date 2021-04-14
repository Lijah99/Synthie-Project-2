using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthie
{
    class Effects
    {
        double time = 0;
        List<List<double>> soundBuffer;
        private int reverbDelayms = 500;
        private double reverbFactor = 0.5;
        private int bufferNum = 0;

        private int channels;
        private int sampleRate;
        private double samplePeriod;

        public Effects(int sampleRate, double samplePeriod, int channels) 
        {
            this.channels = channels;
            this.sampleRate = sampleRate;
            this.samplePeriod = samplePeriod;

            soundBuffer = new List<List<double>>();
            for (int i = 0; i < channels; i++)
                soundBuffer.Add(new List<double>());
        }

        public void saveSound(double[] frame)
        {
            if(frame != null)
                for (int i = 0; i < channels; i++)
                    soundBuffer[i].Add(frame[i]);

            bufferNum++;

            time += samplePeriod;
        }
        public void Reverb(double [] frame, int channels)
        {
            if (frame == null)
            {
                MessageBox.Show("Need a sound loaded first", "Process Error");
                return;
            }

            int delaySamples = sampleRate/2;


            if(time > 0.5)
            {
                for(int i = 0; i < channels; i++)
                {
                    frame[i] += soundBuffer[i][bufferNum - delaySamples] * reverbFactor;
                }
            }

        }

    }
}
