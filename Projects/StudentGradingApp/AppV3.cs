namespace StudentGrading.V3;


class App
{
    public static void Run()
    {
        int currentAssignments = 5;

        int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = { 90, 95, 87, 88, 96, 96 };

        string[] studentNames = {"Sophia", "Andrew", "Emma", "Logen"};

        int[] studentScores = new int[10];
        string currentStudentLetterGrade = "";

        Console.WriteLine("Student\t\t\tExam Score\t\tOverall\t\tGrade\t\tExtra Credit");

        foreach(string currentStudent in studentNames)
        {
            if(currentStudent == "Sophia")
                studentScores = sophiaScores;

            else if(currentStudent == "Andrew")
                studentScores = andrewScores;

            else if(currentStudent == "Emma")
                studentScores = emmaScores;
            
            else if(currentStudent == "Logen")
                studentScores = loganScores;


            int examScoreSum = 0;
            int extraCreditSum = 0;
            int gradedAssignments = 1;

            foreach(int score in studentScores)
            {
                if(gradedAssignments <= currentAssignments)
                {
                    examScoreSum += score;
                }
                else
                {
                    extraCreditSum += score;
                }
                gradedAssignments++;
            }

            decimal examScore = (decimal)examScoreSum / currentAssignments;
            decimal overallScore = (decimal)(examScoreSum + extraCreditSum / 10) / currentAssignments;

            if (overallScore >= 97)
                currentStudentLetterGrade = "A+";

            else if (overallScore >= 93)
                currentStudentLetterGrade = "A";

            else if (overallScore >= 90)
                currentStudentLetterGrade = "A-";

            else if (overallScore >= 87)
                currentStudentLetterGrade = "B+";

            else if (overallScore >= 83)
                currentStudentLetterGrade = "B";

            else if (overallScore >= 80)
                currentStudentLetterGrade = "B-";

            else if (overallScore >= 77)
                currentStudentLetterGrade = "C+";

            else if (overallScore >= 73)
                currentStudentLetterGrade = "C";

            else if (overallScore >= 70)
                currentStudentLetterGrade = "C-";

            else if (overallScore >= 67)
                currentStudentLetterGrade = "D+";

            else if (overallScore >= 63)
                currentStudentLetterGrade = "D";

            else if (examScore >= 60)
                currentStudentLetterGrade = "D-";

            else
                currentStudentLetterGrade = "F";

            decimal extraCreditPoints = (decimal)(extraCreditSum/10) / currentAssignments;

            Console.WriteLine($"{currentStudent}\t\t\t{examScore}\t\t\t{overallScore}\t\t{currentStudentLetterGrade}\t\t{extraCreditSum}({extraCreditPoints} pts)");
        }
    }
}