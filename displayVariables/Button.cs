
using Godot;
using System;

public class Button : Godot.Button
{
    public override void _Ready()
    {
        ShowMessage("Game Oversds");

    }

    public void _on_Button_pressed()
    {
        ShowMessage("as");
    }

    public void ShowMessage(string text)
    {
        var message = GetNode<Label>("Message");
        message.Text = text;
        message.Show();
    }

}
