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
        private float[] cachedSamples;
        public int phase;
        public int offset;
        /*private Dictionary<int, UnmanagedMemoryStream> SampleTypes = new Dictionary<int, UnmanagedMemoryStream>()
        {
            {0, Resources.LooseKick01 },
            {1, Resources.LooseKick08 },
            {2, Resources.KesKick04 },
            {3, Resources.KesKick08 },
            {4, Resources.AccousticKick },
            {5, Resources.Crash01 },
            {6, Resources.MultiCrash01 },
            {7, Resources.KHat_Open01 },
            {8, Resources.HiHat01 },
            {9, Resources.PdHat02 }
        };*/

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

        public bool GetTable(int NeededSamples)
        {
            int increment = cachedSamples.Length / NeededSamples;
            if (phase < cachedSamples.Length)
            {
                frame[0] = (double)cachedSamples[phase];
                frame[1] = frame[0];
                phase += increment;
                return true;
            }
            else return false;
        }

        public override void Start()
        {
            phase = 0;
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
