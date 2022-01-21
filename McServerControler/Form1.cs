using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Components;

namespace McServerControler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string ServerPath = "C:\\Dragon Data\\Development\\Install\\Minecraft Server\\server.jar";
        private Process ServerProcess = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            var proc = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = "cmd.exe",
                    Arguments = "/c DIR",
                    //Arguments = "cd \"C:\\Dragon Data\\Development\\Install\\Minecraft Server\\\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            proc.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);

            ServerProcess = proc;

        }

        private void buttonstart_Click(object sender, EventArgs e)
        {

            ServerProcess.Start();
            ServerProcess.BeginOutputReadLine();
        }

        private void ConOut(String data)
        {
            SynchronizationContext.Current.Send(_ => {
                ConsoleOut.AppendText(data + "\n");
            }, null);
            
        }

         void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {

            //SynchronizationContext.Current.Send(_ => {
            //    ConsoleOut.AppendText(outLine.Data + "\n");
            //}, null);

            Dispatcher dispatcherUI = Dispatcher.CreateDefault();
            dispatcherUI.InvokeAsync(new Action(() => {
                ConsoleOut.AppendText(outLine.Data + "\n");
            }));
        }
    }
}