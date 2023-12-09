using tdc.maui.silvercity.Game.Interfaces;

namespace tdc.maui.silvercity.ViewModels;

public class GangViewModel(IGang gang)
{
    private readonly IGang _gang = gang;
}