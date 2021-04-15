using System;
using NAudio.Wave;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Synthie
{
    class DrumInstrument : Instrument
    {
        Dictionary<string, UnmanagedMemoryStream> samples = new Dictionary<string, UnmanagedMemoryStream>() {
            {"BassDrum", Properties.Resources.Bass_Drum_2 },        // works well in 2rd octave
            {"SnareDrum", Properties.Resources.Ensoniq_ESQ_1_Snare },   // works well in 4th octave
            {"Tom1", Properties.Resources.Electronic_Tom_4 },       // works well in 3
            {"Tom2", Properties.Resources.Electro_Tom },            // works well in 4
            {"Cymbals", Properties.Resources.Crash_Cymbal_3 },      // words well in 5
            {"HipHop", Properties.Resources.Hip_Hop_Snare_1 }       // works well in 5
        };
        private RandArray rands;
        private DrumWaveTable wavetable;
        private SineWave sinewave = new SineWave();
        private double duration;
        private double time;
        private bool isSample = false;
        private AR ar;

        public double Frequency { get => sinewave.Frequency; set => sinewave.Frequency = value; }

        public DrumInstrument(string drumType)
        {
            if (samples.ContainsKey(drumType) == true)
            {
                isSample = true;
                wavetable = new DrumWaveTable(samples[drumType]);
            }
            duration = 0.1;
            ar = new AR();
            ar.Attack = 0.08;
            ar.Release = 0.08;
            
            //wave = WaveFormat.CreateIeeeFloatWaveFormat(SampleRate, 1);
        }

        public override void SetNote(Note note)
        {
            duration = note.Count;
            Frequency = Notes.NoteToFrequency(note.Pitch);
        }

        public override void Start()
        {
            if (isSample == true)
            {
                wavetable.SampleRate = SampleRate;
                wavetable.FilterFreq = Frequency;
                wavetable.Start();
            }
            else
            {
                rands = new RandArray(duration, sampleRate, (int)BPM, Frequency);
                rands.Start();
            }    
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
            //sinewave.Generate();
            //TASK
            if (isSample == true)
            {
                wavetable.GetTable();
                frame = wavetable.Frame();
            }
            else
            {
                rands.Generate();
                frame = rands.Frame();
            }
            ar.Generate();

            // Read the component's sample and make it our resulting frame.
            //TASK
            frame[0] = ar.Frame(0);      //pull the adjusted sample
            frame[1] = ar.Frame(1);

            // Update time
            time += samplePeriod;

            // We return true until the time reaches the duration.
            return time < (duration * (BPM / 60.0));
        }
    }
}
