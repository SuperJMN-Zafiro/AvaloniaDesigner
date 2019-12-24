using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Designer.Parts.Graphics
{
    public class TextBoxControl : UserControl
    {
        public TextBoxControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
