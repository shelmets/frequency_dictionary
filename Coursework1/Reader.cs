using System;
using System.IO;
using System.Threading.Tasks;

namespace Coursework1
{
    public class Reader: IDisposable
    {
        private readonly ReaderDirectores directores;
        private StreamReader stream;
        public int StorageFilesCount => directores.StorageFilesCount;
        public int StorageFilesProcessedCount => directores.StorageFilesProcessedCount;
        public Reader(string directory) { directores = new ReaderDirectores(directory); }
        private void NextSourceFileOpenStream()
        {
            var nextfile = directores.GetNextSourceFile();
            if (nextfile != null)
            {
                stream = new StreamReader(nextfile, System.Text.Encoding.Default);
            }
            else
            {
                stream = null;
            }
        }
        public void ToTree(SuffixTree tree)
        {
            while (true)
            {
                NextSourceFileOpenStream(); //Открываем поток на следующий исходный файл
                if (stream == null)
                {
                    break; //Если файлов больше нет - работа закончена
                }

                while (!stream.EndOfStream)
                {
                    var line = stream.ReadLine();

                    //Если строка не пустая, то читаем следующую строку
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    tree.AddLine(line);
                }
            }
        }
        public void Dispose()
        {
            stream?.Close();
        }
        public void Clean()
        {
            stream?.Close();
            directores?.Clean();
        }
    }
}
