namespace Session04
{
    internal class ex_5
    {
        public void revarrays_1(int[] Array5)
        {
            int n = Array5.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (Array5[j] > Array5[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = Array5[j];
                        Array5[j] = Array5[j + 1];
                        Array5[j + 1] = temp;

                       

                    }

         Console.WriteLine(Array5);
        }
        //public void printArray(int[] Array5)
        //{
        //    int n = Array5.Length;
        //    for (int i = 0; i < n; ++i)
        //        Console.Write("1st way: {Array5[i]} +  ");
        //    Console.WriteLine();
        //}

        //2nd way:
        public void revarrays_2(int[] Array5)
        {

            Array.Sort(Array5);
            for (int i = 0; i < Array5.Length; i++)
            {
                Console.WriteLine("2n way: array5[{0} ] = {1}", i, Array5[i]);

            }
        }
            
        //logo eleipsis xronou egrapsa ayto, to brika sto internet

     }


}
