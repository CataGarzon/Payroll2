using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace payroll2
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Program program = new Program();
            Data data = new Data();

            try
            {
                
                Console.WriteLine("Welcom the payroll");
                Console.WriteLine("Insert document:");
                data.Document1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Insert first name: ");
                data.FristName1 = Console.ReadLine();
                Console.WriteLine("Insert last name: ");
                data.LastName1 = Console.ReadLine();
                Console.WriteLine("Insert salary :");
                data.Salary1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Insert Worked Days");
                data.WorkedDay1 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Dato invalido");
                Console.ReadKey();
            }

            

            data.TotalIcome1 = data.Salary1 * data.WorkedDay1 / 30;
            data.Healthe = data.TotalIcome1 * 0.04;
            data.Pension = data.TotalIcome1 * 0.04;
            data.Transport = 117_172 / 30;
            data.Transport = data.Transport * data.WorkedDay1;
            if (data.Salary1 <= 2000000)
            {
                data.TotalIcome1 = data.TotalIcome1 + data.Transport;
            }
            else
            {
                data.TotalIcome1 = data.TotalIcome1;
            }


            Console.WriteLine("Document :" + data.Document1);
            Console.WriteLine("frist name :" + data.FristName1);
            Console.WriteLine("last name :" + data.LastName1);
            Console.WriteLine("salary :" + data.Salary1);
            Console.WriteLine("worked days :" + data.WorkedDay1);
            if (data.Salary1 <= 2000000)
            {
                Console.WriteLine($"The Transport subsidy is :" + data.Transport);
            }
            Console.WriteLine("pension :" + data.Pension);
            Console.WriteLine("Healthe :" + data.Healthe);
            Console.WriteLine("Total icomes :" + data.TotalIcome1);



            TextWriter File = new StreamWriter("C:\\Payroll.txt");

            File.WriteLine($"\nNew Employee");
            File.WriteLine($"Document: " + data.Document1);
            File.WriteLine($"First Name: {data.FristName1}");
            File.WriteLine($"Last Name: {data.LastName1}");
            File.WriteLine("The salary is: " + data.Salary1);
            File.WriteLine($"Worked days: {data.WorkedDay1}");
            if (data.Salary1 <= 2000000)
            {
                File.WriteLine($"The Transport subsidy is : {data.Transport}");
            }
            File.WriteLine("The Total Accrued is:  " + data.TotalIcome1);
            File.WriteLine("The Health discount is: " + data.Healthe);
            File.WriteLine("The Pension discount is: " + data.Pension);


            File.Close();
        }


    }
}