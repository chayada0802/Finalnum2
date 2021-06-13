using System;

namespace final2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            float[] num = new float[size];
            for (int i = 0; i < size; i++)
            { num[i] = float.Parse(Console.ReadLine()); }
            for (int i = size - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    SwapIfHigher(ref num[j], ref num[j + 1]);
                }
            }
            Console.Write("Ant’s Sort");
            for (int i = 0; i < size; i++)
            { Console.Write("{0} ", num[i]); }




            for (int i = size - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    SwapIFlower(ref num[j], ref num[j + 1]);
                }
            }
            Console.Write("\nunAnt’s Sort");
            for (int i = 0; i < size; i++)
            { Console.Write("{0} ", num[i]); }



            Console.Write("\nPOPOAnt’s Sort");
            if (size % 2 == 0)
            {

                for (int i = size - 1; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        SwapIFlower(ref num[j], ref num[j + 1]);
                    }
                }
                int sizo = (size / 2);
                for (int i = 0; i < sizo; i++)
                { Console.Write("{0} ", num[i]); }


                for (int i = size - 1; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        SwapIfHigher(ref num[j], ref num[j + 1]);
                    }
                }

                for (int i = 0; i < sizo; i++)
                { Console.Write("{0} ", num[i]); }

            }


            if (size % 2 == 1)
            {
                for (int i = size - 1; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        SwapIFlower(ref num[j], ref num[j + 1]);
                    }
                }
                int sizee = (size / 2);
                int sizeee = (size / 2) + 1;
                for (int i = 0; i < sizee; i++)
                { Console.Write("{0} ", num[i]); }


                for (int i = size - 1; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        SwapIfHigher(ref num[j], ref num[j + 1]);
                    }
                }

                for (int i = 0; i < sizeee; i++)
                { Console.Write("{0} ", num[i]); }


                Console.Write("\nUNNPOPOAnt’s Sort");
                if (size % 2 == 0)
                {

                    int sizo = (size / 2);

                    for (int i = size - 1; i > 0; i--)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            SwapIfHigher(ref num[j], ref num[j + 1]);
                        }
                    }

                    for (int i = 0; i < sizo; i++)
                    { Console.Write("{0} ", num[i]); }
                    for (int i = size - 1; i > 0; i--)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            SwapIFlower(ref num[j], ref num[j + 1]);
                        }
                    }

                    for (int i = 0; i < sizo; i++)
                    { Console.Write("{0} ", num[i]); }
                }



                if (size % 2 == 1)
                {
                    sizee = (size / 2);
                    sizeee = (size / 2) + 1;
                    for (int i = size - 1; i > 0; i--)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            SwapIfHigher(ref num[j], ref num[j + 1]);
                        }
                    }

                    for (int i = 0; i < sizeee; i++)
                    { Console.Write("{0} ", num[i]); }

                    for (int i = size - 1; i > 0; i--)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            SwapIFlower(ref num[j], ref num[j + 1]);
                        }





                    }

                    for (int i = 0; i < sizee; i++)
                    { Console.Write("{0} ", num[i]); }
                }









            }


            static void Swap(ref float a, ref float b)
            {
                float tmp = a;
                a = b;
                b = tmp;
            }
            static void SwapIfHigher(ref float a, ref float b)
            {
                if (a > b)
                {
                    Swap(ref a, ref b);
                }
            }
            static void SwapIFlower(ref float a, ref float b)
            {
                if (a < b)
                {
                    Swap(ref a, ref b);
                }
            }


        }
    }
}
