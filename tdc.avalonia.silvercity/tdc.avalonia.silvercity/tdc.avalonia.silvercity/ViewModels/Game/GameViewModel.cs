using System.Collections.ObjectModel;
using System.Linq;
using DynamicData;
using MediatR;
using tdc.avalonia.silvercity.Game;

namespace tdc.avalonia.silvercity.ViewModels.Game;

public class GameViewModel : ViewModelBase
{
    private readonly IMediator _mediator;
    private GameModel _game;

    public ObservableCollection<TerritoryViewModel> Territories { get; } = new();

    public GameViewModel(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void InititalizeGame(GameModel game)
    {
        _game = game;

        Territories.AddRange(_game.Territories.Select(territory => new TerritoryViewModel(game, territory)));
    }

    public int TerritoriesWidth => _game.Width;

    public int TerritoriesHeight => _game.Height;

    public IGameModel Game => _game;
}