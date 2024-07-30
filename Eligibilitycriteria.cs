using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Eligibilitycriteria
    {
        public void Studentcriteria()
        {

            {
                // Input the marks obtained in each subject
                Console.Write("Input the marks obtained in Physics: ");
                int marksPhysics = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input the marks obtained in Chemistry: ");
                int marksChemistry = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input the marks obtained in Mathematics: ");
                int marksMathematics = Convert.ToInt32(Console.ReadLine());

                // Calculate total marks in all three subjects
                int totalMarksAllSubjects = marksPhysics + marksChemistry + marksMathematics;

                // Calculate total marks in Mathematics and Physics
                int totalMarksMathPhysics = marksMathematics + marksPhysics;

                // Check eligibility based on the criteria
                if ((marksMathematics >= 65 && marksPhysics >= 55 && marksChemistry >= 50 && totalMarksAllSubjects >= 180) ||
                    (totalMarksMathPhysics >= 140))
                {
                    Console.WriteLine("The candidate is eligible for admission.");
                }
                else
                {
                    Console.WriteLine("The candidate is not eligible for admission.");
                }
            }
        }
    }
}

