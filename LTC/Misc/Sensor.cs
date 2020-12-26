using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTC.Misc
{
    public enum SensorType { Reed, Current, Light, Hall}
    public class Sensor
    {
        private int ID;
        private SensorType type;
        private Abschnitt abschnitt;
        private bool state;

        public Sensor(int _id, SensorType _type, Abschnitt _abschnitt)
        {
            ID = _id;
            type = _type;
            abschnitt = _abschnitt;
            state = false;
        }
        /// <summary>
        /// Sensor wurde ausgelöst (HallSensor)
        /// </summary>
        public int Triggered()
        {
            this.state = true;
            return abschnitt.id;
        }

        public bool State
        {
            get { return this.state; }
        }

        public void Release()
        {
            this.state = false;
        }
    }
}
