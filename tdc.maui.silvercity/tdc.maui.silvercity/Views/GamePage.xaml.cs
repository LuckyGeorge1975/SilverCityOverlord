using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdc.maui.silvercity.ViewModels;

namespace tdc.maui.silvercity.Views;

public partial class GamePage : BasePage<GameViewModel>
{
    public GamePage(GameViewModel viewModel)
    : base(viewModel)
    {
        InitializeComponent();
    }
}