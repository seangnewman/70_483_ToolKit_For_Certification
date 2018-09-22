using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_ComparingCars
{
    class Cars : IComparable, IComparable<Cars>
    {
        public string Name { get; set; }
        public int MaxMph { get; set; }
        public int HorsePower { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(object obj)
        {
            if(obj is Cars)
            {
                throw new ArgumentException("Object is not a Car");
            }

            Cars other = obj as Cars;

            return Name.CompareTo(other.Name);
        }

        public int CompareTo(Cars other)
        {
            return this.Name.CompareTo(other.Name);
        }

         
    }
}
