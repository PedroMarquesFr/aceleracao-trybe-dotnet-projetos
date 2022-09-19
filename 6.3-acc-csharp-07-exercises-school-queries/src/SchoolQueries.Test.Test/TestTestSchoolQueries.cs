using Xunit;
using System.IO;
using System;
using FluentAssertions;
using SchoolQueries.Test;
using SchoolQueries;

namespace SchoolQueries.Test.Test;

[Collection("Sequential")]
public class TestTestSchoolDatabase : TestTestSchoolDatabaseData
{
    [Trait("Category", "1 - Realizou os testes para GetStudentsByName.")]
    [Theory(DisplayName = "Deve testar a busca de uma pessoa estudante pelo nome.")]
    [MemberData(nameof(DataTestGetStudentsByName))]
    public void TestTestGetStudentsByName(string nameEntry, Student[] studentsExpected, bool isCorrect)
    {
        TestSchoolDatabase instance = new();
        Action act = () => instance.TestGetStudentsByName(DatabaseForTesting, nameEntry, studentsExpected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }

}
public class TestTestSchoolDatabase2 : TestTestSchoolDatabaseData
{
    [Trait("Category", "2 - Realizou os testes para GetStudentsWithAverageGradeInProjectAbove.")]
    [Theory(DisplayName = "Deve testar a busca de pessoas estudantes com a média de notas acima de um determinado valor.")]
    [MemberData(nameof(DataTestGetStudentsWithAverageGradeInProjectAbove))]
    public void TestTestGetStudentsWithAverageGradeInProjectAbove(int gradeEntry, Student[] studentsExpected, bool isCorrect)
    {
        TestSchoolDatabase instance = new();
        Action act = () => instance.TestGetStudentsWithAverageGradeInProjectAbove(DatabaseForTesting, gradeEntry, studentsExpected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }
}
public class TestTestSchoolDatabase3 : TestTestSchoolDatabaseData
{
    [Trait("Category", "3 - Realizou os testes para GetProjectsWithMinimumGradeInProjectBelow.")]
    [Theory(DisplayName = "Deve testar a busca de projetos com notas abaixo de um valor especificado.")]
    [MemberData(nameof(DataTestGetProjectsWithMinimumGradeInProjectBelow))]
    public void TestTestGetProjectsWithMinimumGradeInProjectBelow(int gradeEntry, Project[] projectsExpected, bool isCorrect)
    {
        TestSchoolDatabase instance = new();
        Action act = () => instance.TestGetProjectsWithMinimumGradeInProjectBelow(DatabaseForTesting, gradeEntry, projectsExpected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }

        act.Should().NotThrow<NotImplementedException>();
    }
}
public class TestTestSchoolDatabase4 : TestTestSchoolDatabaseData
{
    [Trait("Category", "4 - Realizou os testes para GetStudentsDoneProject.")]
    [Theory(DisplayName = "Deve testar a busca de estudantes que realizaram um projeto especifico.")]
    [MemberData(nameof(DataTestGetStudentsDoneProject))]
    public void TestTestGetStudentsDoneProject(string projectNameEntry, Student[] studentsExpected, bool isCorrect)
    {
        TestSchoolDatabase instance = new();
        Action act = () => instance.TestGetStudentsDoneProject(DatabaseForTesting, projectNameEntry, studentsExpected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }
}
