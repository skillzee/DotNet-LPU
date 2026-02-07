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
            string conStr = "Data Source=.\\sqlexpress;Initial Catalog=LPU_Db;Integrated Security=True;Trust Server Certificate=True"; // old version mein integrated security = true kaam nhi krta usmein ssip kaam ata hai
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\sqlexpress;Integrated Security=True;Database=LPU_DB;TrustServerCertificate=True;";
        }


        public List<Student> ShowAllStudents()
        {
            List<Student> studList = null;
            //Code for connected Architecture below

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;



                //Holding data via reader
                sdr = cmd.ExecuteReader();
                DataTable myDt = new DataTable();
                myDt.Load(sdr);
                if (myDt.Rows.Count > 0)
                {
                    studList = new List<Student>();
                }

                //Convert Table into list
                foreach (DataRow dataRow in myDt.Rows)
                {
                    Student student = new Student()
                    {
                        RollNo = Convert.ToInt32(dataRow[0].ToString()),
                        Name = dataRow[1].ToString(),
                        Address = dataRow[3].ToString(),
                        PhoneNo = dataRow[5].ToString(),
                    };

                    if (student != null)
                    {
                        studList.Add(student);
                    }
                }




            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }

            return studList;
        }



        public List<Student> SearchByName(string Name)
        {
            List<Student> studList = null;
            SqlParameter param1 = new SqlParameter("@Name", Name);
            //Code for connected Architecture below

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo where Name=@Name";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                //Param is to be added to command
                cmd.Parameters.Add(param1);


                //Holding data via reader
                sdr = cmd.ExecuteReader();
                DataTable myDt = new DataTable();
                myDt.Load(sdr);
                if (myDt.Rows.Count > 0)
                {
                    studList = new List<Student>();
                }

                //Convert Table into list
                foreach (DataRow dataRow in myDt.Rows)
                {
                    Student student = new Student()
                    {
                        RollNo = Convert.ToInt32(dataRow[0].ToString()),
                        Name = dataRow[1].ToString(),
                        Address = dataRow[3].ToString(),
                        PhoneNo = dataRow[5].ToString(),
                    };

                    if (student != null)
                    {
                        studList.Add(student);
                    }
                }




            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }

            return studList;
        }


        public Student SearchByID(int ID)
        {
            Student student = null;


            return student;

        }


        public bool AddStudent(Student student)
        {
            bool flag = false;
            SqlParameter[] param = new SqlParameter[5];
            for (int i = 0; i < param.Length; i++)
            {
                {
                    param[i] = new SqlParameter();


                }
                param[0].ParameterName = "@RollNo";
                param[0].Value = student.RollNo;

                param[1].ParameterName = "@Name";
                param[1].Value = student.Name;


                param[0].ParameterName = "@Age";
                param[0].Value = student.Age;

                param[0].ParameterName = "@Addr";
                param[0].Value = student.Address;

                param[4].ParameterName = "@Phone";
                param[4].Value = student.PhoneNo;



                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Insert into StudentInfo(RollNo, Name, Age,LocalAddr, PerAddress,PhoneNo ) values(@RollNo, @Name, @Age,@Addr, @Addr, @Phone)";

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
            

                cmd.Parameters.AddRange(param);

                int rowCount = cmd.ExecuteNonQuery();

                if(rowCount > 0 )
                
                {
                    flag = true;
                }

                return flag;

            }



        }
    }
}
