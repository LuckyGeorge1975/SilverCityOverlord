using MediatR;
using tdc.avalonia.silvercity.Events;

namespace tdc.avalonia.silvercity.ViewModels.Menu;

public class StartViewModel : ViewModelBase
{
    private readonly IMediator _mediator;

    public StartViewModel(IMediator mediator)
    {
        _mediator = mediator;
    }


    public bool StartCommand()
    {
        _mediator.Publish(new ChangeViewModelEvent(nameof(ChooseCharacterViewModel)));
        return true;
    }

    public bool ContinueCommand( )
    {
        return true;
    }
    
    public bool OptionsCommand( )
    {
        return true;
    }
    
    public bool AboutCommand( )
    {
        return true;
    } 
}