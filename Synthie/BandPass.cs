using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synthie
{
    class BandPass
    {
        double Pitch = 262;
        float Q = 50;
        int SampleRate = 44100;
        float[] cachedSamples;

        public BandPass(double pitch, int sampleRate, float[] samples)
        {
            Pitch = pitch;
            SampleRate = 44100;
            cachedSamples = samples;
        }

        public float[] BPF()
        {
            float[] Output = cachedSamples;
            float Fc = (float)Pitch / SampleRate;
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
    }

    class RandArray : AudioNode
    {
        BandPass filter;
        int time;
        double Pitch;
        float[] samples;

        float[] Samples { get => samples; }
        public RandArray(double count, int sampleRate, int bpm, double pitch)
        {
            this.Pitch = pitch;
            var rand = new Random();
            int size = (int)(count * sampleRate * bpm / 60);
            samples = new float[size*2];
            for (int i = 0; i < samples.Length; i++)
            {
                samples[i] = (float)rand.NextDouble() * 2;
            }
        }

        public override bool Generate()
        {
            frame[0] = samples[time];
            frame[1] = frame[0];
            time++;
            return true;
        }

        public override void Start()
        {
            filter = new BandPass(Pitch, SampleRate, Samples);
            samples = filter.BPF();
            time = 0;
        }
    }
}
