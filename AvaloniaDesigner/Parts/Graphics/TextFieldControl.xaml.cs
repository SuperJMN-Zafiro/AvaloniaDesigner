using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Designer.Parts.Graphics
{
    public class TextFieldControl : UserControl
    {
        public TextFieldControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
