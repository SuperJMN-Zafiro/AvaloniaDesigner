﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Designer.Parts
{
    public class PropertiesControl : UserControl
    {
        public PropertiesControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
