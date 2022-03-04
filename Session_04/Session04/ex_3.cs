using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    internal class ex_3
    {
        public void GetPrimeNumbers(int num)
        {
                      
            for (int i = 2; i <= num; i++)
            {
                if (i % num != 0 )
                    
                    Console.WriteLine(i);
                
            }
        }
    }
}
