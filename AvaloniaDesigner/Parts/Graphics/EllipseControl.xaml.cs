using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Designer.Parts.Graphics
{
    public class EllipseControl : UserControl
    {
        public EllipseControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
