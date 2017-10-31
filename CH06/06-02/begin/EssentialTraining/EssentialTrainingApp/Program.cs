using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> Words;
        static void Main(string[] args)
        {
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProblem();
            ReadTextFile();
            Console.ReadLine();
        }

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
        }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Couldn't find the directory.");
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Couldn't find the file.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An unknown error occured " + ex.Message);
            }
            finally
            {
                Console.WriteLine("The finally runs all the time");
            }
}

        private static int CrazyMathProblem()
        {
            var income = 1000;
            for(var i = 10; i > 0; i--)
            {
                income = income = (income / i);
            }

            return income;
        }
    }
}
