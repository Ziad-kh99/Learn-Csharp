# Student Grading Application.

## Project overview
- You're developing a Student Grading application that automates the calculation of grades for each student in a class. 
- Suppose you are a teacher's assistant at a school. You're tasked with developing an application that automates student grading. 
- The application uses all of the scored assignments for each student to calculate their current overall grade/score for the class. 
- The teacher has also provided a required format for reporting the student grades.

### Version 1:
#### Requirements:
- Your application needs to declares variables used to define student names and individual exam scores for each student.
- Your application needs to includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
- Your application needs to includes a hard coded letter grade that the developer must apply manually.
- Your application needs to includes Console.WriteLine() statements to display the student grading report.
- Your application needs to includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
- Your application needs to includes a hard coded letter grade that the developer must apply manually.
- Your application needs to includes Console.WriteLine() statements to display the student grading report.

#### Objectives:
- Create a C# console application.
- Declare and assign values to variables.
- Perform various numeric calculations.
- Use "character escape sequences" that will help format your results.
- Use `Console.WriteLine()` to display the results.


### Version 2:
#### Requirements:
- Start with four students. Each student has five exam scores.
- Each exam score is an integer value, 0-100, where 100 represents 100% correct.
- A student's overall exam score is the average of their five exam scores.
- Your application needs to automatically assign letter grades based on the calculated final score for each student.
- Your application needs to output/display each student’s name and formatted grade.
- Your application needs to support adding other students and scores with minimal impact to the code.
- Your application needs to accommodate extra credit assignments.
    - Extra credit scores must be included in the student's scores array.
    - Extra credit assignments will be worth 10% of an exam score when applied toward the final numeric grade.
    - Extra credit assignment scores must be added to the student's total exam score before calculating the final numeric grade.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - Your code must detect extra credit assignments based on the number of elements in the student's scores array.
    - Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

#### Objectives:
- Use arrays to store student names and assignment scores.
- Use a foreach statement to iterate through the student names as an outer program loop.
- Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.
- Use an updated algorithm within the outer loop to calculate the average exam score for each student.
- Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.




