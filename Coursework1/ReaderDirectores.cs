using System;
using System.Linq;
using System.IO;


namespace Coursework1
{
    public class ReaderDirectores: IDisposable
    {
        private const string StorageFile = "FileInfo.txt";
        private readonly StreamReader _stream;
        public int StorageFilesCount;
        public int StorageFilesProcessedCount = -1;

        public ReaderDirectores(string directory)
        {
            var path = Path.Combine(directory, StorageFile);
            var fileNames = Directory.GetFiles(directory, "*.txt", SearchOption.AllDirectories)
                .Where(x => !x.EndsWith(StorageFile)).ToArray();
            File.WriteAllLines(path, fileNames); //Записывает в FileInfo.txt пути всех файлов
            StorageFilesCount = fileNames.Length;

            _stream = File.OpenText(path);
        }

        public string GetNextSourceFile()
        {
            StorageFilesProcessedCount++;
            return _stream.EndOfStream ? null : _stream.ReadLine();
        }

        public void Dispose()
        {
            _stream?.Close();
        }

        public void Clean()
        {
            _stream?.Close();
        }
    }
}
