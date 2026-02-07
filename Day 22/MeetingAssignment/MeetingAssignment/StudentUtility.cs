using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace MeetingAssignment
{


    //    public Dictionary<string, string> GetStudentDetails(string id)
    //Show more lines
    //Description:
    //•	If a student with the given id exists in Program.studentDetails(match against Student.Id), return a dictionary with one entry in the format:where Name and Course are concatenated using an underscore _.
    //<StudentId, Name_Course>
    //•	If not found, return an empty dictionary.





//    public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
//``
//Show more lines
//Description:
//•	If a student with the given id exists(match against Student.Id), update the student’s Marks with the given marks, and return a dictionary with one entry:
//<StudentId, UpdatedStudentObject>
//•	If not found, return an empty dictionary.


    public class StudentUtility
    {

        public Dictionary<string, string> GetStudentDetails(string ID)
        {
            Dictionary<string, string> response = new Dictionary<string, string>();

            foreach(var item in Program.studentDetails)
            {
                if(item.Value.ID == ID)
                {
                   string course = item.Value.Course;
                   string name = item.Value.Name;
                    response.Add(item.Value.ID, course + "_" + name);

                }
            }

            return response;
        }



        public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
        {
            Dictionary<string, Student> response = new Dictionary<string, Student>();

            foreach(var item in Program.studentDetails)
            {
                if (item.Value.ID == id) 
                {
                    item.Value.Marks = marks;
                    response.Add(item.Value.ID, item.Value);


                }
            }
           


            return response;
        }





    }
}
