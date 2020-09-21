using Godot;
using System;

public class LeftTrigger : Area2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    private int buttonOneCheck=0;
    public int speed=100;


    // Called when the node enters the scene tree for the first time.
    public void _on_LeftTrigger_body_entered(KinematicBody2D body)
    {
        GD.Print("dwassd");
        //int leftRight = 0;
        buttonOneCheck= 1;
        //Timer timer = this.GetNode<Timer>("DoorTime");
    }
    public void _on_LeftTrigger_body_exited(KinematicBody2D body)
    {
        buttonOneCheck= 0;

    }

    /*
    Moves Spike to the Left
    */
    public override void _Process(float delta)
    {
        float Amount =1;
        var velocity=new Vector2(Amount,0);

        if(buttonOneCheck == 1)// && leftRight == 0
        {
            GD.Print("Spike MOVES!!!");
            KinematicBody2D movingSpike = GetNode<KinematicBody2D>("spike");
            movingSpike.Position += velocity *delta * speed;
        }
        else if(buttonOneCheck==0)
        {
            var speed=0;
           

        }
    }


}
