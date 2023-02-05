namespace LoggerClass
{
    public class WriteToFile : ILogger
    {
        public void WriteLog(string message)
        {
            string baseDir = Environment.CurrentDirectory;
            string data = DateTime.Now.ToString("G");
            File.AppendAllText(baseDir + "/Log.txt", data + ":" + message + "\r\n");
        }
    }
}