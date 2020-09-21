using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linking_App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        tcpManager tcp = new tcpManager();
        private void openConnection_Click(object sender, EventArgs e)
        {

            tcp.openTCPConnection();
        }

        private void openForm_Click(object sender, EventArgs e)
        {
            tcp.sendData();
        }

        private void btnCryptoApp_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(@"D:\Projects\Electron\crypto-app\release-builds\electron-crypto-app-win32-ia32\electron-crypto-app.exe");
            p.StartInfo = psi;
            //psi.WindowStyle = ProcessWindowStyle.Minimized;
            p.Start();

        }
    }
}
