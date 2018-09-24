using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        this.Title = "Fennec";
        Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
        Build();
    }
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    public void OnLoad()
    {
        // Set the background color to white

        // Set the logo image
        Gdk.Pixbuf logo = new Gdk.Pixbuf("../../app_logo.jpg",200,250);
        imgLogo.Pixbuf = logo;
        //
    }

}
