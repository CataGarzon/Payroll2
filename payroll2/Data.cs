using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll2
{
    public class Data
    {
        private double Document;
        private string FristName;
        private string LastName;
        private double Salary;
        private double WorkedDay;
        private double transport;
        private double TotalIcome;
        private double healthe;
        private double pension;

        public Data() { }


        public double Document1 { get => Document; set => Document = value; }
        public string FristName1 { get => FristName; set => FristName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public double WorkedDay1 { get => WorkedDay; set => WorkedDay = value; }
        public double Transport { get => transport; set => transport = value; }
        public double TotalIcome1 { get => TotalIcome; set => TotalIcome = value; }
        public double Healthe { get => healthe; set => healthe = value; }
        public double Pension { get => pension; set => pension = value; }
    }
}


