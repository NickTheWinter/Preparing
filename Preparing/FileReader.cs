using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparing
{
    internal class FileReader
    {
        public List<string[]> FileRead(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            string line = streamReader.ReadLine();
            List<string[]> strings = new List<string[]>();
            while (line != null && line != "")
            {
                //Сначала ввод длины, внешний диаметр, толщина стенки
                string[] array = line.Split(';');
                strings.Add(array);
                line = streamReader.ReadLine();
            }
            return strings;
        }
    }
}
