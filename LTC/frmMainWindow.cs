using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LTC.Misc;

namespace LTC
{
    public partial class FrmMainWindow : Form
    {
        private SerialPort controller;
        private SerialPort feedback;
        private SerialPort schalter;
        private bool power = false;

        Dictionary<int, Abschnitt> abschnitt;
        Sensor[] sensor;
        Dictionary<int, Train> zug;

        public FrmMainWindow()
        {
            InitializeComponent();
            USBPorts usb = new USBPorts();

            foreach (ComPort p in usb.Ports)
            {
                CbbController.Items.Add(p);
                CbbMelder.Items.Add(p);
                CbbSchalter.Items.Add(p);
            }

            if (CbbController.Items.Count > 0)
                CbbController.SelectedIndex = 0;

            if (CbbMelder.Items.Count > 0)
                CbbMelder.SelectedIndex = 0;

            if (CbbSchalter.Items.Count > 0)
                CbbSchalter.SelectedIndex = 0;

            abschnitt = new Dictionary<int, Abschnitt>();
            abschnitt.Add(abschnitt.Count, new Abschnitt(abschnitt.Count, 7, 3, ChbAbschnitt1, this));
            abschnitt.Add(abschnitt.Count, new Abschnitt(abschnitt.Count, 9, 0, ChbAbschnitt2, this));
            abschnitt.Add(abschnitt.Count, new Abschnitt(abschnitt.Count, 7, 1, ChbAbschnitt3, this));
            abschnitt.Add(abschnitt.Count, new Abschnitt(abschnitt.Count, 9, 2, ChbAbschnitt4, this));

            sensor = new Sensor[4];
            sensor[0] = new Sensor(1, SensorType.Hall, abschnitt[0]);
            abschnitt[0].Sensor = sensor[0];
            sensor[1] = new Sensor(2, SensorType.Hall, abschnitt[1]);
            abschnitt[1].Sensor = sensor[1];
            sensor[2] = new Sensor(3, SensorType.Hall, abschnitt[2]);
            abschnitt[2].Sensor = sensor[2];
            sensor[3] = new Sensor(4, SensorType.Hall, abschnitt[3]);
            abschnitt[3].Sensor = sensor[3];

            zug = new Dictionary<int, Train>();
        }

        private void BtnControllerConnect_Click(object sender, EventArgs e)
        {
            if ((controller == null || controller.IsOpen == false) && CbbController.SelectedItem != null)
            {
                controller = new SerialPort
                {
                    PortName = ((ComPort)CbbController.SelectedItem).name,
                    BaudRate = 9600
                };
                try
                {
                    controller.Open();
                    if (controller.IsOpen)
                    {
                        BtnControllerConnect.Text = "Disconnect";
                        CbbController.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (controller.IsOpen)
            {
                power = true;
                BtnPower_Click(sender, e);
                controller.Close();
                if (controller.IsOpen == false)
                {
                    BtnControllerConnect.Text = "Connect";
                    CbbController.Enabled = true;
                }
            }
        }

        private void FrmMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (controller != null && controller.IsOpen)
            {
                controller.Close();
            }
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            if (controller.IsOpen)
            {
                BtnTotalStop_Click(sender, e);
                if (power == false)
                {
                    controller.Write("s1;");
                    BtnPower.Text = "Power ON";
                    BtnPower.BackColor = Color.Green;
                    BtnControllerConnect.Enabled = false;
                    power = true;
                }
                else
                {
                    controller.Write("s0;");
                    BtnPower.Text = "Power OFF";
                    BtnPower.BackColor = Color.Red;
                    BtnControllerConnect.Enabled = true;
                    power = false;
                }
            }

        }
        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (controller.IsOpen && power)
            {
                zug[CbbTrains.SelectedIndex].Speed = TrbSpeed.Value;
                HandleSensorEvent(zug[CbbTrains.SelectedIndex].Position.Sensor.Triggered());
                //controller.Write("a" + (zug[CbbTrains.SelectedIndex].Position.id).ToString("000") + (zug[CbbTrains.SelectedIndex].Speed + 100).ToString("000") + ";");
                //controller.Write("a000" + (TrbSpeed.Value + 100).ToString("000") + ";");
                //controller.Write("a001" + (TrbSpeed.Value + 100).ToString("000") + ";");
                //controller.Write("a002" + (TrbSpeed.Value + 100).ToString("000") + ";");
                //controller.Write("a003" + (TrbSpeed.Value + 100).ToString("000") + ";");
            }
        }

        private void TrbSpeed_Scroll(object sender, EventArgs e)
        {
            LblSpeed.Text = TrbSpeed.Value.ToString();
            zug[CbbTrains.SelectedIndex].Speed = TrbSpeed.Value;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TrbSpeed.Value = 0;
            LblSpeed.Text = "0";
            if (controller.IsOpen && power)
            {
                zug[CbbTrains.SelectedIndex].Speed = TrbSpeed.Value;
                controller.Write("a" + (zug[CbbTrains.SelectedIndex].Position.id).ToString("000") + (zug[CbbTrains.SelectedIndex].Speed + 100).ToString("000") + ";");
                //controller.Write("a000" + (TrbSpeed.Value + 100).ToString("000") + ";");
                //controller.Write("a001" + (TrbSpeed.Value + 100).ToString("000") + ";");
                //controller.Write("a002" + (TrbSpeed.Value + 100).ToString("000") + ";");
            }
        }

        public void PowerAbschnitt(int id)
        {
            if (controller.IsOpen && power)
            {
                controller.Write("a" + (id).ToString("000") + (abschnitt[id].Zug.Speed + 100).ToString("000") + ";");
            }
        }
        public void StopAbschnitt(int id)
        {
            if (controller.IsOpen && power)
            {
                controller.Write("a" + (id).ToString("000") + (0 + 100).ToString("000") + ";");
            }
        }

        public void SetAmpel(int ampelID, bool go)
        {
            if (schalter != null && schalter.IsOpen)
            {
                schalter.Write("t" + (ampelID).ToString("000") + Convert.ToInt32(!go).ToString("0") + ";");
            }
        }

        private void BtnMelderConnect_Click(object sender, EventArgs e)
        {
            if ((feedback == null || feedback.IsOpen == false) && CbbMelder.SelectedItem != null)
            {
                feedback = new SerialPort
                {
                    PortName = ((ComPort)CbbMelder.SelectedItem).name,
                    BaudRate = 115200
                };
                try
                {
                    feedback.Open();
                    if (feedback.IsOpen)
                    {
                        feedback.DataReceived += Feedback_DataReceived;
                        BtnMelderConnect.Text = "Disconnect";
                        CbbMelder.Enabled = false;
                        foreach (KeyValuePair<int, Abschnitt> section in abschnitt)
                            section.Value.Init();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (feedback.IsOpen)
            {
                feedback.Close();
                if (feedback.IsOpen == false)
                {
                    BtnMelderConnect.Text = "Connect";
                    CbbMelder.Enabled = true;
                }
            }
        }

        private void BtnSchalterConnect_Click(object sender, EventArgs e)
        {
            if ((schalter == null || schalter.IsOpen == false) && CbbSchalter.SelectedItem != null)
            {
                schalter = new SerialPort
                {
                    PortName = ((ComPort)CbbSchalter.SelectedItem).name,
                    BaudRate = 9600
                };
                try
                {
                    schalter.Open();
                    if (schalter.IsOpen)
                    {
                        BtnSchalterConnect.Text = "Disconnect";
                        CbbSchalter.Enabled = false;
                        foreach (KeyValuePair<int, Abschnitt> section in abschnitt)
                            section.Value.Init();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (schalter.IsOpen)
            {
                schalter.Close();
                if (schalter.IsOpen == false)
                {
                    BtnSchalterConnect.Text = "Connect";
                    CbbSchalter.Enabled = true;
                }
            }
        }

        private void Feedback_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line = feedback.ReadLine();
            if(power)
                this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }

        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            line = line.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
            richTextBox1.Text = "RX: " + line + "\r\n" + richTextBox1.Text;
            string[] parts = line.Split(';');
            foreach(string part in parts)
            {
                if (part.Length == 4)
                {
                    string sensorChar = part.Substring(0, 1);
                    int sensorID = Convert.ToInt32(part.Substring(1, 3));
                    switch (sensorChar)
                    {
                        case "H":
                            if(sensor[sensorID].State == false)
                                HandleSensorEvent(sensor[sensorID].Triggered());  //Sensor auf aktuellem Abschnitt getriggert
                            break;
                    }
                }
            }
        }

        private void HandleSensorEvent(int id)
        {
            int nextTrain;
            int num = abschnitt.Count;

            if (abschnitt[(num + (id - 1)) % num].Belegt && abschnitt[id].Zug.ID == abschnitt[(num + (id - 1)) % num].Zug.ID)
            {
                abschnitt[(num + (id - 1)) % num].Freigeben();  //letzten Abschnitt freigeben, wenn der Zug ihn auch belegt
                StopAbschnitt(abschnitt[(num + (id - 1)) % num].id);
            }

            abschnitt[(id + 1) % num].Blocken(abschnitt[id].Zug);  //nächsten Abschnitt blocken
            nextTrain = abschnitt[(id + 1) % num].Check(); //den nächsten Zug in der Warteschlagen des nächsten Abschnittes fahren lassen, ID des Abschnittes auf dem der relevante Zug steht

            if (nextTrain < 0 || zug[nextTrain].Position.id != id)   //nextTrain = -1 Abschnitt ist noch belegt, nextTrain != id, der Zug, der den Sensor ausgelöst hat, ist nich an der Reihe. Ein anderer Zug hat vorfahrt
            {
                StopAbschnitt(id);  //Triggerzug anhalten
            }
            else
            {
                PowerAbschnitt((id + 1) % num);   //gecheckten Abschnitt (nächsten) powern
                PowerAbschnitt(zug[nextTrain].Position.id);      //relevanten Zug starten
                zug[nextTrain].Position = abschnitt[(id + 1) % num];    // Position des relevanten Zuges auf den neuen Abschnitt setzen
            }

            nextTrain = abschnitt[(num + (id - 1)) % num].Check();  //Den freigegebenen Abschnitte prüfen und Warteschlange abbauen

            if (nextTrain >= 0)     //Es ist ein Zug in der Warteschlange
            {
                PowerAbschnitt((num + (id - 1)) % num); //Freigebenen Abschnitt powern
                PowerAbschnitt(zug[nextTrain].Position.id);  //Zug aus der Warteschlangen starten
                zug[nextTrain].Position = abschnitt[(num + (id - 1)) % num];    //Position anpassen
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //abschnitt[0].Freigeben();
            //abschnitt[1].Freigeben();
        }

        private void erstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrainCreate frmTrainCreate = new FrmTrainCreate(this, abschnitt.Count);
            frmTrainCreate.ShowDialog();
        }

        public void CreateTrain(string _name, int _pos)
        {
            zug.Add(zug.Count, new Train(zug.Count, _name, abschnitt[_pos]));
            this.CbbTrains.Items.Add(zug[zug.Count - 1].ToString());
            if (this.CbbTrains.Items.Count > 0)
                CbbTrains.SelectedIndex = 0;
        }

        private void CbbTrains_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrbSpeed.Value = zug[CbbTrains.SelectedIndex].Speed;
            LblSpeed.Text = zug[CbbTrains.SelectedIndex].Speed.ToString();
        }

        private void BtnTotalStop_Click(object sender, EventArgs e)
        {
            if (controller.IsOpen)
            {
                foreach(KeyValuePair<int, Abschnitt> section in abschnitt)
                    controller.Write("a" + section.Key.ToString("000") + (0 + 100).ToString("000") + ";");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LineReceived("H001;");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LineReceived("H002;");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LineReceived("H003;");
        }
    }
}
