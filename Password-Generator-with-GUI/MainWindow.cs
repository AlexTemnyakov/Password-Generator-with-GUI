/*
MIT License

Copyright (c) 2019 AlexTemnyakov

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

v0.6
*/

using System;
using System.Windows.Forms;
using MongoDB.Bson;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace Password_Generator_with_GUI
{
    public partial class PasswordGenerator : Form
    {
        private Model m;

        /*
         * 
        */ 
        public PasswordGenerator()
        {
            m = new Model();

            InitializeComponent();

            countOfPasswordsUpDown.Maximum = 9999;
            countOfPasswordsUpDown.Minimum = 1;
            lengthOfPasswordUpDown.Maximum = 200;
            lengthOfPasswordUpDown.Minimum = 1;
        }

        /*
         * 
        */ 
        private void CountOfPasswordsUpDown_ValueChanged(object sender, EventArgs e)
        {
            m.setCountOfPasswords(Convert.ToInt32(countOfPasswordsUpDown.Value));
            Console.WriteLine("Count" + m.getCountOfPasswords());
        }

        /*
         * 
        */ 
        private void LengthOfPasswordUpDown_ValueChanged(object sender, EventArgs e)
        {
            m.setLengthOfPassword(Convert.ToInt32(lengthOfPasswordUpDown.Value));
            Console.WriteLine("Length" + m.getCountOfPasswords());
        }

        /*
         * 
        */ 
        private void GenBut_Click(object sender, EventArgs e)
        {
            string str = "{ 'length' : '";
            str += Convert.ToString(m.getLengthOfPassword());
            str += "', 'count' : '";
            str += Convert.ToString(m.getCountOfPasswords());
            str += "', 'only letters and digits' : '";
            str += (checkBox1.Checked) ? "true" : "false";
            str += "' }";
            Console.WriteLine(checkBox1.Checked);
            Console.WriteLine(str);
            string pyScriptPath = "res\\src\\Python\\password_generator.py";
            // convert input arguments to JSON string
            BsonDocument argsBson = BsonDocument.Parse(str);
            //bool saveInputFile = false;
            string argsFile = string.Format("{0}\\{1}.txt", Path.GetDirectoryName(pyScriptPath), Guid.NewGuid());
            // create new process start info
            ProcessStartInfo prcStartInfo = new ProcessStartInfo
            {
                //FileName = "python.exe",
                FileName = GetPythonPath(),
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = false
            };
            try
            {
                // write agruments (in JSON) for Pyhton into a temporary .txt
                using (StreamWriter sw = new StreamWriter(argsFile))
                {
                    sw.WriteLine(argsBson);
                    prcStartInfo.Arguments = string.Format("{0} {1}", string.Format(@"""{0}""", pyScriptPath), string.Format(@"""{0}""", argsFile));
                }
                // start Python script and wait untill finishes
                using (Process process = Process.Start(prcStartInfo)) { process.WaitForExit(); }
            }
            finally { File.Delete(argsFile); }
        }

        /* 
         * get python path from environtment variable
        */
        private static string GetPythonPath()
        {
            var environmentVariables = Environment.GetEnvironmentVariables();
            string pathVariable = environmentVariables["Path"] as string;
            if (pathVariable != null)
            {
                string[] allPaths = pathVariable.Split(';');
                foreach (var path in allPaths)
                {
                    string pythonPathFromEnv = path + "\\python.exe";
                    if (File.Exists(pythonPathFromEnv))
                        return pythonPathFromEnv;
                }
            }
            return "";
        }
    }
}
