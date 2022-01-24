using System;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel;

namespace McServerControler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Process ServerProcess;

        private void Form1_Load(object sender, EventArgs e)
        {
            var proc = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = "cmd.exe",
                    //Arguments = "/c DIR",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    CreateNoWindow = true
                }
            };
            int linecount = 0;
            //proc.OutputDataReceived += OutputHandler;
            proc.OutputDataReceived += new DataReceivedEventHandler((sender, e) => {
                if (!string.IsNullOrEmpty(e.Data)) {

                    this.Invoke((MethodInvoker)delegate {
                        ConOut(e.Data);
                    });
                }
            });

            ServerProcess = proc;

        }
        private StreamWriter ServerInput;
        private void buttonstart_Click(object sender, EventArgs e)
        {

            ServerProcess.Start();
            ServerProcess.BeginOutputReadLine();

            StreamWriter streamWriter = ServerProcess.StandardInput;
            ServerInput = streamWriter;

        }
        private int linecount = 0;
        public void ConOut(String data)
        { 
            linecount++;

            ConsoleOut.AppendText("\n[" + linecount + "]: " + data);

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

            ConOut("testing...");

            ServerInput.WriteLine(ConsoleIn.Text);

            //ServerProcess.WaitForExit();

            ConsoleIn.Clear();
        }

        private void ConsoleIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) {
 //               ConOut(ConsoleIn.Text);
                ServerInput.WriteLine(ConsoleIn.Text);
                ConsoleIn.Clear();
            }
        }
    }
}