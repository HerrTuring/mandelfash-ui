using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace MandelfashCalculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        System.Timers.Timer timer;
        Process proc = null;

        public Form()
        {
            InitializeComponent();
        }

        private void updateImageDuringThread(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (!File.Exists("mandelfash.bmp"))
                return;

            Image img;
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes("mandelfash.bmp")))
            img = Image.FromStream(ms);

            this.mandelfash.Image = img;

            if (proc != null && proc.HasExited)
                timer.Enabled = false;
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            proc = new Process();

            proc.StartInfo.FileName = "MandelfashGenerator.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.RedirectStandardInput = false;

            Thread thread = new Thread(() => proc.Start());

            thread.Start();

            timer = new System.Timers.Timer(100);
            timer.Elapsed += updateImageDuringThread;
            timer.Enabled = true;
        }

        private void mandefash_MouseClick(object sender, MouseEventArgs e)
        {
            decimal xStart, xLong, xStep, yStart, yLong, yStep;

            xStart = -2m;
            xLong = 2.5m;
            xStep = xLong / 1023;

            yStart = 1.221896383186706m;
            yLong = (xLong * 1000) / 1023;
            yStep = (yLong / 1000) * (-1);

            // X and Y points in the image are swaped on the math because for the mandelbrot/mandelfash's purpose x is the collumn and y is the line.
            xText.Text = (xStart + (1022 - e.Y) * xStep).ToString();
            yText.Text = (yStart + e.X * yStep).ToString();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (proc != null)
                if (!proc.HasExited)
                {
                    proc.Close();

                    foreach (Process proc in Process.GetProcessesByName("MandelfashGenerator"))
                    {
                        proc.Kill();
                    }
                }
        }
    }
}
