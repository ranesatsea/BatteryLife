using Godot;
using System;

public class VerticalSpikeTrigger : Area2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void _on_LeftTrigger_body_entered(KinematicBody2D body)
    {
        // GD.Print("dsa");
        // //int leftRight = 0;
        // float Amount =3;
        // KinematicBody2D movingSpike = GetNode<KinematicBody2D>("spike");
        // GD.Print("VerticlSpike");
        // if (buttonOneCheck==true && leftRight == 1)
        // // {
        // //     movingSpike.Position += new Vector2(Amount,0);
        // // }
    }
}
