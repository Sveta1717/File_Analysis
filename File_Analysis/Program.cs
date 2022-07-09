using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {           
        string[] files = Directory.GetFiles(@"D:\\Документи", "*", SearchOption.AllDirectories);
          
            var extension = files.GroupBy(Path.GetExtension).OrderBy(g => g.Count());
            foreach (var group in extension)
            {
                Console.WriteLine("файлов с расширением {0} - {1} штук ", group.Key, group.Count());               
            }       
        }
    }
}

