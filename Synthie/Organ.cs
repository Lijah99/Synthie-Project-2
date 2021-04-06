﻿using System;
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
            DrawBars();
            ar.Generate();

            // Read the component's sample and make it our resulting frame.
            //TASK
            frame[0] = ar.Frame(0);      //pull the adjusted samples and add the drawbar harmonics
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


            // ADDED FOR TASK
            // Tell the AR object it gets its samples from 
            // the sine wave object.
            ar.Source = this;
            ar.SampleRate = SampleRate;
            ar.SoundDuration = duration;
            ar.Start(); ;
        }

        private void DrawBars()
        {
            double harm20 = sinewave.Amp * Math.Sin(sinewave.Phase * 2 * 2 * Math.PI) * .354;
            double harm60 = sinewave.Amp * Math.Sin(sinewave.Phase * 6 * 2 * Math.PI) * .126;

            double[] drawbars = new double[2];
            drawbars[0] = harm20 + harm60;
            drawbars[1] = harm20 + harm60;

            frame[0] += harm20 + harm60;
            frame[1] = frame[0];

            //return drawbars;
        }
    }
}
