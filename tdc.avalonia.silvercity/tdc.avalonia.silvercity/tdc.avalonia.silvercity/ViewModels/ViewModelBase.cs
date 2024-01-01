using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ReactiveUI;

namespace tdc.avalonia.silvercity.ViewModels;

public class ViewModelBase : ReactiveObject
{

}

public class ViewModelBase<TModel>(TModel model) : ViewModelBase
    where TModel : class
{
    public TModel Model
    {
        get => model;
        set => this.RaiseAndSetIfChanged(ref model, value);
    }
}