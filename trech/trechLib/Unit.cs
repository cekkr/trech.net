using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace trechLib
{
    public class Unit
    {
        public System System;
        public BigInteger Value;

        public Unit(System System)
        {
            this.System = System;
            System.Units.Add(this);
        }

        public int SetValue
        {
            set
            {
                Value = new BigInteger(value);
            }
        }
    }
}
