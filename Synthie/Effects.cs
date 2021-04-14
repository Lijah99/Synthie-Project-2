using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthie
{
    class Effects
    {
        static public void Tremolo(Sound sound)
        {
            if (sound == null)
            {
                MessageBox.Show("Need a sound loaded first", "Process Error");
                return;
            }

            //setup progress bar
            ProgressBar progress = new ProgressBar();
            progress.Runworker();

            float time = 0;
            int channels = sound.Format.Channels;
            //tremolo factor
            float trem;

            for (int i = 0; i < sound.Samples.Length; i += channels, time += 1.0f / sound.Format.SampleRate)
            {
                trem = (float)(1 + .20 * Math.Sin(6 * Math.PI * time));

                for (int c = 0; c < channels; c++)
                {
                    sound.Samples[i + c] = sound.Samples[i + c] * trem;
                }
                progress.UpdateProgress((double)i / sound.Samples.Length);
            }

        }

        static public void Echo(Sound sound, float factor = 0.5f)
        {
            if (sound == null)
            {
                MessageBox.Show("Need a sound loaded first", "Process Error");
                return;
            }

            //setup progress bar
            ProgressBar progress = new ProgressBar();
            progress.Runworker();

            float time = 0;
            int channels = sound.Format.Channels;

            for (int i = 0; i < sound.Samples.Length; i += channels, time += 1.0f / sound.Format.SampleRate)
            {
                for (int c = 0; c < channels; c++)
                {
                    sound.Samples[i + c] = sound.Samples[i + c] + factor * sound.Samples[i + c];
                }
                progress.UpdateProgress((double)i / sound.Samples.Length);
            }
        }

        static public void NoiseGate(Sound sound, float factor = 0.5f)
        {
            if (sound == null)
            {
                MessageBox.Show("Need a sound loaded first", "Process Error");
                return;
            }

            //setup progress bar
            ProgressBar progress = new ProgressBar();
            progress.Runworker();

            float time = 0;
            int channels = sound.Format.Channels;

            for (int i = 0; i < sound.Samples.Length; i += channels, time += 1.0f / sound.Format.SampleRate)
            {
                for (int c = 0; c < channels; c++)
                {
                    sound.Samples[i + c] = sound.Samples[i + c] + factor * sound.Samples[i + c];
                }
                progress.UpdateProgress((double)i / sound.Samples.Length);
            }

        }

    }
}
