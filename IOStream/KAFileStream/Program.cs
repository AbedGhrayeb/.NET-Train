using System;
using System.IO;

namespace KAFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example01();
            //Example02();
            //Example03();
            Example04();
            Console.ReadKey();
        }

        static void Example01(){
            // var path="c:\\users\\abedg\\downloads\\response.json";
            var path=@"c:\users\abedg\downloads\test.txt";

            using (var fs=new FileStream(path,FileMode.Open,FileAccess.ReadWrite))
            {
                Console.WriteLine($"length: {fs.Length}");
                Console.WriteLine($"can read: {fs.CanRead}");
                Console.WriteLine($"can write: {fs.CanWrite}");
                Console.WriteLine($"can seek: {fs.CanSeek}");
                Console.WriteLine($"can can timeout: {fs.CanTimeout}");
                Console.WriteLine($"can position: {fs.Position}");
                for (byte i = 65; i < 123; i++)
                {
                    fs.WriteByte(i);
                }
                Console.WriteLine($"can position: {fs.Position}");

            }
        }

         static void Example02(){
            // var path="c:\\users\\abedg\\downloads\\response.json";
            var path=@"c:\users\abedg\downloads\test.txt";

            using (var fs=new FileStream(path,FileMode.Open,FileAccess.ReadWrite))
            {
              byte[] data= new byte[fs.Length];
              int numBytesToRead=(int)fs.Length;
              int numBytesReaded=0;
              while(numBytesToRead>0)
            {
                int n= fs.Read(data,numBytesReaded,numBytesToRead);
                if(n==0)break;
                numBytesToRead-=n;
                numBytesReaded+=n;
            }
            foreach (var b in data)
            {
                Console.WriteLine(b);
            }
            }
         }
        
    
        static void Example03()
        {
            var path=@"c:\users\abedg\downloads\test3.txt";

            using (var fs=new FileStream(path,FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                fs.Seek(20,SeekOrigin.Begin);
                fs.WriteByte(65);
                fs.Position=0;
                for (int i = 0; i < fs.Length; i++)
                {
                    Console.WriteLine(fs.ReadByte());
                }
            }

        }
            static void Example04()
        {
            var path=@"c:\users\abedg\downloads\test4.txt";

            using (var sw=new StreamWriter(path))
            {
                sw.WriteLine("C#");
                sw.WriteLine("C#");
                sw.WriteLine("C#");

            }

        }
    }
    

    
}
