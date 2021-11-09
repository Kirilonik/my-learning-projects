using CSCore.CoreAudioAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopDownshooter
{
    static class Program
    {
        public static readonly ObservableCollection<MMDevice> _devices = new ObservableCollection<MMDevice>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using(var mmddeviceEnumerator = new MMDeviceEnumerator())
            {
                using (var mmdeviceCollection = mmddeviceEnumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active))
                {
                    foreach(var device in mmdeviceCollection)
                    {
                        _devices.Add(device);
                    }
                }
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form0());
        }
    }
}
