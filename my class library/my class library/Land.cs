using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_class_library
{
    public  class Land : Vehicle
    {


        private int _wheels;


        public int Wheels { get => _wheels; set => _wheels = value; }

        public Land(string color, int wheels) : base(color)
        {
            Wheels = wheels;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Number of Wheels {Wheels}";
        }
    }
}
