namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        var gameByDeveloper = from game in Games
                              join studio in GameStudios on game.DeveloperStudio equals studio.Id
                              where studio.Id == gameStudio.Id
                              select game;
        if (!gameByDeveloper.Any()) throw new NotImplementedException();
        return gameByDeveloper.ToList();
    }

    public List<Game> GetGamesPlayedBy(Player player)
    {
        var gamesbyPlayer = from game in Games
                            where game.Players.Any(playerId => player.Id == playerId)
                            select game;
        if (!gamesbyPlayer.Any()) throw new NotImplementedException();
        return gamesbyPlayer.ToList();
    }

    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        var gamesOwnedbyPlayer = from game in Games
                            where playerEntry.GamesOwned.Any(gameId => gameId == game.Id)
                            select game;
        if (!gamesOwnedbyPlayer.Any()) throw new NotImplementedException();
        return gamesOwnedbyPlayer.ToList();
    }
}
