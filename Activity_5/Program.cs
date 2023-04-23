//Read and Write Text Line

namespace Activity_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            StreamReader sr = new StreamReader("C:\\Users\\KENNETH GABRIEL\\source\\repos\\StreamReader.txt");

            line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();

            StreamWriter sw = new StreamWriter("C:\\Users\\KENNETH GABRIEL\\source\\repos\\StreamReader.txt");

            sw.WriteLine("Hi World!!");
            sw.WriteLine("From Activity_5");

            sw.Close();
        }
    }
}