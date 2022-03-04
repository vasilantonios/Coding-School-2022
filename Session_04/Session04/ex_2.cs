using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    internal class ex_2
    {
        public int GetProduct(int num)
        {

            int prod = 1;
            //int i = 1;

            for (int i = 1; i <= num; i++) 
            {
                prod = prod * i;
            }
            return prod;
        }

        public int GetSum(int num)
        {
            int sum = 0;
           

            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;

            }


            return sum;
        }






    }
}
