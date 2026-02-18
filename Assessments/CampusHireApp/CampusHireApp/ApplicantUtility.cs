using CampusHireApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//The CampusHire team should be able to add new applicant records into the system.
//2. All applicant records must be stored in a collection during runtime.
//3. Applicant data must be persisted into a file using serialization so that data is retained between executions.
//4. The system should provide functionality to:
//   -Display all applicant details
//   - Search for an applicant using Applicant ID
//   -Update applicant details
//   -Delete applicant records


namespace CampusHireApp
{
    public class ApplicantUtility
    {

        List<Applicant> applicantList;

        public ApplicantUtility()
        {
            applicantList = new List<Applicant>();
        }

        public void AddApplicant(Applicant applicant)
        { 
            applicantList.Add(applicant);
        }

        public void DisplayAllApplicants()
        {
            foreach (var applicant in applicantList)
            {
                Console.WriteLine($"Applicant Name:-> {applicant.ApplicantName}");
            }
        }

        public Applicant SearchForAnApplicant(string applicantId)
        {
            var applicant = applicantList.FirstOrDefault(item=> item.ApplicantId == applicantId);
            return applicant;
        }


        public bool UpdateApplicantDetails(string applicantId, string updatedPreferredLocation, string updatedCoreCompentency)
        {

            var applicant = applicantList.FirstOrDefault(item => item.ApplicantId == applicantId);

            if (applicant == null)
                return false;

            applicant.PrefferedJobLocation = updatedPreferredLocation;
            applicant.CoreCompentency = updatedCoreCompentency;

            return true;

        }

        public bool DeleteApplicant(string applicantId)
        {
            var applicant = applicantList.FirstOrDefault(item=>item.ApplicantId == applicantId);


            if (applicant == null)
                return false;

            return applicantList.Remove(applicant);


        }




    }
}
