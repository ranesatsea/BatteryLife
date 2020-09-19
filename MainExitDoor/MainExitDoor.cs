using Godot;
using System;

public class MainExitDoor : Area2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    
    
    public void _on_MainExitDoor_body_entered(KinematicBody2D body)
    {
        if(button1.doorCheck==1)//get checked from button1.cs. If player is on button1 for longer then x Seconds
        {
            GD.Print("Scene has Changed");
            GetTree().ChangeScene("res://LevelMain/LevelMain.tscn");
        }
    }
}
