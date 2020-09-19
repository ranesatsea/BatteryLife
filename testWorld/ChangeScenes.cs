using Godot;
using System;

public class ChangeScenes : Button
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }
    public void _on_ChangeScene_pressed()
    {
        GD.Print("Scene has Changed");
        GetTree().ChangeScene("res://Level1/Level1.tscn");
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
