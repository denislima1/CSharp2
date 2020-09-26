using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePolimorfismo.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditiocionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additiocionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditiocionalCharge = additiocionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditiocionalCharge;
        }
    }
}
