using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRecordingApp
{
    public partial class Form1 : Form
    {
        Recorder m_recorder = null;
        string m_strFilename = "";
        bool bstoptime = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiledialog_Click(object sender, EventArgs e)
        {
            m_strFilename = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtboxFileLocation.Text = folderBrowserDialog1.SelectedPath;
                m_strFilename = folderBrowserDialog1.SelectedPath;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Using MotionJpeg as Avi encoder,
            // output to 'out.avi' at 10 Frames per second, 70% quality
            bstoptime = false;
            m_recorder = new Recorder(new RecorderParams(m_strFilename + "Rec_" + GetTime() + ".avi", 10, SharpAvi.KnownFourCCs.Codecs.MotionJpeg, 50));
            Thread timthread = new Thread(new ThreadStart(timedisplay));
            timthread.Start();
        }
        public void timedisplay()
        {
            var sw = Stopwatch.StartNew();
            while (true)
            {
                lbltimeUpdate.Invoke(new Action(() => lbltimeUpdate.Text = sw.Elapsed.ToString("hh\\:mm\\:ss")));
                if (bstoptime)
                    break;
            }

        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            // Finish Writing
            bstoptime = true;
            m_recorder.Dispose();
        }
        public string GetTime()
        {
            string retval = DateTime.Now.ToString();
            retval = retval.Replace(" ", "_");
            retval = retval.Replace(":", "_");
            retval = retval.Replace("-", "_");
            return retval;
        }

    }
}
