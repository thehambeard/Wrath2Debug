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
            else
            {
                DotPeekPath.Text = DotPeekPath.Text.Replace("<user>", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            }

            CheckPath(VanillaPath);
            CheckPath(DebugPath);
            CheckFile(DotPeekPath);
            CheckFile(dnSpyPath);
            CheckPath(UnityPath);
        }

        private void VanillaWrathButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(VanillaPath.Text))
                InstallDialog.SelectedPath = VanillaPath.Text;
            var result = InstallDialog.ShowDialog();
            if (InstallDialog.SelectedPath != "" && result == DialogResult.OK)
                VanillaPath.Text = InstallDialog.SelectedPath;
        }

        private void UnityPathButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(UnityPath.Text))
                InstallDialog.SelectedPath = UnityPath.Text;
            var result = InstallDialog.ShowDialog();
            if (InstallDialog.SelectedPath != "" && result == DialogResult.OK)
                UnityPath.Text = InstallDialog.SelectedPath;
        }

        private void DebugPathButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(DebugPath.Text))
                InstallDialog.SelectedPath = DebugPath.Text;
            var result = InstallDialog.ShowDialog();
            if (InstallDialog.SelectedPath != "" && result == DialogResult.OK)
                DebugPath.Text = InstallDialog.SelectedPath;
        }

        private void DotPeekPathButton_Click(object sender, EventArgs e)
        {
            var path = Path.GetDirectoryName(DotPeekPath.Text);
            if (Directory.Exists(path))
                InstallFileDialog.InitialDirectory = path;
            var result = InstallFileDialog.ShowDialog();
            if (InstallFileDialog.FileName != "" && result == DialogResult.OK) 
                DotPeekPath.Text = InstallFileDialog.FileName;
        }

        private void dnSpyPathButton_Click(object sender, EventArgs e)
        {
            var path = Path.GetDirectoryName(dnSpyPath.Text);
            if (Directory.Exists(path))
                InstallFileDialog.InitialDirectory = path;
            var result = InstallFileDialog.ShowDialog();
            if (InstallFileDialog.FileName != "" && result == DialogResult.OK)
                dnSpyPath.Text = InstallFileDialog.FileName;
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

        private void SavePathsAndState(string state)
        {
            _savedPaths.Clear();
            _savedPaths.Add(VanillaPath.Name, VanillaPath.Text);
            _savedPaths.Add(DebugPath.Name, DebugPath.Text);
            _savedPaths.Add(DotPeekPath.Name, DotPeekPath.Text);
            _savedPaths.Add(dnSpyPath.Name, dnSpyPath.Text);
            _savedPaths.Add(UnityPath.Name, UnityPath.Text);
            _savedPaths.Add("crashed", state);
            File.WriteAllText(".\\paths.json", JsonConvert.SerializeObject(_savedPaths));
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (CheckPath(VanillaPath) && CheckPath(DebugPath) && CheckFile(DotPeekPath) && CheckFile(dnSpyPath) && CheckPath(UnityPath))
            {
                StartWarning warn = new StartWarning();

                warn.ShowDialog();
                if (warn.DialogResult == DialogResult.Cancel)
                    return;

                

                if (Directory.Exists($"{DebugPath.Text}\\Mods")  && _savedPaths.ContainsKey("crashed") && _savedPaths["crashed"].Equals("false"))
                {
                    LogBox.AppendText("Backing up mod folder" + Environment.NewLine);
                    if(Directory.Exists(".\\Mods"))
                        Directory.Delete(".\\Mods", true);
                    Directory.CreateDirectory(".\\Mods");
                    CopyFilesRecursively($"{DebugPath.Text}\\Mods", $"{Application.StartupPath}\\Mods");
                }
                else if (Directory.Exists($"{DebugPath.Text}\\Mods"))
                {
                    LogBox.AppendText("Previous conversion attempt failed! Will restore mods from the previous mod cache." + Environment.NewLine);
                }

                SavePathsAndState("true");

                LogBox.AppendText("Clearing Debug copy" + Environment.NewLine);
                Directory.Delete(@"\\?\" + DebugPath.Text, true);
                Directory.CreateDirectory(DebugPath.Text);

                LogBox.AppendText("Cloning Vanilla Copy: This will take a while." + Environment.NewLine);
                CopyFilesRecursively(VanillaPath.Text, DebugPath.Text);

                if (Directory.Exists($".\\Mods"))
                {
                    LogBox.AppendText("Restoring mod folder" + Environment.NewLine);
                    if (Directory.Exists($"{DebugPath.Text}\\Mods"))
                        Directory.Delete($"{DebugPath.Text}\\Mods", true);
                    Directory.CreateDirectory($"{DebugPath.Text}\\Mods");
                    CopyFilesRecursively($"{Application.StartupPath}\\Mods", $"{DebugPath.Text}\\Mods");
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

                SavePathsAndState("false");

                LogBox.AppendText("Conversion complete!" + Environment.NewLine);
            }
        }

        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(@"\\?\" + dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        
    }
}
