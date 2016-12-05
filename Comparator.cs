using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace playwithcode
{
    public class Comparator
    {
        public Comparator()
        {}

        public bool compare(int a, int b)
        {
            return a == b ? true : false;
        }

        public bool compare(string a, string b)
        {
            return a.Equals(b) ? true : false;
        }

        public bool compare(int[] a, int[] b)
        {
            if (a.Count() == b.Count() && CheckComparation(a, b))
                return true;
            return false;
        }

        public bool CheckComparation(int[] a, int[] b)
        {
            bool isValid = true;
            for (int i = 0; i < a.Count(); i++)
            {
                if(a[i] < 0 && i >= Math.Abs(a[i]))
                    isValid = false;
                if (b[i] < 0 && i >= Math.Abs(b[i]))
                    isValid = false;
                if (a[i] != b[i])
                    isValid = false;
            }

            return isValid;
        }
    }
}
