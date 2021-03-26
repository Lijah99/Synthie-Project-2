using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synthie
{
    public class AR
    {
        private double attackSpeed; // how fast compression will occur
        private double releaseSpeed; // how fast compresssion release will occur
        private double time;
        private double soundDuration;
        private int sampleRate;
        private AudioNode source = null;

        public double Attack { get => attackSpeed; set => attackSpeed = value; }
        public double Release { get => releaseSpeed; set => releaseSpeed = value; }
        public int SampleRate { get => sampleRate; set => sampleRate = value; }
        public double SoundDuration { get => soundDuration; set => soundDuration = value; }
        public AudioNode Source { get => source; set => source = value; }

        public AR()
        {
            attackSpeed = 0.05; //default to strategy set to 0.05
            releaseSpeed = 0.05;
            time = 0;
        }
        public void Generate()
        {
            double gain = 1;
            if (time < attackSpeed) //beginning for attack
                gain = time / attackSpeed;
            else if (time > (soundDuration - releaseSpeed)) // end for release
                gain = (soundDuration - time) / releaseSpeed;

            // Update time
            time += source.SamplePeriod;

            //apply gain to frame
            var frame = source.Frame();
            frame[0] = gain * frame[0];
            frame[1] = gain * frame[1];

            source.FrameSet = frame;
        }

        public void Start()
        {
            time = 0;
        }

        public double Frame(int num)
        {
            if (num == 0)
                return source.Frame(0);
            else
                return source.Frame(1);
        }

    }
}
