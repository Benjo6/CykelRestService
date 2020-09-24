using System;
using System.Reflection.Metadata;

namespace Cykel
{
    public class Cykel1
    {

        private int _id;
        private string _farve;
        private int _pris;
        private int _gear;

        public Cykel1(string farve, int pris, int gear, int id)
        {
            Id = id;
            Pris = pris;
            Farve = farve;
            Gear = gear;

        }

        public int Id { get => _id; set => _id = value; }

        public int Pris
        {
            get => _pris; set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("LOOOOOL");
                _pris = value;
            }
        }
        public string Farve
        {
            get => _farve; set
            {
                if (value == null) throw new ArgumentNullException("Why are you making me mad");
                if (value.Length < 1) throw new ArgumentException("STUPID");

                _farve = value;
            }
        }
        public int Gear
        {
            get => _gear;

            set
            {
                if (3 <= value && value <= 32)
                    _gear = value;
                else throw new ArgumentOutOfRangeException("gear", value, "Oh Hell No");
            }
        }
    }
}

