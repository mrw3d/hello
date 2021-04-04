using System;
using System.Drawing;
using System.Windows.Forms;

public class HelloWorld : Form
{
    static public void Main ()
    {
        Application.Run (new HelloWorld ());
        Application.Run (new Welcomegame ());
    }

    public HelloWorld ()
    {
        Button b = new Button ();
        b.Text = "Click Me!!!";
        b.Click += new EventHandler (Button_Click);
        Controls.Add (b);


    }

    public Welcomegame ()
    {
      Button aco = new Button ();
      aco.Text = "Fuck you baby!";
      aco.Click += new EventHandler(Welcome);
      Controls.Add (aco);
    }

    private void Button_Click (object sender, EventArgs e)
    {
        MessageBox.Show ("Button Clicked!");

    }

    private void Welcome (object sender, EventArgs e){
      MessageBox.Show("Welcome to my game!");

    }
}
