using System;
using NAudio.Wave;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synthie
{
    class DrumInstrument : Instrument
    {
        private DrumWaveTable wavetable = new DrumWaveTable(Properties.Resources.Bass_Drum_2);
        private SineWave sinewave = new SineWave();
        private double duration;
        private double time;
        private AR ar;
        private Random r = new Random();
        private WaveFormat wave = null;

        public double Frequency { get => sinewave.Frequency; set => sinewave.Frequency = value; }

        public DrumInstrument()
        {
            duration = 0.1;
            ar = new AR();
            wave = WaveFormat.CreateIeeeFloatWaveFormat(SampleRate, 1);
        }

        public override void SetNote(Note note)
        {
            duration = note.Count;
            Frequency = Notes.NoteToFrequency(note.Pitch);
        }

        public override void Start()
        {

            wavetable.SampleRate = SampleRate;
            time = 0;
            wavetable.Start();

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
            //sinewave.Generate();
            //TASK
            wavetable.GetTable((int)(duration * bpm * sampleRate / 60.0));
            frame = wavetable.Frame();
            ar.Generate();

            // Read the component's sample and make it our resulting frame.
            //TASK
            frame[0] = ar.Frame(0);      //pull the adjusted sample
            frame[1] = ar.Frame(1);

            // Update time
            time += samplePeriod;

            // We return true until the time reaches the duration.
            return time < (duration * (bpm / 60.0));
        }
    }
}
