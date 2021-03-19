using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLab1
{
    public class Gun
    {
        public string Name { get; set; }
        public float Caliber { get; set; }
        public double Range { get; set; }
        public Gun(string Name,float Caliber,double Range)
        {
            this.Name = Name;
            this.Caliber = Caliber;
            this.Range = Range;
        }
    }
}
