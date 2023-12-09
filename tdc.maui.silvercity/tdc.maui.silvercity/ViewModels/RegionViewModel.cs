using tdc.maui.silvercity.Game.Interfaces;

namespace tdc.maui.silvercity.ViewModels;

public class RegionViewModel(IRegion region)
{
    private readonly IRegion _region = region;
}