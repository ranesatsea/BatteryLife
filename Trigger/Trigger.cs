using Godot;
using System;

public class Trigger : Area2D
{
    public static int buttonOneCheck=0;
    public static int leftRight=0;
    public int speed=100;
    
    /*
    When Player steps on Trigger Node to see if spikes will be moving
    */
    public void _on_Trigger_body_entered(KinematicBody2D body)//Player steps on nodes, the spike willmove
    {
        GD.Print("Enter trigger");
        buttonOneCheck= 1;
    }

    public void _on_Trigger_body_exited(KinematicBody2D body)//when playe steps out, spike will stop
    {
        buttonOneCheck= 0;
        GD.Print("Exit trigger");
    }
    
    /*
    Check to see if the spike will move left or right
    */
    public override void _Process(float delta)
    {
        float Amount =1;
        var velocity=new Vector2(Amount,0);
        
        if(buttonOneCheck == 1 && leftRight == 0)
        {
            KinematicBody2D movingSpike = this.GetNode<KinematicBody2D>("Spike");
            movingSpike.Position += velocity *delta * speed;
        }
        else if(buttonOneCheck == 1 && leftRight == 1)
        {
            KinematicBody2D movingSpike = this.GetNode<KinematicBody2D>("Spike");
            movingSpike.Position -= velocity *delta * speed; 
        }
    }
    /*
    Signal
    
    */
    public void on_Right_body_entered(KinematicBody2D body)
    {
        if(body.GetName() == "Spike")
        {
            leftRight = 1;
            GD.Print("SPike will now move RIght");
        }
    }
    public void on_Left_body_entered(KinematicBody2D body2D)
    {
        if(body2D.GetName()== "Spike")
        {
            leftRight=0;
            GD.Print("Spike will now move Left");
        }
    }

   
}
