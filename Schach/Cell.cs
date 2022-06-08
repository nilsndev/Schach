using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schach
{
    public class Cell
    {
       public int I { get; set; }
        public int J { get; set; }
        public bool nextLegalMove;
        public string objectColor { get; set; }
        public int this[int i,int j]
        {
            get
            {
                return this[i,j];
            }

            set
            {
                this[i,j] = value;
            }
        }
    }
}
