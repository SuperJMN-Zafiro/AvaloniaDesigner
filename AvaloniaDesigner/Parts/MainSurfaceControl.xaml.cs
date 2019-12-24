using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Designer.Parts
{
    public class MainSurfaceControl : UserControl
    {
        public MainSurfaceControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
