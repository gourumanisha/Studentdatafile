using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Studentdatafile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\dasha\source\repos\Student1data.txt", FileMode.Create, FileAccess.Write);
            //creating a obj for writing
            StreamWriter writing = new StreamWriter(fs);
            //lets assign text to fieds with object
            try
            {

                writing.WriteLine("Student Details :");
                writing.WriteLine("Student Name : Aakanksha");
                writing.WriteLine("Student Id : 110");
                writing.WriteLine("Student courses :  java,python");
                writing.WriteLine("Student grade : A+  ");
                writing.WriteLine("Student marks :  98/100,98/100");
                writing.WriteLine("Student City : Jangaon");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //flush means the buffer data if anything is remaining will be written to the file
                writing.Flush();
                //close and save
                writing.Close();
                writing.Dispose();
                fs.Close();
                fs.Dispose();
            }




            ////////////////////////////////////////////////////////////////////////////////
            bool ans = File.Exists(@"C:\Users\dasha\source\repos\Student1data.txt");
            if (ans == true)
            {
                //this try catch block used to if there any exceptions catch block executed otherwise try executed
                try
                {
                    //this command used to open the file and read it ... 
                    FileStream ds = new FileStream(@"C:\Users\dasha\source\repos\Student1data.txt", FileMode.Open, FileAccess.Read);
                    StreamReader reading = null;
                    //this try catch block used to if there any exceptions catch block executed otherwise try executed
                    try
                    {
                        //Retrieve the data from the file to readme string ..and print it in console..
                        reading = new StreamReader(ds);
                        string readme = reading.ReadToEnd();
                        Console.WriteLine(readme);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        ds.Close();
                        ds.Dispose();
                        reading.Close();
                        reading.Dispose();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                Console.WriteLine("File does'nt exist on the given location");

            }


            Console.Read();


        }


    }
}
        