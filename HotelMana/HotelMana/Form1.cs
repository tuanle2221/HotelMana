using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelMana.Properties;
using System.Data.OleDb;
using System.Collections;
using System.IO;
using System.IO.Ports;
using HotelMana.TEASOLUTIONDOTNETWS;

namespace HotelMana
{
    public partial class frmMain : Form
    {
        int phong=1;
       Boolean On = false;
        int[] limit = new int[1000];
        Boolean[] isstopping = new Boolean[1000];
        Boolean[] active = new Boolean[1000];
        Boolean[] isidle = new Boolean[1000];

        String[] from = new String[1000];
        String[] to = new String[1000];
        Button[] btnStart = new Button[1000];
        Label[] lblFrom = new Label[1000];
        Label[] lblTo = new Label[1000];
        Label[] lblEnd = new Label[1000];

        String[] room = new String[1000];
        String[] loai = new String[1000];
        float[] gia = new float[1000];

        FlowLayoutPanel[] Phong = new FlowLayoutPanel[1000];


        myClass[] myFrom = new myClass[1000];
        myClass[] myTo = new myClass[1000];
        myClass[] myEnd = new myClass[1000];

        SerialPort serialPort1 = new SerialPort();
        // Runtime runtime = Runtime.Kinects[0];
        /// <summary>
        /// some parameter initialize.
        /// </summary>
        string Received_data;
        //string Pstatus1 = "OFF";
        // string Pstatus2 = "OFF";
        // string Pstatus3 = "OFF";
        string Bstatus = "0";
        string Rcstatus = "";
        String[] ports;

        myClass myLayout;

        public frmMain()
        {
            InitializeComponent();
            ports = SerialPort.GetPortNames();
            serialPort1.PortName = "COM13";

            // comboBox1.Text.ToUpper();
            // tốc độ truyền 
            serialPort1.BaudRate = 57600;

            serialPort1.Handshake = System.IO.Ports.Handshake.None;
            serialPort1.Parity = Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
            ports = SerialPort.GetPortNames();

            cbbPort.Items.AddRange(ports);
            /*if (ports.Length > 0)
            {
                for (int i = 30; i < 0; i++)
                {
                    serialPort1.PortName = ports[i];
                    try
                    {
                        serialPort1.Open();
                        //MessageBox.Show(serialPort1.;
                        serialPort1.DiscardInBuffer();
                        //serialPort1.Close();
                        //MessageBox.Show(serialPort1.PortName);
                       // break;
                    }
                    catch (Exception ex)    
                    {
                    }
                }
                /*try
                {
                    serialPort1.Open();
                    serialPort1.DiscardInBuffer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.ResourceManager.GetString("notss"));
                }
            }
            else
            {
                MessageBox.Show(Resources.ResourceManager.GetString("notss"));
            }*/
            try
            {
                serialPort1.Open();
                //serialPort1.DiscardInBuffer();
            }
            catch (IOException ex)
            {
                //MessageBox.Show(ex.Message);
            }

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (ports.Length > 0)
            {
                cbbPort.SelectedIndex = 0;
            }
            myLayout = new myClass(layout);
            for (int i = 0; i < 1000; i++)
            {
                isstopping[i] = true;
                active[i] = false;
                isidle[i] = true;
            }
            timer1.Start();


        }
        private void AddPhong(int phong)
        {
            getGiaWithRoom(phong);
            //if (room[phong] != null)
            //{
            //MessageBox.Show("Adding");
                Phong[phong] = new FlowLayoutPanel();
                Phong[phong].WrapContents = true;
                Phong[phong].FlowDirection = FlowDirection.LeftToRight;
                Phong[phong].Width = layout.Width;
                Phong[phong].Height = 60;

                Label lbl = new Label();
                lbl.Text = "Phòng " + phong;
                lbl.Width = 80;
                lbl.ForeColor = Color.Red;
                lbl.Font = new Font("Microsoft Sans Serif", 10.0F);
                Phong[phong].Controls.Add(lbl);
                Phong[phong].SetFlowBreak(lbl, true);

                Label from = new Label();
                from.Text = Resources.ResourceManager.GetString("from");
                from.Width = 30;
                from.Font = new Font("Microsoft Sans Serif", 10.0F);
                from.Margin = new Padding(3, 6, 0, 5);
                Phong[phong].Controls.Add(from);

                lblFrom[phong] = new Label();
                lblFrom[phong].Text = "00:00:00";
                lblFrom[phong].ForeColor = Color.Blue;
                lblFrom[phong].Font = new Font("Microsoft Sans Serif", 15.0F);
                myFrom[phong] = new myClass(lblFrom[phong]);
                Phong[phong].Controls.Add(lblFrom[phong]);

                Label to = new Label();
                to.Text = Resources.ResourceManager.GetString("to");
                to.Width = 40;
                to.Font = new Font("Microsoft Sans Serif", 10.0F);
                to.Margin = new Padding(3, 6, 0, 5);
                Phong[phong].Controls.Add(to);

                lblTo[phong] = new Label();
                lblTo[phong].Text = "00:00:00";
                lblTo[phong].ForeColor = Color.Red;
                lblTo[phong].Font = new Font("Microsoft Sans Serif", 15.0F);
                myTo[phong] = new myClass(lblTo[phong]);
                Phong[phong].Controls.Add(lblTo[phong]);

                Label end = new Label();
                end.Text = Resources.ResourceManager.GetString("total");
                end.Width = 103;
                end.Font = new Font("Microsoft Sans Serif", 10.0F);
                end.Margin = new Padding(3, 6, 0, 5);
                Phong[phong].Controls.Add(end);

                lblEnd[phong] = new Label();
                lblEnd[phong].Text = "00:00:00";
                lblEnd[phong].ForeColor = Color.Red;
                lblEnd[phong].Font = new Font("Microsoft Sans Serif", 15.0F);
                myEnd[phong] = new myClass(lblEnd[phong]);
                Phong[phong].Controls.Add(lblEnd[phong]);

                isidle[phong] = false;
                //layout.Controls.Add(Phong[phong]);
               myLayout.UpdateMyLayout(Phong[phong]);
            //}
        }
        private void SwitchActive(int phong)
        {
                //btnStart[phong].Text = Resources.ResourceManager.GetString("stop");
                myFrom[phong].UpdateLB(DateTime.Now.ToString("HH:mm:ss").Substring(DateTime.Now.ToString("HH:mm:ss").Length - 8));
                myTo[phong].UpdateCLB(Color.Blue);
                from[phong] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                active[phong] = true;
                isstopping[phong] = false;
            
        }
        private void SwitchUnActive(int phong)
        {
            
            myTo[phong].UpdateLB(DateTime.Now.ToString("HH:mm:ss").Substring(DateTime.Now.ToString("HH:mm:ss").Length - 8));
            myTo[phong].UpdateCLB(Color.Red);
            to[phong] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            active[phong] = false;
            isstopping[phong] = true;
            isidle[phong] = true;
            myEnd[phong].UpdateLB((DateTime.Parse(lblTo[phong].Text) - DateTime.Parse(lblFrom[phong].Text)).ToString());
            //Save to database
            Double cost = 0;
            if (DateTime.Parse(lblEnd[phong].Text) >= DateTime.Parse("00:00:10"))
            {
                cost = ((DateTime.Parse(lblEnd[phong].Text).Second + DateTime.Parse(lblEnd[phong].Text).Minute * 60 + DateTime.Parse(lblEnd[phong].Text).Hour * 3600) * (gia[phong] / 3600.0));
            }
            Employ em = new Employ(phong.ToString(), from[phong], to[phong], lblEnd[phong].Text, gia[phong].ToString(), cost);
            em.SaveToDatabase();
            myLayout.UpdateRemMyLayout(Phong[phong]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            limit[phong] += 1;
            for (int i = 1; i < 1000; i++)
            {
                if (active[i])
                {
                    lblTo[i].Text = DateTime.Now.ToString("HH:mm:ss");
                    lblEnd[i].Text = (DateTime.Parse(lblTo[i].Text) - DateTime.Parse(lblFrom[i].Text)).ToString();
                }
            }
        }

        public void getGiaWithRoom(int phong)
        {
            String constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\data.mdb;Persist Security Info=false";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandType = System.Data.CommandType.Text;
            com.CommandText = "SELECT room.id_phong AS iid_phong, room.room_name AS tenphong, loai.ten_loai AS loai, gia.gia AS gia FROM (room INNER JOIN loai ON room.id_loai = loai.id_loai) INNER JOIN gia ON loai.id_gia = gia.id_gia WHERE room.id_phong=@room";
            com.Parameters.AddWithValue("@room", phong);
            con.Open();
            OleDbDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                room[phong] = reader.GetValue(1).ToString();
                loai[phong] = reader.GetValue(2).ToString();
                gia[phong] = float.Parse(reader.GetValue(3).ToString());
            }
            con.Close();
        }

        private void themphongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddPhong(phong);
        }

        private void nhatkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhatky nhatky = new Nhatky();
            nhatky.Show();

        }

        private delegate void UpdateUiTextDelegate(string text);
        void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String input = serialPort1.ReadLine();
            MessageBox.Show(input);
            do
            {
                //  Application.DoEvents();

                //Debug.WriteLine(bTimeOutFlag);
                //Debug.WriteLine(comport.BytesToRead);
                // if () break;
            }
            while (serialPort1.BytesToRead < 3);


            Bstatus = Convert.ToString(serialPort1.BytesToRead);
            ////xu ly moi
            byte[] Rbuff = new byte[3];

            if (serialPort1.BytesToRead >= 3)
            {
                Rbuff[0] = Convert.ToByte(serialPort1.ReadByte());
                Rbuff[1] = Convert.ToByte(serialPort1.ReadByte());
                Rbuff[2] = Convert.ToByte(serialPort1.ReadByte());
            }
            byte[] Rbuff2 = new byte[Rbuff[2] + 4];
            Rbuff2[0] = Rbuff[0];
            Rbuff2[1] = Rbuff[1];
            Rbuff2[2] = Rbuff[2];

            for (int j = 0; j < Rbuff2[2] + 1; j++)
            {
                Rbuff2[j + 3] = Convert.ToByte(serialPort1.ReadByte());
            }

            Received_data = BitConverter.ToString(Rbuff2);
            Rcstatus =Received_data ;
            MessageBox.Show(Received_data );
            
            //phong = Int32.Parse(Received_data.Substring(15,2));

            /*if (Received_data.Substring(36, 1) == "1")
            {
                    On = false;
            }
            else
            {
                On = true;
            }
            if (isidle[phong] && On)
            {
                AddPhong(phong);
                SwitchActive(phong);
            }
            if (!isstopping[phong] && !On)
            {
                SwitchUnActive(phong);
            }*/
        }

        private void cbbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPort.SelectedIndex >= 0)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                try
                {
                    serialPort1.PortName = cbbPort.SelectedItem.ToString();
                    //MessageBox.Show(cbbPort.SelectedItem.ToString());
                    serialPort1.Open();
                    //serialPort1.DiscardInBuffer();
                }
                catch (IOException ex)
                {
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //isidle[5] = false;
            for (int i = 0; i < 1000; i++)
            {
                if (!isidle[i])
                {
                    e.Cancel = true;
                    MessageBox.Show(this, "Bạn không thể tắt ứng dụng vì ứng dụng đang quản lý một số phòng cho thuê.", "Thoát ứng dụng");
                    break;
                }
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    class myClass
    {
        private delegate void UpdateLayout(FlowLayoutPanel llayout);
        private delegate void UpdateRemLayout(FlowLayoutPanel llayout);
        private delegate void UpdateLable(String str);
        private delegate void UpdateColorLable(Color c);
        private Label lbl;

        private FlowLayoutPanel layout;
        public myClass(FlowLayoutPanel llayout)
        {
            this.layout = llayout;
        }
        public myClass(Label lbl)
        {
            this.lbl = lbl;
        }

        public void UpdateMyLayout(FlowLayoutPanel llayout)
        {
            UpdateLayout ulayout = new UpdateLayout(this.OnUpdateLayout);
            layout.Invoke(ulayout, new Object[] { llayout });
        }
        public void UpdateRemMyLayout(FlowLayoutPanel llayout)
        {
            UpdateRemLayout ulayout = new UpdateRemLayout(this.OnUpdateRemLayout);
            layout.Invoke(ulayout, new Object[] { llayout });
        }
        public void UpdateLB(String str)
        {
            UpdateLable ulb = new UpdateLable(this.OnUpdateLB);
            lbl.Invoke(ulb, new Object[] { str });
        }
        public void UpdateCLB(Color c)
        {
            UpdateColorLable ulb = new UpdateColorLable(this.OnUpdateCLB);
            lbl.Invoke(ulb, new Object[] { c });
        }

        private void OnUpdateLB(String str)
        {
            lbl.Text = str;
        }
        private void OnUpdateLayout(FlowLayoutPanel llayout)
        {
            layout.Controls.Add(llayout);
        }
        private void OnUpdateRemLayout(FlowLayoutPanel llayout)
        {
            layout.Controls.Remove(llayout);
        }
        private void OnUpdateCLB(Color c)
        {
            lbl.ForeColor = c;
        }
    }
}
