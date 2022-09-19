using Xunit;
using FluentAssertions;
using System;
using projeto_base;

namespace projeto_base.Test.Test;

public class UnitTest1
{
    [Trait("Category", "1 - Criar o Dockerfile")]
    [Fact(DisplayName = "Deve criar o arquivo de Dockerfile")]
    public void TestCreateDockerFile()
    {
        var fileName = "Dockerfile";
        var workingDirectory = Environment.CurrentDirectory;
        workingDirectory = workingDirectory.Replace(".Test", "");
        workingDirectory = workingDirectory.Replace("/bin/Debug/net6.0", "");        
        var file = workingDirectory + "/" + fileName;
        //file.Should().Be("cremps");
        System.IO.File.Exists(file).Should().Be(true);
    }
}