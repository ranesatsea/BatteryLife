using Godot;
using System;

public class Trigger : Area2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    public static int buttonOneCheck=0;
    public override void _Ready()
    {
        
    }

    public void _on_Trigger_body_entered(KinematicBody2D body)
    {
        GD.Print("Enter trigger");
        //int leftRight = 0;
        buttonOneCheck= 1;
        //Timer timer = this.GetNode<Timer>("DoorTime");
        GD.Print(buttonOneCheck);
    }

    public void _on_Trigger_body_exited(KinematicBody2D body)
    {
        buttonOneCheck= 0;

    }
}
