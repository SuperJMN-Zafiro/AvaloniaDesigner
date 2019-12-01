using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaDesigner
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
