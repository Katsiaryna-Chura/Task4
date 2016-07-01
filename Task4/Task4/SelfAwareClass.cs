using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class SelfAwareClass
    {
        private static int numberOfCopies = 0;

        public static int NumberOfCopies
        {
            get
            {
                return numberOfCopies;
            }
        }

        public SelfAwareClass()
        {
            numberOfCopies++;
        }

        //~SelfAware()
        //{
        //    numberOfCopies--;
        //}
    }

}
