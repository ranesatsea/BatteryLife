using Godot;
using System;

public class button1 : Area2D
{
    public static int doorCheck=0;

    public override void _Ready()
    {
        Timer timer = this.GetNode<Timer>("DoorTime");
        //timer.WaitTime=3;    
        //Change this for each level   

    }
    public void _on_Button_pressed()
    {
        GD.Print();
    }


    public void _on_DoorTime_timeout()
    {
        GD.Print("You can enter door");
        doorCheck=1;

    }
    
    public void _on_button1_body_entered(KinematicBody2D body)
    {
        //Area2D bodyCheck = this.GetNode<Area2D>("/root/button1");
       // var buttonOneCheck = (GlobalVar)GetNode("GlobalVar");
        //buttonOneCheck.buttonCheck += 1;

        Timer timer = this.GetNode<Timer>("DoorTime");
        GD.Print("hit");
        GD.Print("Timer Starts");
        //GD.Print(buttonOneCheck);
        timer.Start();          
    }
    public void _on_button1_body_exited(KinematicBody2D body)
    {
        Timer timer = this.GetNode<Timer>("DoorTime");
        timer.Stop();
        GD.Print("Timer stops");
        //var buttonOneCheck = (GlobalVar)GetNode("/root/Player/GlobalVar");
        //buttonOneCheck.buttonCheck = 0;

    }
    public override void _Process(float delta)
    {
        // int leftRight = 0;
        // float Amount =3;
        // KinematicBody2D movingSpike = (spike)GetNode("/root/spike");
        // if(buttonOneCheck==true && leftRight == 1)
        // {
        //     movingSpike.Position += new Vector2(Amount,0);
        // }
       
    }

}
