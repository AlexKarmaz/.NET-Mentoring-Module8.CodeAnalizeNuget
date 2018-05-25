using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.NugetPackage
{
    public static class IntConverter
    {
        public static int MultiplByTen (this int x)
        {
            if( x < int.MaxValue / 10)
            {
                return x * 10;
            }

            return x;
        }
    }
}
