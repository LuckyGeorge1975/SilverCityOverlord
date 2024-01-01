using System.Collections.Generic;
using tdc.avalonia.silvercity.Game.Character;
using tdc.avalonia.silvercity.Game.Player;
using tdc.avalonia.silvercity.Game.Territory;

namespace tdc.avalonia.silvercity.Game;

public class GameModel : IGameModel
{
    private int _width;
    private int _height;
    private List<IPlayerModel> _players;
    private List<ITerritoryModel> _territories;

    private GameModel(int width, int height, List<IPlayerModel> players, List<ITerritoryModel> territories)
    {
        _width = width;
        _height = height;
        _players = players;
        _territories = territories;
    }

    public List<ITerritoryModel> Territories => _territories;

    public int Width => _width;

    public int Height => _height;

    public List<IPlayerModel> Players => _players;

    public IPlayerModel? CurrentPlayer { get; set; }

    public int CurrentTurn { get; }

    public static GameModel CreateGame(int width, int height, List<IPlayerModel> players)
    {
        return new GameModel(width, height, players, TerritoryGenerator.GenerateTerritories(width, height));
    }
}