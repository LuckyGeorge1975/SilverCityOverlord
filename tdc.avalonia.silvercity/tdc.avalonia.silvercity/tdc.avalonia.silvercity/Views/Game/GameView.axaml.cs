using Avalonia.Controls;
using Avalonia.Controls.PanAndZoom;
using System.Diagnostics;

namespace tdc.avalonia.silvercity.Views.Game
{
    public partial class GameView : UserControl
    {
        private readonly ZoomBorder? _zoomBorder;

        public GameView()
        {
            InitializeComponent();

            _zoomBorder = this.Find<ZoomBorder>("ZoomBorder");
            if (_zoomBorder != null)
            {
                _zoomBorder.ZoomChanged += ZoomBorder_ZoomChanged;
            }

        }

        private void ZoomBorder_ZoomChanged(object sender, ZoomChangedEventArgs e)
        {
            Debug.WriteLine($"[ZoomChanged] {e.ZoomX} {e.ZoomY} {e.OffsetX} {e.OffsetY}");
        }
    }
}
