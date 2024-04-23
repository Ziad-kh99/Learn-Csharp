namespace StudentGrading.V2;


class App
{
    public static void Run()
    {
        int currentAssignments = 5;

        int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
        int[] nicolasScores = { 92, 89, 81, 96, 90, 89 };
        int[] zahirahScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] jeongScores = { 90, 95, 87, 88, 96, 96 };
        int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = { 90, 95, 87, 88, 96, 96 };
        int[] beckyScores = { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = { 91, 91, 91, 91, 91, 91, 91 };

        string[] studentNames = ["Sophia", "Nicolas", "Zahirah", "Jeong", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];

        int[] studentScores = new int[10];
        string currentStudentLetterGrade = "";


        Console.WriteLine("Student  \t\tGrade\n");

        foreach (string name in studentNames)
        {
            string currentStudent = name;

            if (currentStudent == "Sophia")
                studentScores = sophiaScores;


            else if (currentStudent == "Nicolas")
                studentScores = nicolasScores;


            else if (currentStudent == "Zahirah")
                studentScores = zahirahScores;


            else if (currentStudent == "Jeong")
                studentScores = jeongScores;

            else if (currentStudent == "Andrew")
                studentScores = andrewScores;

            else if (currentStudent == "Emma")
                studentScores = emmaScores;

            else if (currentStudent == "Logan")
                studentScores = loganScores;

            else if (currentStudent == "Becky")
                studentScores = beckyScores;

            else if (currentStudent == "Chris")
                studentScores = chrisScores;

            else if (currentStudent == "Eric")
                studentScores = ericScores;

            else if (currentStudent == "Gregor")
                studentScores = gregorScores;

            int studentSum = 0;
            int gradedAssignments = 1;
            foreach (int score in studentScores)
            {
                if (gradedAssignments <= currentAssignments)
                {
                    studentSum += score;
                }
                else
                {
                    studentSum += score / 10;
                }
                gradedAssignments++;
            }

            decimal currentStudentGrade = (decimal)studentSum / currentAssignments;

            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";

            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";

            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";

            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";

            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";

            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";

            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";

            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";

            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";

            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";

            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";

            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";

            else
                currentStudentLetterGrade = "F";

            Console.WriteLine($"{currentStudent}:  \t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
        }

    }
}