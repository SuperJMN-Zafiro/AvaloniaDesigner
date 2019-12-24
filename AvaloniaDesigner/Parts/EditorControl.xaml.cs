using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Designer.Parts
{
    public class EditorControl : UserControl
    {
        public EditorControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
