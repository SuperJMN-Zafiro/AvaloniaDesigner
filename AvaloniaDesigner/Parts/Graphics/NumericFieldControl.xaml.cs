using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Designer.Parts.Graphics
{
    public class NumericFieldControl : UserControl
    {
        public NumericFieldControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
