using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusHireApp
{
    public class Program
    {


        public static bool IsValid(string applicantId)
        {
            if (applicantId.Length == 8)
            {
                if(applicantId.Substring(0,2) == "CH")
                {
                    return true;
                }

            }

            return false;

        }

        static void AddApplicant(ApplicantUtility applicantUtil)
        {
            Console.Write("Enter Applicant ID: ");
            string applicantID = Console.ReadLine();

            if (!IsValid(applicantID))
            {
                Console.WriteLine("Invalid Applicant ID. Must start with CH and be 8 characters.");
                return;
            }

            Console.Write("Enter Applicant Name: ");
            string applicantName = Console.ReadLine();

            Console.Write("Enter Current Location: ");
            string currentLocation = Console.ReadLine();

            Console.Write("Enter Preferred Job Location: ");
            string preferredJobLocation = Console.ReadLine();

            Console.Write("Enter Core Competency: ");
            string coreCompentency = Console.ReadLine();

            Console.Write("Enter Passing Year: ");
            string passingYear = Console.ReadLine();

            Applicant newApplicant = new Applicant()
            {
                ApplicantId = applicantID,
                ApplicantName = applicantName,
                CurrentLocation = currentLocation,
                PrefferedJobLocation = preferredJobLocation,
                CoreCompentency = coreCompentency,
                PassingYear = passingYear
            };

            applicantUtil.AddApplicant(newApplicant);

            Console.WriteLine("Applicant Added Successfully.");
        }


        static void Main(string[] args)
        {
            ApplicantUtility applicantUtil = new ApplicantUtility();
            int choice = 0;

            do
            {
                Console.WriteLine("\n===== Campus Hire Menu =====");
                Console.WriteLine("1. Add Applicant");
                Console.WriteLine("2. Display All Applicants");
                Console.WriteLine("3. Search Applicant");
                Console.WriteLine("4. Update Applicant");
                Console.WriteLine("5. Delete Applicant");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddApplicant(applicantUtil);
                        break;

                    case 2:
                        applicantUtil.DisplayAllApplicants();
                        break;

                    case 3:
                        Console.Write("Enter Applicant ID: ");
                        string searchId = Console.ReadLine();

                        Applicant found = applicantUtil.SearchForAnApplicant(searchId);

                        if (found != null)
                        {
                            Console.WriteLine(found.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Applicant not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Applicant ID: ");
                        string updateId = Console.ReadLine();

                        Console.Write("Enter New Preferred Location: ");
                        string newLocation = Console.ReadLine();

                        Console.Write("Enter New Core Competency: ");
                        string newSkill = Console.ReadLine();

                        bool updated = applicantUtil.UpdateApplicantDetails(updateId, newLocation, newSkill);

                        if (updated)
                        {
                            Console.WriteLine("Updated Successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Applicant not found.");
                        }
                        break;

                    case 5:
                        Console.Write("Enter Applicant ID to delete: ");
                        string deleteId = Console.ReadLine();

                        bool deleted = applicantUtil.DeleteApplicant(deleteId);

                        if (deleted)
                        {
                            Console.WriteLine("Deleted Successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Applicant not found.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 6);
        }

    }
}
