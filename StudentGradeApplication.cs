using System;
namespace StudentGradeApplication
{
    class frmStudentGradeProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>Student Grade Average<<<<");

            Console.Write("\nName: ");
            var name = Console.ReadLine();

            Console.WriteLine("\n\t\t>>Grades<<");
            Console.Write("English: \t   ");
            double englishGrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mathematics: \t   ");
            double mathGrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Science: \t   ");
            double scienceGrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Filipino: \t   ");
            double filipinoGrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("History: \t   ");
            double historyGrade = Convert.ToDouble(Console.ReadLine());

            double sumOfGrade = englishGrade + mathGrade + scienceGrade + filipinoGrade + historyGrade; // sum up all the grades
            double average = sumOfGrade / 5; // computes the average grade of 5 subjects
            
            Console.WriteLine("\n[Press enter to generate average]");
            var generateAve = Console.ReadLine();

            if (average >= 75 && average <= 100) // print the statements below if  student passed
            {
                Console.WriteLine("Congratulations! " + name + ". \nYou got a passing grade."); //smile for pass
                Console.WriteLine("\nThe general average of " + name + " is \n\t\t" + "<: " + Math.Round(average, 2) + " :>"); //round off to 2 decimal places
            }
            else if (average < 75 && average >= 0) // print the statements below if  student failed
            {
                Console.WriteLine("I'm sorry " + name + ". \nYou got a failing grade."); //sad for fail
                Console.WriteLine("\nThe general average of " + name + " is \n\t\t" + ":< " + Math.Round(average, 2) + " >:");  //round off to 2 decimal places
            }
            else if (average > 100 || average < 0) // out of range
            {
                Console.WriteLine("Grades out of range.");
            }
            else
            {
                Console.WriteLine("Invalid input."); // invalid input such as string
            }

        }
    }
}// made by Jauary Toribio Jr