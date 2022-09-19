using SchoolQueries;

public class TestTestSchoolDatabaseData
{
    public static TheoryData<string, Student[], bool> DataTestGetStudentsByName => 
        new TheoryData<string, Student[], bool>(){
            {
                "Student 1",
                new Student[]{
                    new Student() {
                        Id = 1,
                        Name = "Student 1",
                        Age = 20,
                    },
                },
                true
            },
            {
                "Student 3",
                new Student[]{
                    new Student() {
                        Id = 3,
                        Name = "Student 3",
                        Age = 22,
                    }
                },
                true
            },
            {
                "Student 3",
                new Student[]{
                    new Student() {
                        Id = 1,
                        Name = "Student 1",
                        Age = 20,
                    }
                },
                false
            },
        };

    public static TheoryData<int, Student[], bool> DataTestGetStudentsWithAverageGradeInProjectAbove => 
        new TheoryData<int, Student[], bool>(){
            {
                89,
                new Student[]{
                    new Student() {
                        Id = 1,
                        Name = "Student 1",
                        Age = 20,
                    },
                },
                true
            },
            {
                69,
                new Student[]{
                    new Student() {
                        Id = 1,
                        Name = "Student 1",
                        Age = 20,
                    },
                    new Student() {
                        Id = 2,
                        Name = "Student 2",
                        Age = 21,
                    },
                },
                true
            },
            {
                69,
                new Student[]{
                    new Student() {
                        Id = 2,
                        Name = "Student 2",
                        Age = 21,
                    },
                    new Student() {
                        Id = 3,
                        Name = "Student 3",
                        Age = 22,
                    },
                },
                false
            }
        };

    public static TheoryData<int, Project[], bool> DataTestGetProjectsWithMinimumGradeInProjectBelow => 
        new TheoryData<int, Project[], bool>(){
            {
                65,
                new Project[]{
                    new Project() {
                        Id = 2,
                        Name = "Project 2",
                        Requirements = new string[] { "Requirement 1", "Requirement 2" },
                        BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
                    }
                },
                true
            },
            {
                85,
                new Project[]{
                    new Project() {
                        Id = 2,
                        Name = "Project 2",
                        Requirements = new string[] { "Requirement 1", "Requirement 2" },
                        BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
                    },
                    new Project() {
                        Id = 3,
                        Name = "Project 3",
                        Requirements = new string[] { "Requirement 1", "Requirement 2" },
                        BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
                    }
                },
                true
            },
            {
                85,
                new Project[]{
                    new Project() {
                        Id = 1,
                        Name = "Project 1",
                        Requirements = new string[] { "Requirement 1", "Requirement 2" },
                        BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
                    },
                    new Project() {
                        Id = 2,
                        Name = "Project 2",
                        Requirements = new string[] { "Requirement 1", "Requirement 2" },
                        BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
                    },
                },
                false
            }
        };


    public static TheoryData<string, Student[], bool> DataTestGetStudentsDoneProject => 
        new TheoryData<string, Student[], bool>(){
            {
                "Project 1",
                new Student[]{
                    new Student() {
                        Id = 1,
                        Name = "Student 1",
                        Age = 20,
                    },
                },
                true
            },
            {
                "Project 2",
                new Student[]{
                    new Student() {
                        Id = 3,
                        Name = "Student 3",
                        Age = 22,
                    }
                },
                true
            },
            {
                "Project 2",
                new Student[]{
                    new Student() {
                        Id = 1,
                        Name = "Student 1",
                        Age = 20,
                    },
                },
                false
            }
        };

    public static SchoolDatabase DatabaseForTesting => new SchoolDatabase{
        Students = new Student[] {
            new Student() {
                Id = 1,
                Name = "Student 1",
                Age = 20,
            },
            new Student() {
                Id = 2,
                Name = "Student 2",
                Age = 21,
            },
            new Student() {
                Id = 3,
                Name = "Student 3",
                Age = 22,
            }
        },
        Projects = new Project[] {
            new Project() {
                Id = 1,
                Name = "Project 1",
                Requirements = new string[] { "Requirement 1", "Requirement 2" },
                BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
            },
            new Project() {
                Id = 2,
                Name = "Project 2",
                Requirements = new string[] { "Requirement 1", "Requirement 2" },
                BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
            },
            new Project() {
                Id = 3,
                Name = "Project 3",
                Requirements = new string[] { "Requirement 1", "Requirement 2" },
                BonusRequirements = new string[] { "Bonus 1", "Bonus 2" }
            }
        },
        ProjectGrades = new ProjectGrade[] {
            new ProjectGrade() {
                ProjectId = 1,
                StudentId = 1,
                Grades = new int[] { 90, 90 }
            },
            new ProjectGrade() {
                ProjectId = 3,
                StudentId = 2,
                Grades = new int[] { 70, 70 }
            },
            new ProjectGrade() {
                ProjectId = 2,
                StudentId = 3,
                Grades = new int[] { 60, 60 }
            }
        }
    };
}