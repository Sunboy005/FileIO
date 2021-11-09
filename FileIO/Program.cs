using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("----------Starts-----------------------");
            //    string path = "/Users/hp/Desktop/text.txt";
            //    var f = new FileInfo(path);

            //    try
            //    {
            //        using (StreamWriter sw = new StreamWriter(f.Open(FileMode.Append)))
            //        {
            //            var arr1 = new int[] { 1, 2, 3, 4, 5 };
            //            foreach (var item in arr1)
            //            {
            //                sw.WriteLine(item);
            //            }
            //            Console.WriteLine("----------Finished-----------------------");

            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine("Error Message:", ex.Message);
            //    }


            //    try
            //    {
            //        using (StreamReader sr = new StreamReader(f.OpenRead())) {
            //            var rs = sr.ReadToEnd();
            //            Console.WriteLine(sr);
            //            Console.WriteLine("-------------------Reading----------------------");
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine("Error Message:", ex.Message);
            //    }
            //    Console.WriteLine("Hello World!");
            //}
            string path = @"C:\Users\HP\Desktop\trial.txt";
            //Console.WriteLine(File.ReadAllText(path);
            string[] newData = File.ReadAllLines(path);
            for (int i = 0; i < newData.Length; i++)
            {
                Console.WriteLine($"Number {i} item is {newData[i]}");
            }

            Console.WriteLine("===================================="  );
            byte[] newData2 = File.ReadAllBytes(path);
            for (int i = 0; i < newData2.Length; i++)
            {
                Console.WriteLine($"Number {i} item is {newData[i]}");
            }



        }

    }
}
