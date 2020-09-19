using Godot;
using System;

public class LevelMain : Node2D
{
 
    public override void _Ready()
    {
        
    }
    public void _on_LevelDoor1_body_entered(KinematicBody2D body2D)
    {
        GetTree().ChangeScene("res://Level0/Level0.tscn");

    }

}
