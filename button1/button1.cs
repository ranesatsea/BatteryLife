using Godot;
using System;

public class button1 : Area2D
{
    public static int doorCheck=0;

    public override void _Ready()
    {

    }

    public void _on_DoorTime_timeout()
    {
        GD.Print("You can enter door");
        doorCheck=1;
    }

    /*
    When Player enter or exit the button1 which help open MainExitDoor
    */
    public void _on_button1_body_entered(KinematicBody2D body)
    {
        Timer timer = this.GetNode<Timer>("DoorTime");
        GD.Print("hit");
        GD.Print("Timer Starts");
        timer.Start();      
    }
    public void _on_button1_body_exited(KinematicBody2D body)
    {
        Timer timer = this.GetNode<Timer>("DoorTime");
        timer.Stop();
        GD.Print("Timer stops");
    }   
    /*
    Ends Button1
    */
}
