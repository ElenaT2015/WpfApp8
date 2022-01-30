using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace WpfApp8
{
    class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        public static RoutedUICommand Closed { get; set; }
        public static RoutedUICommand Save { get; set; }
        public static RoutedUICommand Open { get; set; }
        static MyCommands()
        {
            Exit = new RoutedCommand();

            InputGestureCollection Input1 = new InputGestureCollection();
            Input1.Add(new KeyGesture(Key.C, ModifierKeys.Control, "Ctrl+C"));
            Closed = new RoutedUICommand("_Закрыть", "Closed", typeof(MyCommands), Input1);

            InputGestureCollection Input2 = new InputGestureCollection();
            Input2.Add(new KeyGesture(Key.S, ModifierKeys.Control, "Ctrl+S"));
            Save = new RoutedUICommand("_Сохранить", "Save", typeof(MyCommands), Input2);

            InputGestureCollection Input3 = new InputGestureCollection();
            Input3.Add(new KeyGesture(Key.O, ModifierKeys.Control, "Ctrl+O"));
            Open = new RoutedUICommand("_Открыть", "Open", typeof(MyCommands), Input3);

        }
    }
}