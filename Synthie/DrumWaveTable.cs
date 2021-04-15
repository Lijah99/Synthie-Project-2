using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Synthie.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthie
{
    class DrumWaveTable : AudioNode
    {
        private WaveFormat format = null;
        private BandPass filter = null;
        private float[] cachedSamples;
        public int phase;
        private double filterFreq;
        
        public double FilterFreq { set => filterFreq = value; }

        public float[] Samples { get => cachedSamples; set => cachedSamples = value; }

        public DrumWaveTable(UnmanagedMemoryStream resourceStream) 
        {
            OpenSample(resourceStream);
        }

        public override bool Generate()
        {
            if (phase < cachedSamples.Length)
            {
                frame[0] = (double)cachedSamples[phase];
                frame[1] = frame[0];
                phase++;
                return true;
            }
            else return false;
        }

        public bool GetTable()
        {
            //int increment = cachedSamples.Length / NeededSamples;
            if (phase < cachedSamples.Length)
            {
                frame[0] = (double)cachedSamples[phase];
                frame[1] = frame[0];
                phase++;
                return true;
            }
            else return false;
        }

        public override void Start()
        {
            phase = 0;
            filter = new BandPass(filterFreq, SampleRate, cachedSamples);
            cachedSamples = filter.BPF();
        }

        private float[] separateCache()
        {
            int j = 0;
            float[] newCache = new float[cachedSamples.Length / 2];
            for (int i = 0; i < cachedSamples.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newCache[j] = cachedSamples[i];
                    j++;
                }
            }
            return newCache;
        }

        private float[] BPF(double SetFrequency)
        {
            float[] Output = cachedSamples;
            float Fc = (float)SetFrequency / sampleRate;
            float Q = 50;
            float norm;
            float K = (float)Math.Tan(Math.PI * Fc);

            norm = 1 / (1 + K / Q + K * K);
            float a0 = 1 * norm;
            float a1 = -2 * a0;
            float a2 = a0;
            float b1 = 2 * (K * K - 1) * norm;
            float b2 = (1 - K / Q + K * K) * norm;
            float z1 = 0;
            float z2 = z1;

            for (int idx = 0; idx < cachedSamples.Length; idx++)
            {
                float input = cachedSamples[idx];
                float output = input * a0 + z1;
                z1 = input * a1 + z2 - b1 * output;
                z2 = input * a2 - b2 * output;
                cachedSamples[idx] = output;
            }
            return cachedSamples;
        }
        
        private bool OpenSample(UnmanagedMemoryStream resourceStream)
        {
            //helper function for fast opening
            try
            {
                //open file
                WaveFileReader reader = new WaveFileReader(resourceStream);
                ISampleProvider provider = new Pcm16BitToSampleProvider(reader);
                //save format
                format = provider.WaveFormat;

                //convert from raw bytes to floats
                float[] temp = new float[reader.Length];
                provider.Read(temp, 0, (int)reader.Length);
                cachedSamples = temp;
                cachedSamples = separateCache();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Loading Error");
                return false;
            }
            return true;
        }

        private float[] ByteToFloat(byte[] input)
        {
            var floatArray2 = new float[input.Length / 4];
            Buffer.BlockCopy(input, 0, floatArray2, 0, input.Length);
            return floatArray2;
        }
    }
}
