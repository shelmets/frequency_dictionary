using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Coursework1
{
    public class Writer
    {
        private readonly string _directory;

        public Writer(string directory)
        {
            _directory = directory;
        }

        //Получает словарь и записывает его построчно в определенный файл
        public void WriteDictionary(Dictionary<string, uint> dictionary)
        {
            var text = dictionary.Select(x => $"{x.Key} {x.Value}"); //Каждая строка в новом файле запишется в виде: слово число
            File.WriteAllLines(_directory, text); //Записываем, собственно
        }
    }
}
