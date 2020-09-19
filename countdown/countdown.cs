using Godot;
using System;

public class countdown : Node2D
{
    int ms = 0;
    int s = 0;
    int m = 15;
    public override void _Process(float detla)
    {
        var message1 = (Label)GetNode("TimeLabel");
        message1.Text =m.ToString() + ":" + s.ToString() + ":" + ms.ToString();//set up the display but does nto call
        if (ms < 0)
        {
            s-=1;
            ms = 10;
        }
        if (s < 0)
        {
            m-=1;
            s=59;
        }
    message1.Show();// callmessages1 and dispalys it
    }
    public void _on_ms_timeout()
    {
        ms-=1;
    }

}
