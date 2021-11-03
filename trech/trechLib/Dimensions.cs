using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trechLib
{
    public class Dimensions
    {
        public Dictionary<string, Dimension> Series = new Dictionary<string, Dimension>();

        public Dimensions()
        {
            AddDimension("noise"); // theoretical
        }

        public Dimension AddDimension(string Type)
        {
            var dim = new Dimension();
            dim.Type = Type;
            return dim;
        }
    }

    public class Dimension
    {
        public string Type;
        public Unit Unit;
        public string Value;
    }
}
