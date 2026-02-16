using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LpuDbClassesDataContext dbCon = new LpuDbClassesDataContext();
            StudentInfo s1 = new StudentInfo()
            {
                RollNo = 1,
                LocalAddr = "Sarai Kham",
                PerAddress = "Sarai Kham",
                PhoneNo = "1234567890",
                SchoolName = "BenHur",
                Age = 21,
                Name = "Parth"
            };

            //Adding to the table
            dbCon.StudentInfos.InsertOnSubmit(s1);
            dbCon.SubmitChanges();


        }
    }
}
