using System.Linq;
using Avalonia.Media.Imaging;
using Splat.ModeDetection;
using System.Reflection;
using ReactiveUI;
using tdc.avalonia.silvercity.Game;
using tdc.avalonia.silvercity.Game.Player;
using tdc.avalonia.silvercity.Game.Territory;

namespace tdc.avalonia.silvercity.ViewModels.Game;

public class TerritoryViewModel(IGameModel gameModel,ITerritoryModel territoryModel) : ViewModelBase<ITerritoryModel>(territoryModel)
{
    private bool _isSelected;

    public Bitmap? Image
    {
        get
        {
            if (string.IsNullOrEmpty(Model.ImagePath)) return null;
            var assembly = Assembly.GetExecutingAssembly();
            var resourceStream = assembly.GetManifestResourceStream(Model.ImagePath);
            return resourceStream != null ? new Bitmap(resourceStream) : null;
        }
    }

    public int X => Model.Position.X;

    public int Y => Model.Position.Y;

    public bool IsSelected
    {
        get => _isSelected;
        set => this.RaiseAndSetIfChanged(ref _isSelected, value);
    }

    public IPlayerModel? CurrentPlayer => gameModel?.CurrentPlayer;
    
    public bool IsCurrentPlayerGangPresent => gameModel?.CurrentPlayer != null &&
                                              gameModel.CurrentPlayer.Gangs.Any(g => g.Position == Model.Position);

    public bool IsCurrentPlayerControlled => gameModel?.CurrentPlayer != null &&
                                             Model.PlayerInfluencePoints.ContainsKey(gameModel.CurrentPlayer) &&
                                             Model.PlayerInfluencePoints[gameModel.CurrentPlayer] >= Model.InfluencePointsToReachControl;

}