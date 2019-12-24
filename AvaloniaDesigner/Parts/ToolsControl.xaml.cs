using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Designer.Parts
{
    public class ToolsControl : UserControl
    {
        public ToolsControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
