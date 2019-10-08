using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.DirectX.DirectSound;
using System.IO;
namespace UP1
{
    public partial class Form1 : Form
    {

        [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        private static extern bool PlaySound(string szSound, IntPtr hMod, PlaySoundFlags flags);


        [Flags]
        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void PlaySound_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog1 = new OpenFileDialog();

            dialog1.Title = "Browse to find sound file to play";
            dialog1.InitialDirectory = @"c:\";
            dialog1.Filter = "Wav Files (*.wav)|*.wav";
            dialog1.FilterIndex = 2;
            dialog1.RestoreDirectory = true;

            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                PlaySound(dialog1.FileName, new System.IntPtr(), PlaySoundFlags.SND_SYNC);
            }
        }

        private void DirectSound_Button_Click(object sender, EventArgs e)
        {
            var device = new Device();
            device.SetCooperativeLevel(this, CooperativeLevel.Priority);
            SecondaryBuffer wavSound = new SecondaryBuffer(@"C:\Users\oszust\source\repos\UP1\UP1\example.wav", device);
            wavSound.Play(0, BufferPlayFlags.Default);
        }

        private void Readbytes_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog1 = new OpenFileDialog();

            dialog1.Title = "Browse to find sound file to play";
            dialog1.InitialDirectory = @"c:\";
            dialog1.Filter = "Wav Files (*.wav)|*.wav";
            dialog1.FilterIndex = 2;
            dialog1.RestoreDirectory = true;

            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] wavFile = File.ReadAllBytes(dialog1.FileName);
                byte[] wavHeader = new byte[44];
                
                for (int i = 0; i < 44; i++)
                {
                    wavHeader[i] = wavFile[i];
                }
                // Czytać bajty po jednym, nie tak jak poniżej

                byte[] riffDescriptionByteArray = new byte[4] { wavHeader[0], wavHeader[1], wavHeader[2], wavHeader[3] };
                byte[] sizeOfFileByteArray = new byte[4] { wavHeader[4], wavHeader[5], wavHeader[6], wavHeader[7] };
                byte[] wavDescriptionByteArray = new byte[4] { wavHeader[8], wavHeader[9], wavHeader[10], wavHeader[11] };
                byte[] fmtDescriptionByteArray = new byte[4] { wavHeader[12], wavHeader[13], wavHeader[14], wavHeader[15] };

                //string riffDescription = Encoding.ASCII.GetString(riffDescriptionByteArray);
                //string sizeOfFile = Encoding.ASCII.GetString(sizeOfFileByteArray);
                //string wavDescription = Encoding.ASCII.GetString(wavDescriptionByteArray);
                //string fmtDescription = Encoding.ASCII.GetString(fmtDescriptionByteArray);

                //wavHeader_textBox.Text = riffDescription + " " + sizeOfFile + " " + wavDescription + " " + fmtDescription;
            }
        }
    }
}
