using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Threading;

namespace ConsoleApplication155
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo = AppDomain.CurrentDomain.BaseDirectory;
            FileInfo file=new FileInfo(demo+"\\MyFile.txt");
            FileStream fs = file.Open(FileMode.OpenOrCreate,FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs);
            BinaryWriter bw = new BinaryWriter(fs);
            if (file.Length==0)
            {
                bw.Write(0); 
            }
            while (true)
            {
                fs.Seek(0, SeekOrigin.Begin);
                int a = br.ReadInt32();
                Thread.Sleep(1000);
                fs.Seek(0, SeekOrigin.Begin);
                Console.WriteLine(a);
                bw.Write(a + 1);
            }

        }
    }
}
