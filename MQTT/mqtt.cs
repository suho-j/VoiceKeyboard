using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace MQTT
{
    public partial class mqtt : Form
    {
        #region Field
        MqttClient client;
        string ip = null ;
        int port = 0;
        string clientId;
        int selStart = 0;
        bool isconnected = false;
        string username; string password;
        string[] topics = new string[2];
        byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };
        #endregion

        public mqtt()
        {
            InitializeComponent();
        }

        private void mqtt_Load(object sender, EventArgs e)
        {
            txtReader();
        }

        
        private StringBuilder _Strings;
        private String Strings
        {
            set
            {
                if (_Strings == null)
                    _Strings = new StringBuilder(1024);
                // 로그 길이가 1024자가 되면 이전 로그 삭제
                if (_Strings.Length >= (1024 - value.Length))
                    _Strings.Clear();
                // 로그 추가 및 화면 표시
                _Strings.AppendLine(value);
                tbStatus.Text = _Strings.ToString();
            }
        }

        private Boolean IsOpen
        {
            set
            {
                if (value)
                {
                    Strings = "연결 됨";
                    btnConnectControl.Text = "연결 끊기";
                    //tbRecvMessage.Enabled = true;
                    gbSettings.Enabled = false;
                }
                else
                {
                    Strings = "연결 해제됨";
                    btnConnectControl.Text = "연결";
                    //tbRecvMessage.Enabled = false;
                    gbSettings.Enabled = true;
                }
            }
        }

        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            this.Invoke(new EventHandler(delegate
            {
                string ReceivedMessage = Encoding.UTF8.GetString(e.Message);

                Invalidate();
                selStart = tbRecvMessage.SelectionStart;
                tbRecvMessage.Text = tbRecvMessage.Text.Insert(selStart, ReceivedMessage);

                selStart = selStart + ReceivedMessage.Length;   // 시작위치 + 붙여넣은 string의 길이 반환
                tbRecvMessage.Select(selStart, 0); // 커서값 새로 설정
            }));
        }

        private void btnConnectControl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIp.Text.Trim()))
            {
                MessageBox.Show("input the IP");
                return;
            }
            if (string.IsNullOrEmpty(tbPort.Text.Trim()))
            {
                MessageBox.Show("input the Port");
                return;
            }

            try
            {
                if (!isconnected)
                {
                    ip = tbIp.Text;
                    port = int.Parse(tbPort.Text);
                    username = tbId.Text;
                    password = tbPw.Text;

                    client = new MqttClient(IPAddress.Parse(ip), port, false, null, null, 0);

                    client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                    clientId = Guid.NewGuid().ToString();

                    var returnNum = client.Connect(clientId, username, password);

                    if (returnNum != 0)
                    {
                        Strings = "Please check UserName or PassWord ...";
                        gbSettings.Enabled = true;
                        btnConnectControl.Enabled = true;
                        return;
                    }

                    topics[0] = username + "/pnuh_stt";
                    topics[1] = username + "/pnuh_stt";
                    client.Subscribe(topics, qosLevels);

                    isconnected = !isconnected;
                    IsOpen = isconnected;
                    txtWriter();
                }
                else
                {
                    client.Unsubscribe(topics);
                    client.Disconnect();

                    isconnected = !isconnected;
                    IsOpen = isconnected;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Exception connecting to the broker")
                {
                    Strings = "Please check IP or Port or Server ...";
                }
                btnConnectControl.Enabled = true;
                gbSettings.Enabled = true;
            }
        }
        
        /// <summary>
        /// ip, port, id 불러오기
        /// </summary>
        public void txtReader()
        {
            string line;
            string path = Application.StartupPath + @"\Data\settings.txt";
            try
            {
                using (StreamReader rdr = new StreamReader(path))
                {
                    // ReadLine()을 써서 한 라인을 읽어 들인다
                    // 만약 파일 끝이면 null이 리턴된다
                    int i = 0;
                    while ((line = rdr.ReadLine()) != null)
                    {
                        switch (i)
                        {
                            case 0:
                                this.Invoke(new Action(() => this.tbIp.Text = line));
                                break;
                            case 1:
                                this.Invoke(new Action(() => this.tbPort.Text = line));
                                break;
                            case 2:
                                this.Invoke(new Action(() => this.tbId.Text = line));
                                break;
                            default:
                                break;
                        }
                        i++;
                    }
                }
            }
            catch (IOException) { }
        }

        /// <summary>
        /// ip, port, id 저장
        /// </summary>
        public void txtWriter()
        {
            string path = Application.StartupPath + @"\Data\settings.txt";
            try
            {
                // 텍스트 파일 쓰기            
                // StreamWriter 객체를 생성한다. 입력파라미터로 File Path나 파일스트림 사용한다.
                using (StreamWriter wr = new StreamWriter(path))
                {
                    // WriteLine()을 써서 한 라인씩 문자열을 쓴다.                
                    wr.WriteLine(tbIp.Text);
                    wr.WriteLine(tbPort.Text);
                    wr.WriteLine(tbId.Text);
                }
            }
            catch (IOException) { }
        }

        private void mqtt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isconnected)
            {
                client.Unsubscribe(topics);
                client.Disconnect();
            }
        }

    }
}
