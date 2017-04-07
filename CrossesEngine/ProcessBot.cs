using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossesEngine
{
    public class ProcessBot : BasicBot
    {
        Process proc;
        bool hasShutdown = false;

        public ProcessBot(string fileName, string args)
        {
            Name = fileName;

            ProcessStartInfo psi = new ProcessStartInfo(fileName, args);
            psi.UseShellExecute = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            proc = Process.Start(psi);
            proc.EnableRaisingEvents = true;
            proc.Exited += (s, e) =>
            {
                if (!hasShutdown)
                {
                    hasShutdown = true;
                    MainForm.NotifyBotLoss(this);
                }
            };

            StandardInput = proc.StandardInput;
            StandardOutput = proc.StandardOutput;
            StandardError = proc.StandardError;
        }

        public override void Shutdown()
        {
            if (!hasShutdown)
            {
                proc.CloseMainWindow();
                proc.Close();
            }
            proc = null;
        }
    }
}
