using System;
using System.Collections.Generic;
using System.Text;

namespace A2SDD
{
    enum Level {A, B, C, D, E}
    class Position
    {
        public Level Level { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        String Title(Position p)
        {
            return "Code to return string title";
        }

        String ToTitle(Level l)
        {
            if(l.CompareTo("A") == 0)
            {
                return "A";
            } else if  (l.CompareTo("B") == 0) {
                return "B";
            }
            else if (l.CompareTo("C") == 0)
            {
                return "C";
            }
            else if (l.CompareTo("D") == 0)
            {
                return "D";
            }
            else if (l.CompareTo("E") == 0)
            {
                return "E";
            }
            return "NULL";
        }

       
    }
}
