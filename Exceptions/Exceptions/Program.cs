using System.Runtime.CompilerServices;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* try
            {
                //codul care poate genera o exceptie
            }
            catch (ArgumentNullException ane)
            {

            }
            finally
            {

            }
            //using (database connection)
            //{

            //}
            */


            readFromFile("myfile.txt");
            try
            {
                
                readFromFile2("myfile.txt");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        static void readFromFile(string fileName)
        {
            var reader = new StreamReader(fileName);
            try
            {
                
                string line = reader.ReadLine();


                //throw new IOException(line);
                Console.WriteLine(line);
                
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine($"File {fileName} not exist");
                Console.WriteLine(fnfe.Message);
                Console.WriteLine(fnfe.StackTrace);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }
            finally
            {
                reader.Close();
            }
            static void readFile(string filename)
            {
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            //without cath ex 
            }
        static void readFromFile2(string fileName)
        {
            //check if file exist

            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File {fileName}");
                return;
            }

            var reader = new StreamReader(fileName);
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    reader.Close();
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                    
                    
                }
            }
        }
    }
}
