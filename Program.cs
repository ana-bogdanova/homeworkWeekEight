using System;

class Program
{
    static void Main()
    {
        Student studentOne = new Student()
        {
            Name = "Alice",
            GradeWeek1 = 9,
            GradeWeek2 = 8,
            GradeWeek3 = 9,
            GradeWeek4 = 7,
            GradeWeek5 = 10
        };
        
        Student studentTwo = new Student()
        {
            Name = "Bob",
            GradeWeek1 = 2,
            GradeWeek2 = 0,
            GradeWeek3 = 4,
            GradeWeek4 = 6,
            GradeWeek5 = 17
        };

        studentOne.MissedAndLowGrades();
        Console.WriteLine($"Average grade for {studentOne.Name}: {studentOne.AverageStudentGrade()}");

        studentTwo.MissedAndLowGrades();
        Console.WriteLine($"Average grade for {studentTwo.Name}: {studentTwo.AverageStudentGrade()}");



    }
}


class Student
{
    public string Name { get; set; }
    public int GradeWeek1 { get; set; }
    public int GradeWeek2 { get; set; }
    public int GradeWeek3 { get; set; }
    public int GradeWeek4 { get; set; }
    public int GradeWeek5 { get; set; }

    private int[] GetGradesArray()
    {
        return new int[] { GradeWeek1, GradeWeek2, GradeWeek3, GradeWeek4, GradeWeek5 };
    }

   public void MissedAndLowGrades()
    {
        int[] grades = GetGradesArray();
        for (int i = 0; i < grades.Length; i++)
        {
            int weekNumber = i + 1;

            if (grades[i] == 0)
            {
                Console.WriteLine($"Missed lesson on week {weekNumber}");
            }
            else if (grades[i] < 5)
            {
                Console.WriteLine($"Lesson grade on week {weekNumber} has a low grade of {grades[i]}");
            }
        }
    }

    public int AverageStudentGrade()
    {
        int sum = 0;
        int[] grades = GetGradesArray();
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        return sum / grades.Length;
    }

}
