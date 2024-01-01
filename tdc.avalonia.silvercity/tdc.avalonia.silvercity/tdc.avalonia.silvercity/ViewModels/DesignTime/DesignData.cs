using System.Collections.Generic;
using Avalonia.Media;
using tdc.avalonia.silvercity.Game;
using tdc.avalonia.silvercity.Game.Base;
using tdc.avalonia.silvercity.Game.Character;
using tdc.avalonia.silvercity.Game.Gang;
using tdc.avalonia.silvercity.Game.Player;
using tdc.avalonia.silvercity.Game.Territory;
using tdc.avalonia.silvercity.ViewModels.Game;
using tdc.avalonia.silvercity.ViewModels.Menu;

namespace tdc.avalonia.silvercity.ViewModels.DesignTime;

public static class DesignData
{
    public static ChooseCharacterViewModel ChooseCharacterViewModel { get; } = new(null!)
    {
        CurrentCharacter = new CharacterViewModel(CharacterGenerator.GenerateCharacter(null!))
    };

    public static CharacterViewModel CharacterViewModel { get; } = new(CharacterGenerator.GenerateCharacter(null!));

    public static GameViewModel GameViewModel
    {
        get
        {
            var vm = new GameViewModel(null!);
            var designPlayer = new PlayerModel("TestPlayer", "No Description",
                CharacterGenerator.GenerateCharacter(
                    "tdc.avalonia.silvercity.Assets.Territories.Characters.boss-smart-male-02.png"),
                new List<IGangModel>(), Colors.Aqua);

            designPlayer.Gangs.Add(new GangModel()
            {
                Position = new Position(2, 2)
            });

            vm.InititalizeGame(GameModel.CreateGame(8, 8,
            [
                designPlayer
            ]));

            vm.Territories[0].Model.PlayerInfluencePoints.Add(designPlayer,101);

            vm.Game.CurrentPlayer = designPlayer;
            return vm;
        }
    }

    public static TerritoryViewModel TerritoryViewModel
    {
        get
        {
            return new(GameViewModel.Game,
                new TerritoryModel(TerritoryType.DENSE_COMMERCIAL, new Position(0, 0))
                    { ImagePath = "tdc.avalonia.silvercity.Assets.Territories.Images.government.png" });
        }
    }
}