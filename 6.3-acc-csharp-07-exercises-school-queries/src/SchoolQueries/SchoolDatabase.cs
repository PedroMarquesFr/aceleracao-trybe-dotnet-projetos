namespace SchoolQueries;

public class SchoolDatabase : ISchoolDatabase
{
    public Student[] Students { get; set; }
    public Project[] Projects { get; set; }
    public ProjectGrade[] ProjectGrades { get; set; }

    public Student[] GetStudentsByName(string name)
    {
        var filteredStudents = from student in Students
                               where student.Name == name
                               select student;
        return filteredStudents.ToArray();
    }

    public Student[] GetStudentsWithAverageGradeInProjectAbove(int gradeInput)
    {
        var filteredStudents = from student in Students
                               join projectGrade in ProjectGrades on student.Id equals projectGrade.StudentId
                               where projectGrade.Grades?.Average() > gradeInput
                               select student;
        return filteredStudents.ToArray();
    }

    public Project[] GetProjectsWithMinimumGradeInProjectBelow(int gradeInput)
    {
        var filteredProjects = from project in Projects
                               join projectGrade in ProjectGrades on project.Id equals projectGrade.ProjectId
                               where projectGrade.Grades?.Min() < gradeInput
                               select project;
        return filteredProjects.ToArray();
    }

    public Student[] GetStudentsDoneProject(string projectName)
    {
        var filteredStudents = from project in Projects
                               join projectGrade in ProjectGrades on project.Id equals projectGrade.ProjectId
                               join student in Students on projectGrade.StudentId equals student.Id
                               where project.Name == projectName
                               select student;
        return filteredStudents.ToArray();
    }
}
