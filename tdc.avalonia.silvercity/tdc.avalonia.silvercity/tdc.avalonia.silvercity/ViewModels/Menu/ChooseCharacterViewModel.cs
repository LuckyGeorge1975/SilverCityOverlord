using System.Collections.Generic;
using System.Collections.ObjectModel;
using MediatR;
using ReactiveUI;
using tdc.avalonia.silvercity.Events;
using tdc.avalonia.silvercity.Game;
using tdc.avalonia.silvercity.Game.Character;
using tdc.avalonia.silvercity.Game.Player;
using tdc.avalonia.silvercity.ViewModels.Game;

namespace tdc.avalonia.silvercity.ViewModels.Menu;

public class ChooseCharacterViewModel : ViewModelBase
{
    private readonly IMediator _mediator;

    private readonly List<CharacterViewModel> _characters = new();

    private int _currentCharacterIndex = 0;
    private CharacterViewModel _currentCharacter;

    public CharacterViewModel CurrentCharacter
    {
        get => _currentCharacter;
        set => this.RaiseAndSetIfChanged(ref _currentCharacter,value);
    }

    public ObservableCollection<CharacterViewModel> Characters { get; }

    public ChooseCharacterViewModel(IMediator mediator)
    {
        _mediator = mediator;

        foreach (var character in CharacterGenerator.GetCharacters())
        {
            _characters.Add(new CharacterViewModel(character));
        }
        Characters = new ObservableCollection<CharacterViewModel>(_characters);
        CurrentCharacter = _characters[_currentCharacterIndex];
    }

    public bool BackCommand()
    {
        _mediator.Publish(new ChangeViewModelEvent(nameof(StartViewModel)));
        return true;
    }

    public bool NextCharacterCommand()
    {
        _currentCharacterIndex++;
        if(_currentCharacterIndex >= _characters.Count)
            _currentCharacterIndex = 0;
        CurrentCharacter = _characters[_currentCharacterIndex];
        return true;
    }

    public bool PreviousCharacterCommand()
    {
        _currentCharacterIndex--;
        if(_currentCharacterIndex < 0)
            _currentCharacterIndex = _characters.Count - 1;
        CurrentCharacter = _characters[_currentCharacterIndex];
        return true;
    }

    public bool StartCommand()
    {
        var gameVm = new GameViewModel(_mediator);
        gameVm.InititalizeGame(GameModel.CreateGame(8,8, new List<IPlayerModel>()));
        _mediator.Publish(new ChangeViewModelEvent(nameof(GameViewModel), gameVm));
        return true;
    }


}