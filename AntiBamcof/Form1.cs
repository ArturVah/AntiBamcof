using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AntiBamcof
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             KillBamcof();
        }

        private void KillBamcof()
        {
            while (true)
            {

                try
                {
                    Process[] proc = Process.GetProcessesByName("utorrent");
                    proc[0].Kill();
                    MessageBox.Show("Bamcof was killed boss...","Your slave");
                }
                catch (Exception ex)
                {
                    Thread.Sleep(10000000);
                }

//                foreach (var process in Process.GetProcesses())
//                {
//                    try
//                    {
//                        MessageBox.Show(process.ProcessName);
//                        if (process.ProcessName == "Bamcof")
//                        {
//                            process.Kill();
//                            MessageBox.Show("Bamcof was killed successfully");
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show(ex.Message);
//                    }
//                }
            }

        }
    }
}
