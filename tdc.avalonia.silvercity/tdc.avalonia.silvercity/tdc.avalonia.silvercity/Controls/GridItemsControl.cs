using Avalonia.Controls.Templates;
using Avalonia.Controls;
using Avalonia;
using System.Diagnostics;

namespace tdc.avalonia.silvercity.Controls;

public class GridItemsControl : ItemsControl
{
        public static readonly StyledProperty<int> RowsProperty =
            AvaloniaProperty.Register<GridItemsControl, int>(nameof(Rows));

        public int Rows
        {
            get => GetValue(RowsProperty);
            set => SetValue(RowsProperty, value);
        }

        public static readonly StyledProperty<int> ColumnsProperty =
            AvaloniaProperty.Register<GridItemsControl, int>(nameof(Columns));

        public int Columns
        {
            get => GetValue(ColumnsProperty);
            set => SetValue(ColumnsProperty, value);
        }
}