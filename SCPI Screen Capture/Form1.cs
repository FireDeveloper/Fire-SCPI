using SCPI.Scopes;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace SCPI {
    public partial class Form1:Form {

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                Properties.Settings.Default.Extension = (byte)cBox_Extension.SelectedIndex;
                Properties.Settings.Default.Color = chBox_Color.Checked;
                Properties.Settings.Default.Invert = chBox_Invert.Checked;
                Properties.Settings.Default.Path = TextBoxFilePath.Text;
                Properties.Settings.Default.Save();

                if (Global.tc.IsOpen) {
                    byte[] data = Rigol1000.getScreenCapture((byte)cBox_Extension.SelectedIndex, chBox_Color.Checked, chBox_Invert.Checked);
                    string filename = DateTime.Now.ToString(new CultureInfo("de-DE")).Replace(":", ".") + "." + Rigol1000.extensions[cBox_Extension.SelectedIndex];
                    File.WriteAllBytes(TextBoxFilePath.Text + filename, data);
                } else
                    MessageBox.Show("Telnet is closed");

            } catch (Exception ec) {
                Console.WriteLine(ec.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            try {
                Global.tc = new Telnet.TelnetCon();

                if (Properties.Settings.Default.Path == "") {
                    Properties.Settings.Default.Path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\";
                    Properties.Settings.Default.Save();
                }

                TextBoxFilePath.Text = Properties.Settings.Default.Path;

                IP1.Value = Properties.Settings.Default.IP1;
                IP2.Value = Properties.Settings.Default.IP2;
                IP3.Value = Properties.Settings.Default.IP3;
                IP4.Value = Properties.Settings.Default.IP4;

                cBox_Extension.SelectedIndex = Properties.Settings.Default.Extension;
                chBox_Color.Checked = Properties.Settings.Default.Color;
                chBox_Invert.Checked = Properties.Settings.Default.Invert;

                Global.tc.Open(Properties.Settings.Default.IP);
                this.Text = "SCPI Screen Capture - " + Global.tc.Hostname;
                btn_connect.Text = "Disconnect";
            } catch (Exception ex) {
                this.Text = "SCPI Screen Capture - Disconnected";
            }
        }

        private void btn_Click(object sender, EventArgs e) {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                Properties.Settings.Default.Path = fbd.SelectedPath + "\\";
                Properties.Settings.Default.Save();
                TextBoxFilePath.Text = Properties.Settings.Default.Path;
            }
        }

        protected override void OnLoad(EventArgs e) {
            var btn = new Button();
            btn.Size = new Size(25, TextBoxFilePath.ClientSize.Height + 2);
            btn.Location = new Point(TextBoxFilePath.ClientSize.Width - btn.Width, -1);
            btn.Cursor = Cursors.Default;
            //btn.Image = Properties.Resources.arrow_diagright;
            btn.Click += btn_Click;
            TextBoxFilePath.Controls.Add(btn);
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(TextBoxFilePath.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
            base.OnLoad(e);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("By Stefanos Tselepis\rAlpha 0.0.1");
        }

        private void btn_connect_Click(object sender, EventArgs e) {
            if (Global.tc.IsOpen) {
                Global.tc.Dispose();
                btn_connect.Text = "Connect";
                this.Text = "SCPI Screen Capture - Disconnected";
            } else {
                try {
                    string hostName = IP1.Value + "." + IP2.Value + "." + IP3.Value + "." + IP4.Value;
                    Global.tc.Open(hostName);
                    Properties.Settings.Default.IP = hostName;
                    Properties.Settings.Default.IP1 = Convert.ToByte(IP1.Value);
                    Properties.Settings.Default.IP2 = Convert.ToByte(IP2.Value);
                    Properties.Settings.Default.IP3 = Convert.ToByte(IP3.Value);
                    Properties.Settings.Default.IP4 = Convert.ToByte(IP4.Value);
                    Properties.Settings.Default.Save();
                    btn_connect.Text = "Disconnect";
                    this.Text = "SCPI Screen Capture - " + Global.tc.Hostname;
                } catch (Exception ex) {
                    MessageBox.Show("Connection Failed");
                }
            }
        }
    }
}