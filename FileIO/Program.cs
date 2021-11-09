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
            Console.WriteLine("===============Read All Bytes==============");


            Console.WriteLine(File.ReadAllText(path));
           
            Console.WriteLine("===============Read All Lines==============");

            string[] newData = File.ReadAllLines(path);
            for (int i = 0; i < newData.Length; i++)
            {
                Console.WriteLine($"Number {i} item is {newData[i]}");
            }

            Console.WriteLine("===============Read All Bytes=============="  );
            byte[] newData2 = File.ReadAllBytes(path);
            for (int i = 0; i < newData2.Length; i++)
            {
                Console.WriteLine($"Number {i} item is {newData2[i]}");
            }

            Console.WriteLine("=============== Writing using File IO ==============");
            Console.WriteLine("=============== Writing All Text ==============");


            string path1 = @"C:\Users\HP\Desktop\TestWriteAll.txt";
            string path2 = @"C:\Users\HP\Desktop\TestWriteLine.txt";
            string data1 = "I am writing using WriteAllData";
            string data1Append = "It is awesome to use";
            string[] data2 = { "Can u see the wonders of WriteLine", "it Only works with array" };
            string[] data2Append = { "Am using AppendLine to add extra string to the  Array.", "This is Awesome" };
            
            File.WriteAllText(path1, data1);
            File.WriteAllLines(path2, data2);

            Console.WriteLine("=============== Writing All Text ==============");

            File.AppendAllText(path1, data1Append);
            File.AppendAllLines(path2, data2Append);






        }

    }
}
