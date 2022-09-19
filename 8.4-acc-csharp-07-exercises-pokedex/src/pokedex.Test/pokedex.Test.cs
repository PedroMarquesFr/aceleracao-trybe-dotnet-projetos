using pokedex.Models;
using pokedex.Controllers;
using pokedex.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;
using pokemon.Test;
using FluentAssertions;
using pokedex.Requests;

namespace pokedex.Test
{
    public class PokemonsControllerTest
    {
        private IPokemonService _repositoryMock;
        private PokemonsController _controller;


        public PokemonsControllerTest()
        {
            _repositoryMock = new PokemonServiceFake();
            _controller = new PokemonsController(_repositoryMock);
        }

        // Testes GET
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            //Act
            var okResult = _controller.Get().Result as OkObjectResult;

            //Assert
            Assert.IsType<List<PokemonCatched>>(okResult.Value);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllPokemons()
        {
            //Act
            var okResult = _controller.Get().Result as OkObjectResult;

            //Assert
            var items = Assert.IsType<List<PokemonCatched>>(okResult.Value);
            Assert.Equal(2, items.Count);
        }

        [Fact]
        public void GetById_UnknownIdPassed_ReturnsNotFoundResult()
        {
            //Act
            var notFoundResult = _controller.GetById(99).Result as ObjectResult;

            //Assert
            Assert.Equal("Customer not found", notFoundResult.Value);
        }
        [Fact]
        public void GetById_ExistingIdPassed_ReturnsOkResult()
        {
            //Act
            var okResult = _controller.GetById(1).Result as OkObjectResult;

            //Assert
            Assert.IsType<PokemonCatched>(okResult.Value);
        }
        [Fact]
        public void GetById_ExistingIdPassed_ReturnsRightItem()
        {
            //Arrange
            var id = 1;
            //Act
            var okResult = _controller.GetById(id).Result as OkObjectResult;

            //Assert
            var pokemon = okResult.Value as PokemonCatched;
            pokemon.Id.Should().Be(id);
            pokemon.Name.Should().Be("eeve");

        }

        // Testes POST
        [Fact]
        public void Add_PokemonWithoutId_ReturnsBadRequest()
        {
            var request = new PokemonCatched("seila");
            var result = _controller.Post(request);
            result.Should().BeOfType<BadRequestResult>();
        }

        [Fact]
        public void Add_ValidPokemonPassed_ReturnsCreatedResponse()
        {
            var request = new PokemonCatched(2, "seila");
            var result = _controller.Post(request);
            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public void Add_ValidPokemonPassed_ReturnedResponseHasCreatedItem()
        {
            var request = new PokemonCatched(3, "seila");
            var result = _controller.Post(request) as OkObjectResult;
            var pokemon = result.Value as PokemonCatched;
            pokemon.Id.Should().Be(3);
            pokemon.Name.Should().Be("seila");
        }

        // Testes PUT
        [Fact]
        public void PutById_ExistingIdPassed_ReturnsOkResult()
        {
            var request = new PokemonCatched(0, "seila");
            var result = _controller.Put(0, request);
            result.Should().BeOfType<OkResult>();
        }

        [Fact]
        public void PutById_IdNotFound_ReturnsNotFoundResult()
        {
            var request = new PokemonCatched(7, "seila");
            var result = _controller.Put(7, request);
            result.Should().BeOfType<NotFoundResult>();
        }


        // Testes DELETE
        [Fact]
        public void Remove_NotExistingIdPassed_ReturnsNotFoundResponse()
        {
            var result = _controller.Remove(7);
            result.Should().BeOfType<NotFoundResult>();
        }
        [Fact]
        public void Remove_ExistingIdPassed_ReturnsOkResult()
        {
            var result = _controller.Remove(1);
            result.Should().BeOfType<NoContentResult>();
        }

    }
}