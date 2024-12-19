using System.Net;
using System.Net.Sockets;
using System.Text.Json;

namespace Lab4_skeleton
{
    public partial class Form1 : Form
    {
        public IPAddress localAddress;
        public int localPort;
        public int remotePort;
        public Form1()
        {
            InitializeComponent();
            saveUDPDataBtn.Enabled = true;
            sendUDPDataBtn.Enabled = false;
            inText.Enabled = false;
            ip.Enabled = true;
            port.Enabled = true;
            portLocal.Hide();
            localPortLable.Hide();
            outText.Enabled = false;
        }
        public async void Setting()
        {
            try
            {
                using (FileStream fs = new FileStream("appsetting.json", FileMode.OpenOrCreate))
                {
                    Connection connection = await JsonSerializer.DeserializeAsync<Connection>(fs);
                    if (!String.IsNullOrEmpty(connection.ip))
                    {
                        localAddress = IPAddress.Parse(connection.ip);
                        remotePort = connection.remotePort;
                        localPort = connection.localPort;
                        ip.Text = localAddress.ToString();
                        port.Text = remotePort.ToString();
                        portLocal.Text = portLocal.ToString();
                    }
                }
            }
            catch (JsonException ex)
            {

                history.Items.Add("������ ���������� json");
            }
            catch (Exception ex)
            {

                history.Items.Add(ex);
            }

        }

        private async void saveUDPDataBtn_Click(object sender, EventArgs e)
        {
            try
            {

                localAddress = IPAddress.Parse(ip.Text);
                remotePort = Int32.Parse(port.Text);
                localPort = Int32.Parse(portLocal.Text);

                if (Int32.Parse(portLocal.Text) > 65535)
                {
                    throw new OverflowException("������� ������� ����� � ��������� �����. ������������ ��������� ���� �� ����� 65535");
                }

                if (Int32.Parse(port.Text) > 65535)
                {
                    throw new OverflowException("������� ������� ����� � ��������� �����. ������������ ��������� ���� �� ����� 65535");
                }
                saveUDPDataBtn.Enabled = false;
                sendUDPDataBtn.Enabled = true;
                inText.Enabled = true;
                ip.Enabled = false;
                port.Enabled = false;
                history.Items.Add("�����������");
                await ReceiveMessageAsync();

            }
            catch (ArgumentNullException ex)
            {
                if (String.IsNullOrEmpty(ip.Text))
                {
                    history.Items.Add("Ip ����� �� ������, ������� Ip �����.");
                }
                if (String.IsNullOrEmpty(portLocal.Text))
                {
                    history.Items.Add("��������� ���� �� ������, ������� ��������� ����");
                }
                if (String.IsNullOrEmpty(port.Text))
                {
                    history.Items.Add("��������� ���� �� ������, ������� ��������� ����");
                }
            }
            catch (FormatException ex)
            {
                if (ex.TargetSite.DeclaringType.Name == "IPAddressParser")
                {
                    history.Items.Add("Ip ����� ����� ������������ ���, ������� Ip ����� �� �������: 127.0.0.1");

                }
                if (ex.TargetSite.DeclaringType.Name == "Number")
                {
                    history.Items.Add("����� ����� ������������ ���, ������� ����� �� �������: 55555");

                }

            }
            catch (OverflowException ex)
            {
                history.Items.Add(ex.Message);
            }
            catch (Exception ex)
            {
                history.Items.Add(ex.Message);
            }
        }
        async Task ReceiveMessageAsync()
        {
            string formattedDate = DateTime.Now.ToString("dd.MM.yyyy_hh-mm-ss");
            string path = formattedDate + ".txt";
            using UdpClient receiver = new UdpClient(localPort);
            history.Items.Add("������������� ����� " + localPort);
            while (true)
            {
                string str = "";
                string strCode = "";
                string strBin = "";

                string strDecode = "";

                // �������� ������
                var result = await receiver.ReceiveAsync();
                var message = result.Buffer;
                byte[] strBin2 = new byte[message.Length];
                // ������� ���������
                int j = 0;
                foreach (var item in message)
                {
                    str = str + item.ToString() + " ";
                    strCode = strCode + (char)item;
                    strBin = strBin + Convert.ToString(item, 2) + " ";
                    strBin2[j] = item;
                    strDecode = strDecode + ISO.DeISO[item];
                    j++;
                }

                outText.Text = outText.Text + "����������: " + strDecode + "\n";

                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append)))
                {
                    foreach (var item in strBin2)
                    {
                        writer.Write(item);
                    }
                }
            }
        }
        async Task SendMessageAsync()
        {
            using UdpClient sender = new UdpClient();
            string str = inText.Text;
            byte[] codeStrBin = new byte[str.Length];
            int j = 0;
            foreach (char item in str)
            {
                if (ISO.Iso.ContainsKey(item))
                {
                    codeStrBin[j] = (byte)ISO.Iso[item];
                    j = j + 1;

                }
            }
            outText.Text = outText.Text + "��: " + str + "\n";
            await sender.SendAsync(codeStrBin, codeStrBin.Length, new IPEndPoint(localAddress, remotePort));
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                portLocal.Show();
                localPortLable.Show();
            }
            else
            {
                portLocal.Hide();
                localPortLable.Hide();
            }
        }

        private async void sendUDPDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await SendMessageAsync();

            }
            catch (ArgumentOutOfRangeException)
            {
                history.Items.Add("��������� ���� ������� �������, ������� ���� �� 1024 �� 65535");
            }
        }
        // �������� ��������� � ������
    }
}
