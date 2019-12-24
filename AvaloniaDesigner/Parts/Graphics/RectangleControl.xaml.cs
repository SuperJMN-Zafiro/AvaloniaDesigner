using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Designer.Parts.Graphics
{
    public class RectangleControl : UserControl
    {
        public RectangleControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
