using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatBot
{
    class CustomCommands
    {
        public static readonly RoutedUICommand OpenSettings = new RoutedUICommand
            (
                "OpenSettings",
                "OpenSettings",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.C,ModifierKeys.Control)
                }
            );

    }
}
