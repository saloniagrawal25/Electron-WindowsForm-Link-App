using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tcpServer;
using System.Net.Sockets;
using System.Windows.Forms;
namespace Linking_App
{
    public class tcpManager
    {
        Form1 form1 = new Form1();
        Form2 form2 = new Form2();
        TcpServer tcpServer1 = new TcpServer();

        public void openTCPConnection()
        {           
            this.tcpServer1.IdleTime = 50;
            this.tcpServer1.IsOpen = false;
            this.tcpServer1.MaxCallbackThreads = 100;
            this.tcpServer1.MaxSendAttempts = 3;
            this.tcpServer1.Port = -1;
            this.tcpServer1.VerifyConnectionInterval = 0;
            this.tcpServer1.OnDataAvailable += new tcpServer.tcpServerConnectionChanged(this.tcpServer1_OnDataAvailable);
            tcpServer1.Close();
            tcpServer1.Port = 8000;
            tcpServer1.Open();
        }
        public void sendData()
        {
            string openForm = "openForm";
            this.tcpServer1.Send(openForm);
        }
        public delegate void invokeDelegate();
        private void tcpServer1_OnDataAvailable(tcpServer.TcpServerConnection connection)
        {
            byte[] data = readStream(connection.Socket);
            if (data != null)
            {
                string dataStr = Encoding.ASCII.GetString(data);
                if (dataStr.Contains("openForm1"))
                {
                    Application.Run(new Form1());
                    form2.Close();
                }
                else if (dataStr.Contains("openForm2"))
                {
                    Application.Run(new Form2());
                    form1.Close();
                }
                else if (dataStr.Contains("closeAll"))
                {
                    form1.Close();
                    form2.Close();
                }
            }
        }

        protected byte[] readStream(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] tmpBuffer = new byte[1024];
            var buffer = new List<byte>(); 
            while (stream.DataAvailable) { 
                
                int bytesRead = stream.Read(tmpBuffer, 0, tmpBuffer.Length); 
                buffer.AddRange(tmpBuffer.Take(bytesRead)); 
                if (bytesRead < tmpBuffer.Length) 
                    break; 
            }
            return tmpBuffer;
        }
    }
}
