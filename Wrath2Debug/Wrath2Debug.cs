using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Wrath2Debug
{
    public partial class Wrath2Debug : Form
    {
        private Dictionary<string, string> _savedPaths = new Dictionary<string, string>();
        public Wrath2Debug()
        {
            InitializeComponent();
        }

        private void Wrath2Debug_Load(object sender, EventArgs e)
        {
            if (File.Exists(".\\paths.json"))
            {
                _savedPaths = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(".\\paths.json"));

                VanillaPath.Text = _savedPaths[VanillaPath.Name];
                DebugPath.Text = _savedPaths[DebugPath.Name];
                DotPeekPath.Text = _savedPaths[DotPeekPath.Name];
                dnSpyPath.Text = _savedPaths[dnSpyPath.Name];
                UnityPath.Text = _savedPaths[UnityPath.Name];
            }

            CheckPath(VanillaPath);
            CheckPath(DebugPath);
            CheckFile(DotPeekPath);
            CheckFile(dnSpyPath);
            CheckPath(UnityPath);
        }

        private void VanillaWrathButton_Click(object sender, EventArgs e)
        {
            InstallDialog.ShowDialog();
            if (InstallDialog.SelectedPath != "") VanillaPath.Text = InstallDialog.SelectedPath;
        }

        private void DebugPathButton_Click(object sender, EventArgs e)
        {
            InstallDialog.ShowDialog();
            if (InstallDialog.SelectedPath != "") DebugPath.Text = InstallDialog.SelectedPath;
        }

        private void DotPeekPathButton_Click(object sender, EventArgs e)
        {
            InstallFileDialog.ShowDialog();
            if (InstallFileDialog.FileName != "") DotPeekPath.Text = InstallFileDialog.FileName;
        }

        private void dnSpyPathButton_Click(object sender, EventArgs e)
        {
            InstallFileDialog.ShowDialog();
            if (InstallFileDialog.FileName != "") dnSpyPath.Text = InstallFileDialog.FileName;
        }

        private bool CheckFile(TextBox textBox)
        {
            if (!File.Exists(textBox.Text))
            {
                textBox.ForeColor = Color.Red;
                return false;
            }
            else
            {
                textBox.ForeColor = Color.Black;
                return true;
            }
        }
        private bool CheckPath(TextBox textBox)
        {
            if (!Directory.Exists(textBox.Text))
            {
                textBox.ForeColor = Color.Red;
                return false;
            }
            else
            {
                textBox.ForeColor = Color.Black;
                return true;
            }
        }

        private void VanillaPath_TextChanged(object sender, EventArgs e)
        {
            CheckPath(VanillaPath);
        }

        private void DebugPath_TextChanged(object sender, EventArgs e)
        {
            CheckPath(DebugPath);
        }

        private void DotPeekPath_TextChanged(object sender, EventArgs e)
        {
            CheckFile(DotPeekPath);
        }

        private void dnSpyPath_TextChanged(object sender, EventArgs e)
        {
            CheckFile(dnSpyPath);
        }

        private void UnityPath_TextChanged(object sender, EventArgs e)
        {
            CheckPath(UnityPath);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (CheckPath(VanillaPath) && CheckPath(DebugPath) && CheckFile(DotPeekPath) && CheckFile(dnSpyPath) && CheckPath(UnityPath))
            {
                StartWarning warn = new StartWarning();

                warn.ShowDialog();
                if (warn.DialogResult == DialogResult.Cancel)
                    return;

                _savedPaths.Clear();
                _savedPaths.Add(VanillaPath.Name, VanillaPath.Text);
                _savedPaths.Add(DebugPath.Name, DebugPath.Text);
                _savedPaths.Add(DotPeekPath.Name, DotPeekPath.Text);
                _savedPaths.Add(dnSpyPath.Name, dnSpyPath.Text);
                _savedPaths.Add(UnityPath.Name, UnityPath.Text);
                File.WriteAllText(".\\paths.json", JsonConvert.SerializeObject(_savedPaths));

                if (Directory.Exists($"{DebugPath.Text}\\Mods"))
                {
                    LogBox.AppendText("Backing up mod folder" + Environment.NewLine);
                    CopyFilesRecursively($"{DebugPath.Text}\\Mods", ".\\Mods");
                }

                LogBox.AppendText("Clearing Debug copy" + Environment.NewLine);
                Directory.Delete(DebugPath.Text, true);
                Directory.CreateDirectory(DebugPath.Text);

                LogBox.AppendText("Cloning Vanilla Copy: This will take a while." + Environment.NewLine);
                CopyFilesRecursively(VanillaPath.Text, DebugPath.Text);

                if (Directory.Exists($".\\Mods"))
                {
                    LogBox.AppendText("Restoring mod folder" + Environment.NewLine);
                    CopyFilesRecursively(".\\Mods", $"{DebugPath.Text}\\Mods");
                }

                LogBox.AppendText("Copying Mono Resources to Debug" + Environment.NewLine);

                File.Copy($"{UnityPath.Text}\\Editor\\Data\\PlaybackEngines\\windowsstandalonesupport\\Variations\\win64_development_mono\\WindowsPlayer.exe", $"{DebugPath.Text}\\Wrath.exe", true);
                File.Copy($"{UnityPath.Text}\\Editor\\Data\\PlaybackEngines\\windowsstandalonesupport\\Variations\\win64_development_mono\\WinPixEventRuntime.dll", $"{DebugPath.Text}\\WinPixEventRuntime.dll", true);
                File.Copy($"{UnityPath.Text}\\Editor\\Data\\PlaybackEngines\\windowsstandalonesupport\\Variations\\win64_development_mono\\UnityPlayer.dll", $"{DebugPath.Text}\\UnityPlayer.dll", true);

                CopyFilesRecursively($"{ UnityPath.Text}\\Editor\\Data\\PlaybackEngines\\windowsstandalonesupport\\Variations\\win64_development_mono\\Data\\Managed", $"{ DebugPath.Text}\\Wrath_Data\\Managed");

                Process cmd;
                string command;
                LogBox.AppendText("Patching Assembly with de4dot" + Environment.NewLine);
                command = $"--dont-rename --keep-types --preserve-tokens --preserve-strings -fpdb \"{DebugPath.Text}\\Wrath_Data\\Managed\\Assembly-CSharp.dll\" -o .\\Assembly-CSharp.dll";
                ProcessStartInfo de4dot = new ProcessStartInfo(".\\de4dot\\de4dot.exe");
                de4dot.Arguments = command;
                cmd = Process.Start(de4dot);
                cmd.WaitForExit();

                if (cmd.ExitCode != 0)
                {
                    LogBox.AppendText("de4dot patching failed, aborting..." + Environment.NewLine);
                    return;
                }
                if (File.Exists($"{DebugPath.Text}\\Wrath_Data\\Managed\\Assembly-CSharp.dll"))
                    File.Delete($"{DebugPath.Text}\\Wrath_Data\\Managed\\Assembly-CSharp.dll");
                File.Move(".\\Assembly-CSharp.dll", $"{DebugPath.Text}\\Wrath_Data\\Managed\\Assembly-CSharp.dll");

                LogBox.AppendText("Launching DotPeek: Follow Dotpeek step in the instructions." + Environment.NewLine);
                ProcessStartInfo dotPeek = new ProcessStartInfo($"{DotPeekPath.Text}");
                cmd = Process.Start(dotPeek);
                cmd.WaitForExit();

                if (cmd.ExitCode != 0)
                {
                    LogBox.AppendText("dotPeek failed, aborting..." + Environment.NewLine);
                    return;
                }
                File.Copy($"{DebugPath.Text}\\Wrath_Data\\Managed\\Assembly-CSharp\\Assembly-CSharp.pdb", $"{DebugPath.Text}\\Wrath_Data\\Managed\\Assembly-CSharp.pdb");

                LogBox.AppendText("Converting PDB to MDB" + Environment.NewLine);
                command = $".\\pdb2mdb\\pdb2mdb.exe \"{DebugPath.Text}\\Wrath_Data\\Managed\\Assembly-CSharp.dll\"";
                ProcessStartInfo pd2mdb = new ProcessStartInfo($"\"{UnityPath.Text}\\Editor\\Data\\MonoBleedingEdge\\bin\\mono.exe\"");
                pd2mdb.Arguments = command;
                cmd = Process.Start(pd2mdb);
                cmd.WaitForExit();

                if (cmd.ExitCode != 0)
                {
                    LogBox.AppendText("PDB2MDB failed, aborting..." + Environment.NewLine);
                    return;
                }

                File.Copy(".\\steam_appid.txt", $"{DebugPath.Text}\\steam_appid.txt", true);
                File.Copy(".\\boot.config", $"{DebugPath.Text}\\Wrath_Data\\boot.config", true);

                LogBox.AppendText("Launching dnSpy: follow dnSpy step in instructions" + Environment.NewLine);
                ProcessStartInfo dnspy = new ProcessStartInfo($"\"{dnSpyPath.Text}\"");
                cmd = Process.Start(dnspy);
                cmd.WaitForExit();

                LogBox.AppendText("Conversion complete!" + Environment.NewLine);
            }
        }

        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }


    }
}
