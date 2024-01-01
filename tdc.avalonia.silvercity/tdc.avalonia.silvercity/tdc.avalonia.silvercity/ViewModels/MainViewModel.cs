using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Threading;
using MediatR;
using ReactiveUI;
using Splat;
using tdc.avalonia.silvercity.Events;
using tdc.avalonia.silvercity.Exceptions;
using tdc.avalonia.silvercity.ViewModels.Game;
using tdc.avalonia.silvercity.ViewModels.Menu;
using tdc.avalonia.silvercity.Views.Game;

namespace tdc.avalonia.silvercity.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly IMediator _mediator;
    public MainViewModel(IMediator mediator)
    {
        _mediator = mediator;
    }
    private ViewModelBase _currentViewModel = Locator.Current.GetService<StartViewModel>() ??
                                              throw new ServiceNotFoundException(nameof(StartViewModel));

    public ViewModelBase CurrentViewModel
    {
        get => _currentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _currentViewModel, value);
    }

    public Task Handle(ChangeViewModelEvent @event, CancellationToken cancellationToken)
    {
        Dispatcher.UIThread.Post(() => CurrentViewModel = @event.ViewModelName switch
        {
            nameof(StartViewModel) => Locator.Current.GetService<StartViewModel>() ?? 
                                      throw new ServiceNotFoundException(nameof(StartViewModel)),
            nameof(ChooseCharacterViewModel) => Locator.Current.GetService<ChooseCharacterViewModel>() ?? 
                                                throw new ServiceNotFoundException(nameof(ChooseCharacterViewModel)),
            nameof(GameViewModel) => @event.ViewModel,
            _ => CurrentViewModel
        });

        return Task.CompletedTask;
    }
}