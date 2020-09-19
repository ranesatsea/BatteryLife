using Godot;
using System;

public class DisplayVariables : Node2D
{
   public override void _Ready()
    {
        
        var playerVariables = (Player)GetNode("/root/Player");


        ShowMessage("dsa");
        //Need .tostring() to conevrt to string or else you get an error
    }

    public void _on_Button_pressed()
    {
        var playerVariables = (Player)GetNode("/root/Player");
        //var buttonVariables = (button1)GetNode("/root/button1");

        //ShowMessage(buttonVariables.timer);
    }

    public void ShowMessage(string text)
    {
        var message = (Label)GetNode("Message");
        message.Text = text;
        message.Show();
    }
}
