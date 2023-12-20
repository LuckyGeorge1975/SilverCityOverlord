using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Splat;
using tdc.avalonia.silvercity.Exceptions;
using tdc.avalonia.silvercity.ViewModels;

namespace tdc.avalonia.silvercity.Events.Handlers;

public class ChangeViewModelInMainViewModelEventHandler : INotificationHandler<ChangeViewModelEvent>
{
    public Task Handle(ChangeViewModelEvent notification, CancellationToken cancellationToken)
    {
        var mainViewModel = Locator.Current.GetService<MainViewModel>() ??
                            throw new ServiceNotFoundException(nameof(MainViewModel));
        return mainViewModel.Handle(notification, cancellationToken);
    }
}