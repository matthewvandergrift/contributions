using System.IO;

namespace Matthew.Vandergrift.Technical.Screening.Areas.Delegates
{
    public class FileLogger
    {
        readonly FileStream _fileStream;
        readonly StreamWriter _streamWriter;

        // Constructor
        public FileLogger(string filename)
        {
            _fileStream = new FileStream(filename, FileMode.Create);
            _streamWriter = new StreamWriter(_fileStream);
        }

        // Member Function which is used in the Delegate
        public void Logger(string s)
        {
            _streamWriter.WriteLine(s);
        }

        public void Close()
        {
            _streamWriter.Close();
            _fileStream.Close();
        }
    }
}