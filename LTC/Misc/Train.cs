using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTC.Misc
{
    public class Train
    {
        private int id;
        private string name;
        private Abschnitt abschnitt;
        private int speed;
        private int direction;
        
        public Train(int _id, string _name, Abschnitt _abschnitt)
        {
            id = _id;
            name = _name;
            abschnitt = _abschnitt;
            abschnitt.Belegen(this);
            speed = 0;
            direction = 1;
        }

        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public Abschnitt Position
        {
            get { return this.abschnitt; }
            set { this.abschnitt = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int Direction
        {
            get { return this.direction; }
            set { this.direction = value; }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
