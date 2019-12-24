using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Designer.Parts
{
    public class MenuControl : UserControl
    {
        public MenuControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
