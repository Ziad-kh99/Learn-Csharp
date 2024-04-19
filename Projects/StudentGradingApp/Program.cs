
#region Version 1:
/*
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;


int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;


//> Calculate Averages:
decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
decimal ZahiraScore = (decimal)zahirahSum / currentAssignments;
decimal jeongScore = (decimal)jeongSum / currentAssignments;



Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"Sophia:\t\t{sophiaScore}\tA-");
Console.WriteLine($"Nicolas:\t{nicolasScore}\tB+");
Console.WriteLine($"Zahirah:\t{ZahiraScore}\tB");
Console.WriteLine($"Jeong:\t\t{jeongScore}\tA-");
*/
#endregion


#region Version 2:

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] nicolasScores = { 92, 89, 81, 96, 90, 89 };
int[] zahirahScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] jeongScores = [90, 95, 87, 88, 96, 96];
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










#endregion

