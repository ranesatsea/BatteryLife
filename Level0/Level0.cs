using Godot;
using System;

public class Level0 : Node2D
{
    // Declare member variables here. Examples:
    public int ac = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
         GD.Print("dwassd");
        //int leftRight = 0;
        //float Amount =3;
        //GlobalVar b = (GlobalVar)GetNode("/root/GlobalNode"); 
       // GD.Print(b.buttonCheck);
        KinematicBody2D movingSpike = (KinematicBody2D)GetNode("spike");
        // if(buttonOneCheck.buttonCheck == 1 && leftRight == 1)
        // {
        //     movingSpike.Position += new Vector2(Amount,0);
        // }
    }
    
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
