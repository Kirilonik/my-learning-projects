using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;
using CSCore.Codecs;
using System.IO;

namespace TopDownshooter
{
    public class SoundPlayer: Component
    {
        private ISoundOut _soundOut;
        private IWaveSource _waveSource;

        public event EventHandler<PlaybackStoppedEventArgs> PlaybackStopped;

        public PlaybackState PlaybackState
        {
            get
            {
                if (_soundOut != null)
                    return _soundOut.PlaybackState;
                return PlaybackState.Stopped;
            }
        }

        public TimeSpan Position
        {
            get
            {
                if (_waveSource != null)
                    return _waveSource.GetPosition();
                return TimeSpan.Zero;
            }
            set
            {
                if (_waveSource != null)
                    _waveSource.SetPosition(value);
            }
        }

        public TimeSpan Length
        {
            get
            {
                if (_waveSource != null)
                    return _waveSource.GetLength();
                return TimeSpan.Zero;
            }
        }

        public int Volume
        {
            get
            {
                if (_soundOut != null)
                    return Math.Min(100, Math.Max((int)(_soundOut.Volume * 100), 0));
                return 100;
            }
            set
            {
                if (_soundOut != null)
                {
                    _soundOut.Volume = Math.Min(1.0f, Math.Max(value / 100f, 0f));
                }
            }
        }

        public void Open(string filename, MMDevice device)
        {
            CleanupPlayback();

            _waveSource =
                CodecFactory.Instance.GetCodec(filename)
                    .ToSampleSource()
                    .ToMono()
                    .ToWaveSource();
            _soundOut = new WasapiOut() { Latency = 100, Device = device };
            _soundOut.Initialize(_waveSource);
            if (PlaybackStopped != null) _soundOut.Stopped += PlaybackStopped;
        }

        public void Play()
        {
            if (_soundOut != null)
                _soundOut.Play();
        }

        public void Pause()
        {
            if (_soundOut != null)
                _soundOut.Pause();
        }

        public void Stop()
        {
            if (_soundOut != null)
                _soundOut.Stop();
        }

        private void CleanupPlayback()
        {
            if (_soundOut != null)
            {
                _soundOut.Dispose();
                _soundOut = null;
            }
            if (_waveSource != null)
            {
                _waveSource.Dispose();
                _waveSource = null;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            CleanupPlayback();
        }
    }

    public class SoundContainer
    {
        Dictionary<string, SoundPlayer> sounds = new Dictionary<string, SoundPlayer>() { };
        public SoundContainer(string parentName)
        {
            DirectoryInfo info = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\sounds\\" + parentName);
            foreach(var file in info.GetFiles())
            {
                sounds.Add(Path.GetFileNameWithoutExtension(file.FullName), new SoundPlayer());
                sounds[Path.GetFileNameWithoutExtension(file.FullName)].Open(file.FullName, Program._devices[0]);
            }
        }
        public List<string> Sounds
        {
            get
            {
                return sounds.Keys.ToList<string>();
            }
        }
        public void PlaySound(string sound)
        {
            sounds[sound].Play();
        }
    }
}
