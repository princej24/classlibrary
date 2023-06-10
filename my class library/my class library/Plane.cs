using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_class_library
{
    public class Plane : Air
    {
        public int NumberOfJets { get; set; }

        public Plane(string color, int numberOfJets) : base(color)
        {
            NumberOfJets = numberOfJets;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Number of Jets {NumberOfJets}";
        }

    }
}
