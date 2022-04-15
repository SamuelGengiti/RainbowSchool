using System;
using System.IO;
using System.Text;

namespace RainbowSchool
{
    class Student
    {
        static void Main(string[] args)
        {

            using (FileStream fileStream = new FileStream("C:\\Users\\samuel_gengiti\\Documents\\FSDTraining\\Practice\\RainbowSchool\\RainbowSchool\\Data\\Student.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine("Student Id : 45678");
                    streamWriter.WriteLine("Student Name : John Smith");
                    streamWriter.WriteLine("Student Class : 8th");
                    streamWriter.WriteLine("Student Section: B-Section");

                    Console.WriteLine("Content Written to the file successfully");


                }



            }        

           
            
            
            
            
            
            //byte[] bdata = Encoding.Default.GetBytes("Student Id : 817330");
            //fileStream.Write(bdata, 0, bdata.Length);
            //Console.WriteLine("Entered Student Id");

            //byte[] bdata1 = Encoding.Default.GetBytes("Student Name : John Smith");
            //fileStream.Write(bdata, 0, bdata.Length);
            //Console.WriteLine("Student Name : John Smith");

            //byte[] bdata2 = Encoding.Default.GetBytes("Student Class : 8");
            //fileStream.Write(bdata, 0, bdata.Length);
            //Console.WriteLine("Entered Student Class");


            //byte[] bdata3 = Encoding.Default.GetBytes("Student Section : A");
            //fileStream.Write(bdata, 0, bdata.Length);
            //Console.WriteLine("Entered Student Section");

            //StreamReader streamReader = new StreamReader(fileStream);
            //var data = streamReader.ReadToEnd();



            //fileStream.Close();

            //Console.ReadKey();

            //Console.WriteLine("Student File Created Successfully.");
            //

            //

            //int studentId;
            //string studentName;
            //int studentClass;
            //string studentSection;

            //Console.Write("Enter Student Id : ");
            //studentId = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Student Name : ");
            //studentName = Console.ReadLine();

            //Console.Write("Enter Student Class : ");
            //studentClass = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Student Section : ");
            //studentSection = Console.ReadLine();



            //Console.WriteLine("**************************");

            //Console.WriteLine();

            //Console.WriteLine("Student Id : " + studentId);
            //Console.WriteLine("Student Name : " + studentName);
            //Console.WriteLine("Student Class : " + studentClass);
            //Console.WriteLine("Student Section : " + studentSection);
        }
    }
}
