using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//For ADO .Net
using System.Data.SqlClient;
using System.Data;

namespace ConArcDemo
{
    /// <summary>
    /// Demo Code for Connected Architecture in StudentDAL Class 
    /// </summary>
    public class StudentDAL
    {

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;

        public StudentDAL()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\sqlexpress;Integrated Security=True;Database=LPU_DB;";
        }


        public List<Student> ShowAllStudents()
        {
            List<Student> studList = null;
            //Code for connected Architecture below

            return studList;
        }



        public List<Student> SearchByName(string Name)
        {
            List<Student> studList = null;

            return studList;
        }


        public Student SearchByID(int ID) {
            Student student = null;


            return student;

        }



    }
}
