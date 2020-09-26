using Godot;
using System;

public class Level1 : Node2D
{
    private static int spikeCheck;
    public int speed=100;


    //PackedScene packedScene;
    public override void _Ready()
    {
        //spikeCheck = LeftTrigger.buttonOneCheck;
        //packedScene = (PackedScene)GD.Load("res://Spike.tscn");

    }
    public void on_WireMappingLevel1_body_entered(KinematicBody2D body2D)
    {
        GD.Print("sds");
    }
    public override void _Process(float delta)
    {
        float Amount =1;
        var velocity=new Vector2(Amount,0);
        //var movingSpike = (spike)GetNode("../root/spike");

        if(spikeCheck == 0)// && leftRight == 0
        {
            GD.Print("Spike MOVES!!!");
            GD.Print(spikeCheck);

            KinematicBody2D movingSpike = this.GetNode<KinematicBody2D>("Spike");
            movingSpike.Position += velocity *delta * speed;
        }
        else if(spikeCheck==0)
        {
            var speed=0;
        }
    }
   


}
