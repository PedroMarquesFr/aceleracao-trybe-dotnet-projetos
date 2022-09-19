using Xunit;
using FluentAssertions;
using pokedex.Test;
using System;

namespace pokedex.Test.Test;

public class TestTestReq4
{
    [Trait("Category", "1 - Criar a rota GET para a Pokedex e seus testes")]
    [Fact (DisplayName = "O método .Get() deve retornar Ok")]    
    public void TestGetSucess()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.Get_WhenCalled_ReturnsOkResult();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "1 - Criar a rota GET para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .GetAll() deve retornar todos os pokemons")]
    public void TestGetAll()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.Get_WhenCalled_ReturnsAllPokemons();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "1 - Criar a rota GET para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .GetById() deve retornar NotFound")]
    public void TestGetByIdNotFound()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.GetById_UnknownIdPassed_ReturnsNotFoundResult();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "1 - Criar a rota GET para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .GetById() deve retornar Ok")]
    public void TestGetByIdOk()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.GetById_ExistingIdPassed_ReturnsOkResult();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "1 - Criar a rota GET para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .GetById() deve retornar o Item correto")]
    public void TestGetByIdRightItem()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.GetById_ExistingIdPassed_ReturnsRightItem();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
public class TestTestReq42
{
    [Trait("Category", "2 - Criar a rota POST para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .Post() deve retornar Bad Request, por estar sem Id")]
    public void TestPostBadRequestCauseId()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.Add_PokemonWithoutId_ReturnsBadRequest();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Criar a rota POST para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .Post() deve retornar Created")]
    public void TestPostCreatedOk()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.Add_ValidPokemonPassed_ReturnsCreatedResponse();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Criar a rota POST para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .Post() deve retornar o pokemon criado")]
    public void TestPostPokemonCreatedSuccess()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.Add_ValidPokemonPassed_ReturnedResponseHasCreatedItem();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}

public class TestTestReq43
{
    [Trait("Category", "3 - Criar a rota PUT para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .Put() deve retornar OK")]
    public void TestPutReturnsOk()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.PutById_ExistingIdPassed_ReturnsOkResult();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - Criar a rota PUT para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .Put() deve retornar NotFound")]
    public void TestPutReturnsNotFound()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.PutById_IdNotFound_ReturnsNotFoundResult();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}
public class TestTestReq44
{
    [Trait("Category", "4 - Criar a rota DELETE para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .Remove() deve etornar NotFound")]
    public void TestRemoveReturnsNotFound()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.Remove_NotExistingIdPassed_ReturnsNotFoundResponse();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "4 - Criar a rota DELETE para a Pokedex e seus testes")]
    [Fact(DisplayName = "O método .Remove() deve retornar OK")]
    public void TestRemoveReturnsOk()
    {
        PokemonsControllerTest instance = new();
        Action act = () => instance.Remove_ExistingIdPassed_ReturnsOkResult();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}