using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparing
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            //Введите путь к файлу с введенной информацией
            string path = @".\enterInfo.txt";
            FileReader fileReader = new FileReader();
            List<string[]> strings = fileReader.FileRead(path);
            
            Console.ReadLine();
        }
    }
}
