using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_ComparingCars
{
    class CarComparer : IComparer
    {
        public enum CompareField
        {
            Name, 
            MaxMph, 
            Horsepower, 
            Price
        }

        public CompareField SortBy = CompareField.Name;

        public int Compare(Cars x, Cars y)
        {
            switch (SortBy)
            {
                case CompareField.Name:
                    return x.Name.CompareTo(y.Name);
                    
                case CompareField.MaxMph:
                    return x.MaxMph.CompareTo(y.MaxMph);

                case CompareField.Horsepower:
                    return x.HorsePower.CompareTo(y.HorsePower);

                case CompareField.Price:
                    return x.Price.CompareTo(y.Price);
                
            }

            return x.Name.CompareTo(y.Name);
              


        }
    }
}
