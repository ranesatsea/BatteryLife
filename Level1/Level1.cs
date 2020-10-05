using Godot;
using System;

public class Level1 : Node2D
{
    private static int spikeCheck;
    // public static int buttonOneCheck=0;
    public int speed=100;

    public void on_WireMappingLevel1_body_entered(KinematicBody2D body2D)
    {
        GD.Print("sds");
    }
    // public override void _Process(float delta)
    // {
    //     float Amount =1;
    //     var velocity=new Vector2(Amount,0);
    //     //var movingSpike = (spike)GetNode("../root/spike");
        
    //     if(Trigger.buttonOneCheck == 1)// && leftRight == 0
    //     {
    //         KinematicBody2D movingSpike = this.GetNode<KinematicBody2D>("Spike");
    //         movingSpike.Position += velocity *delta * speed;
    //     }
    //     else if(spikeCheck==0)
    //     {
    //         var speed=0;
    //     }
    // }
    //Signal for Trigger
    // public void _on_Trigger_body_entered(KinematicBody2D body)
    // {
    //     GD.Print("Enter trigger");
    //     buttonOneCheck= 1;
    // }

    // public void _on_Trigger_body_exited(KinematicBody2D body)
    // {
    //     buttonOneCheck= 0;
    //     GD.Print("Exit trigger");
    // }
   


}
