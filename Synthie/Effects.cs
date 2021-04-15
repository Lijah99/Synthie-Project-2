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
        private float reverbDelayms = .2f;
        private double reverbFactor = 0.5;
        private int bufferNum = 0;

        private int channels;
        private int sampleRate;
        private double samplePeriod;
        private int index = 0;

        public Double ReverbFactor { get => reverbFactor; set => reverbFactor = value; }
        public float ReverbDuration { get => reverbDelayms; set => reverbDelayms = value; }

        public Effects(int sampleRate, double samplePeriod, int channels) 
        {
            this.channels = channels;
            this.sampleRate = sampleRate;
            this.samplePeriod = samplePeriod;

            soundBuffer = new List<List<double>>();
            for (int i = 0; i < channels; i++)
                soundBuffer.Add(new List<double>());
        }

        public void reset()
        {
            soundBuffer = new List<List<double>>();
            for (int i = 0; i < channels; i++)
                soundBuffer.Add(new List<double>());
            index = 0;
            time = 0;
            bufferNum = 0;
        }

        public void saveSound(double[] frame)
        {
            if(frame != null)
                for (int i = 0; i < channels; i++)
                    soundBuffer[i].Add(frame[i]);

            bufferNum++;

            time += samplePeriod;
        }
        public void Reverb(double [] frame)
        {
            if (frame == null)
            {
                MessageBox.Show("Need a sound loaded first", "Process Error");
                return;
            }

            int delaySamples = (int)((float)reverbDelayms * sampleRate);


            if(time > reverbDelayms)
            {
                for(int i = 0; i < channels; i++)
                {
                    frame[i] += soundBuffer[i][bufferNum - delaySamples] * reverbFactor;
                }
            }

        }

        public void Flanger(double[] frame)
        {
            if (frame == null)
            {
                MessageBox.Show("Need a sound loaded first", "Process Error");
                return;
            }

            //create max delay time to .003
            double maxDelayTime = 0.003;

            //create sin reference (idk what index is)
            double sinRef = Math.Sin(2 * Math.PI *index * (1.0/(double)sampleRate) );

            //grab max time delay in samp
            double maxTimeDelaySamp = Math.Round(maxDelayTime * sampleRate);

            //amplitude of noise
            double amplitude = .7;

            if (time > maxDelayTime) // 3ms delay 
            {
                double currSin = Math.Abs(sinRef);
                double currDelay = Math.Ceiling(currSin * maxTimeDelaySamp);

                for (int i = 0; i < channels; i++)
                {
                    frame[i] += soundBuffer[i][bufferNum - (int)currDelay] * amplitude;
                }
            }

            index++;
        }

        public void Chorus(double[] frame)
        {
            if (frame == null)
            {
                MessageBox.Show("Need a sound loaded first", "Process Error");
                return;
            }

            double vibrato = 0.05;
            double vibratoVal = Math.Sin((1.0 / (double)sampleRate) * vibrato * 2 * Math.PI);

            vibrato = vibrato * -1;


            if (time > 0.1)
            {
                for (int i = 0; i < channels; i++)
                {
                    frame[i] += soundBuffer[i][bufferNum - 1] * vibratoVal;
                }
            }

        }
    }
}
