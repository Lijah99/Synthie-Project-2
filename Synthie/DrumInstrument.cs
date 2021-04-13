using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synthie
{
    class DrumInstrument : Instrument
    {
        private SineWave sinewave = new SineWave();
        private double duration;
        private double time;
        private AR ar;
        private Random r = new Random();

        public double Frequency { get => sinewave.Frequency; set => sinewave.Frequency = value; }

        public DrumInstrument()
        {
            duration = 0.1;
            ar = new AR();
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


            // ADDED FOR TASK
            // Tell the AR object it gets its samples from 
            // the sine wave object.
            ar.Source = this;
            ar.SampleRate = SampleRate;
            ar.SoundDuration = duration;
            ar.Start();
        }

        public override bool Generate()
        {
            // Tell the component to generate an audio sample
            sinewave.Generate();
            //TASK
            frame = sinewave.Frame();
            ar.Generate();

            // Read the component's sample and make it our resulting frame.
            //TASK
            frame[0] = r.NextDouble();      //pull the adjusted sample
            frame[1] = r.NextDouble();    // using a random modulus for white noise

            // Update time
            time += samplePeriod;

            // We return true until the time reaches the duration.
            return time < (duration * (bpm / 60.0));
        }
    }
}
