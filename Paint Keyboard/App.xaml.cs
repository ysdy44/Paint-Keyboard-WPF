using Paint_Keyboard.Model;
using System.Windows;

namespace Paint_Keyboard
{
    public partial class App : Application
    {
        public static Solution Solution;
        public App()
        {
            App.Solution = XML.ConstructSolutionFile();
        }
    }
}