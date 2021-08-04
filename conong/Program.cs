using System;
using System.Collections.Generic;

namespace conong
{
    class Program
    {
        static void Main(string[] args)
        {


            int luaChon;
            List<conong> ListConOng = new List<conong>();
            do
            {
                Console.WriteLine("---- MENU -----");
                Console.WriteLine("\t1: Tao con ong");
                Console.WriteLine("\t2: Tan cong");
                Console.WriteLine("\t3: Danh sachh");
               
                luaChon = int.Parse(Console.ReadLine());
                

                switch (luaChon)
                {
                    case 1:
                        ListConOng = new List<conong>();
                        for (int j = 1; j <= 30; j++)
                        {
                            conong cg = new conong("OngChua", 100);
                            ListConOng.Add(cg);
                        }
                        for (int j = 1; j <= 30; j++)
                        {
                            conong cg = new conong("OngDuc", 100);
                            ListConOng.Add(cg);
                        }
                        for (int j = 1; j <= 30; j++)
                        {
                            conong cg = new conong("OngTho", 100);
                            ListConOng.Add(cg);
                        }
                        break;
                  
                    case 2:
                        Random c = new Random();
                        for (int j = 0; j < 90 ; j++)
                        {
                            ListConOng[j].Mau =ListConOng[j].Mau-c.Next(80);
                        }
                        break;

                    case 3:
                        for (int j = 0; j < 90; j++)
                        {
                                Console.WriteLine(j.ToString() + " " + ListConOng[j]);
                        }

                        break;
                    case 0:
                        break;
                }
            } while (luaChon != 4);
        }

    }
   
}
