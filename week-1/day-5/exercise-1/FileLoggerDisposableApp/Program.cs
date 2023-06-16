namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use FileLogger and dispose of it properly
            using(FileLogger logger = new FileLogger("logs.txt"))
            {
                logger.Log("hELLO 1");
                logger.Log("hELLO 2");
                logger.Log("hELLO 3");
                logger.Log("hELLO 4");
            }
        }
    }

    class FileLogger : IDisposable
    {
        private StreamWriter _writer;

        public FileLogger(string filePath)
        {
            // Initialize StreamWriter instance
            _writer = new StreamWriter(filePath);

        }

        public void Dispose()
        {
            // Implement IDisposable pattern
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                if( _writer != null )
                {
                    _writer.Flush();
                    _writer.Close();
                    _writer.Dispose();
                }
            }
        }

        public void Log(string message)
        {
            // Write message to the file
            _writer.WriteLine(message);
        }
    }
}