using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTC.Misc
{
    public class Abschnitt
    {
        //hilfswerk
        FrmMainWindow main;

        public int id;
        private int length;
        private bool belegt;
        private Train zug;
        private Sensor sensor;
        private CheckBox label;
        private Queue<Train> schlange;
        private int ampelID;
        
        public bool Belegt
        {
            get { return this.belegt; }
        }


        public Abschnitt(int _id, int _length, int ampel, CheckBox _label, FrmMainWindow _main)
        {
            id = _id;
            length = _length;
            ampelID = ampel;
            belegt = false;
            label = _label;
            schlange = new Queue<Train>();
            main = _main;
        }

        public void Init()
        {
            if (belegt)
                Belegen(this.zug);
            else
                Freigeben();
        }

        public Sensor Sensor
        {
            get { return this.sensor; }
            set { this.sensor = value; }
        }

        public int Ampel
        {
            get { return ampelID; }
        }

        public void Belegen(Train _zug)
        {
            if (_zug != null)
            {
                label.Checked = true;
                belegt = true;
                zug = _zug;
                main.SetAmpel(ampelID, false);
                label.Text = "Abschnitt " + id.ToString() + "\nBelegt durch " + zug.ToString();
            }
        }

        public void Freigeben()
        {
            label.Checked = false;
            belegt = false;
            zug = null;
            sensor.Release();
            main.SetAmpel(ampelID, true);
            label.Text = "Abschnitt " + id.ToString() + "\nFrei";
        }

        public void Blocken(Train _zug)
        {
            schlange.Enqueue(_zug);
        }

        public int Check()
        {
            if(this.belegt == false && schlange.Count > 0)
            {
                this.Belegen(schlange.Dequeue());
                return this.Zug.ID;
            }
            else
            {
                return -1;
            }
        }

        public Train Zug
        {
            get { return this.zug; }
        }
    }
}
