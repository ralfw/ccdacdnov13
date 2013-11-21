using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace servicewrappers
{
    public class ConsoleService
    {
        private readonly ProcessStartInfo _pinfo;

        public ConsoleService(string componentFilename, string commandlineParams)
        {
            _pinfo = new ProcessStartInfo(componentFilename, commandlineParams) {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
        }


        public string Process(string input)
        {
            var p = new Process { StartInfo = _pinfo };
            p.Start();

            p.StandardInput.Write(input);
            p.StandardInput.Close();

            var output = new List<string>();
            p.OutputDataReceived += (sender, e) => output.Add(e.Data);
            p.BeginOutputReadLine();
            
            p.WaitForExit();

            return string.Join("\n", output);
        } 
    }
}