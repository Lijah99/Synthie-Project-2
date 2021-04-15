using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synthie
{
    public class SynthieView
    {
		private Sound sound;
		public int NumChannels { get; } = 2;
        public int SampleRate { get; } = 44100;

        private Synthesizer synthesizer = null;

        //effects related parameters
        private double noiseGateThreshold = 0.0;
        public Boolean ApplyNoiseGate { get; set; } = false;
        public double NoiseGateThreshold { get => noiseGateThreshold; set => noiseGateThreshold = value; }
        public SynthieView()
        {
            sound = new Sound(SampleRate, NumChannels);
            synthesizer = new Synthesizer();
            synthesizer.Channels = NumChannels;
            synthesizer.SampleRate = SampleRate;

        }

        /// <summary>
        /// Generates a 5 second 1000HZ tone.
        /// </summary>
        public void OnGenerate1000hztone()
        {
            double freq = 1000;
            double duration = 5;

            int i = 0;
            sound.Samples = new float[(int)(duration * SampleRate * sound.Format.Channels)];

            for (double time = 0.0; time < duration - 1.0 / sound.Format.SampleRate; time += 1.0 / sound.Format.SampleRate)
            {
                for (int c = 0; c < sound.Format.Channels; c++)
                {
                    sound.Samples[i + c] = (float)(Math.Sin(time * 2 * Math.PI * freq));
                }
                i += sound.Format.Channels;
            }
        }

        public void OnPaint(Graphics g)
        {
            //TODO if desired
        }

        /// <summary>
        /// Helper function to insure sound smaples are within range.
        /// </summary>
        /// <param name="frame">sound sample</param>
        /// <returns>clamped ( [-1, 1] ) sound sample</returns>
        private float[] ClampFrame(double[] frame)
        {
            float[] audio = new float[frame.Length];
            for (int i = 0; i < NumChannels; i++)
                audio[i] = (float)Math.Min(1.0, Math.Max(-1.0, frame[i]));

            return audio;
        }

        /// <summary>
        /// Generate sound samples for the given music score. 
        /// </summary>
        public void Generate()
        {
            sound.OpenSaveStream("temp.wav");
            double[] frame = new double[2];

            //reinitialize sampler
            synthesizer.Start();

            //keep asking for samples, until otherwise indicated
            while (synthesizer.Generate(frame))
            {
                //check for noise gate
                if(ApplyNoiseGate)
                {
                    if (Math.Abs(frame[0]) < noiseGateThreshold)
                        frame[0] = 0;
                    if (Math.Abs(frame[1]) < noiseGateThreshold)
                        frame[1] = 0;
                }
                sound.WriteStreamSample(ClampFrame(frame));
            }

            sound.Close();
            sound.OpenReadStream("temp.wav"); //needed for auto playback
        }

        public void OpenScore(string filename)
        {
            synthesizer.OpenScore(filename);
        }

        public void switchReverb()
        {
            if (synthesizer.Reverb == true)
                synthesizer.Reverb = false;
            else synthesizer.Reverb = true;
        }

        public void switchFlanger()
        {
            if (synthesizer.Flanger == true)
                synthesizer.Flanger = false;
            else synthesizer.Flanger = true;
        }

        public void switchChorus()
        {
            if (synthesizer.Chorus == true)
                synthesizer.Chorus = false;
            else synthesizer.Chorus = true;
        }

        public void setReverb(double factor, double duration)
        {
            synthesizer.setReverb(factor, duration);
        }

        #region Menu handling. Forwards commands to Sound

        public void Play()
        {
            sound.BasicPlay();
        }

        public void Save(string fileName, int filterIndex)
        {
            sound.SaveAs(fileName, (SoundFileTypes)(filterIndex));
        }

        public void Stop()
        {
            sound.Stop();
        }

        #endregion
    }
}
