using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    internal class ex_4
    {
        public void MultArrays(int[] Array1, int[] Array2)
        {
            

            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = 0; j < Array2.Length; j++)
                {
                    Console.WriteLine(Array1[i] * Array2[j]);

                }

            }
        }
    }
  




    
}
