using System;
using Gtk;

namespace Fennec
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            // Check here if the user already has a token
            //
            MainWindow win = new MainWindow();
            win.Show();
            // Call the onload public function to load images etc.
            win.OnLoad();
            Application.Run();
        }
    }
}
