using MediatR;
using tdc.avalonia.silvercity.ViewModels;

namespace tdc.avalonia.silvercity.Events;

public class ChangeViewModelEvent(string viewModelName) : INotification
{
    private string _viewModelName = viewModelName;
    private ViewModelBase _viewModel = null!;

    public string ViewModelName
    {
        get => _viewModelName;
        set => _viewModelName = value;
    }

    public ViewModelBase ViewModel
    {
        get => _viewModel;
        set => _viewModel = value;
    }

    public ChangeViewModelEvent(string viewModelName, ViewModelBase viewModel) : this(viewModelName)
    {
        _viewModel = viewModel;
    }
}