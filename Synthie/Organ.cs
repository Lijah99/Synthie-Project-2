using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synthie
{
    public class Organ : Instrument
    {
        private SineWave sinewave = new SineWave();
        private double duration;
        private double time;
        private AR ar;

        public Organ()
        {
            duration = 0.1;
            ar = new AR();
        }

        public double Frequency { get => sinewave.Frequency; set => sinewave.Frequency = value; }
        public override bool Generate()
        {
            // Tell the component to generate an audio sample
            sinewave.Generate();
            //TASK
            frame = sinewave.Frame();
            // add the drawbar harmonics to the frames
            DrawBars();
            Vibrato();
            LeslieTremelo();
            ar.Generate();

            // Read the component's sample and make it our resulting frame.
            //TASK
            frame[0] = ar.Frame(0);      //pull the adjusted samples
            frame[1] = ar.Frame(1);

            // Update time
            time += samplePeriod;

            // We return true until the time reaches the duration.
            return time < (duration * (bpm / 60.0));
        }

        public override void SetNote(Note note)
        {
            duration = note.Count;
            Frequency = Notes.NoteToFrequency(note.Pitch);
        }

        public override void Start()
        {
            sinewave.SampleRate = SampleRate;
            sinewave.Start();
            time = 0;

            // Tell the AR object it gets its samples from 
            // the sine wave object.
            ar.Source = this;
            ar.SampleRate = SampleRate;
            ar.SoundDuration = duration;
            ar.Start(); ;
        }

        private void DrawBars()
        {
            int[] draw = { 8, 8, 5, 0, 2, 0, 0, 0, 0 };
            int[] freqMul = { 1, 3, 2, 4, 6, 8, 10, 12, 16 };
            double[] harmonics = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 9; i++)
            { 
                harmonics[i] = sinewave.Amp * Math.Sin(sinewave.Phase * freqMul[i] * 2 * Math.PI) * (Math.Pow(10, ((draw[i] - 8) * 3) / 20));
                frame[0] += harmonics[i];
            }

            frame[1] = frame[0];
        }

        // Function to add vibrato to a given frame
        private void Vibrato()
        {
            double vibrato = 0.01;
            frame[0] += sinewave.Amp * Math.Sin(sinewave.Phase * vibrato * 2 * Math.PI);
            frame[1] = frame[0];

            vibrato = vibrato * -1;
        }

        // function to simulate a single speed leslie speaker by adding tremelo
        private void LeslieTremelo()
        {
            float tremelo = (float)(1 + .12 * Math.Sin(4 * 2 * Math.PI * time));
            frame[0] = frame[0] * tremelo;
            frame[1] = frame[1] * tremelo;
        }
    }
}
