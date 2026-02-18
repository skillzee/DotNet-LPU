using CampusHireApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Applicant ID(Example: CH123456)  
//• Applicant Name  
//• Current Location (Mumbai / Pune / Chennai – select any one)  
//• Preferred Job Location (Mumbai / Pune / Chennai / Delhi / Kolkata / Bangalore – select any one)  
//• Core Competency (.NET / JAVA / ORACLE / Testing)  
//• Passing Year (Degree completion year)


namespace CampusHireApp
{
    public class Applicant
    {
        public string ApplicantId {  get; set; }
        public string ApplicantName { get; set; }
        public string CurrentLocation { get; set; }
        public string PrefferedJobLocation { get; set; }
        public string CoreCompentency { get; set; }
        public string PassingYear { get; set; }



    }
}
