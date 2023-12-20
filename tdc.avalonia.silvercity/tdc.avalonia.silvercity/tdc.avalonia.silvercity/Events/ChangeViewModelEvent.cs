using MediatR;

namespace tdc.avalonia.silvercity.Events;

public class ChangeViewModelEvent(string viewModelName) : INotification
{
    public string ViewModelName { get; set; } = viewModelName;
}