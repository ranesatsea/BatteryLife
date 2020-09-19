using Godot;
using System;

public class Player : KinematicBody2D
{
    public int moveSpeed = 100;
    public int doorCount = 0;

    private AnimatedSprite animatedPlayer;
    private Vector2 _velocity = new Vector2();
    public override void _Ready()
    {
        animatedPlayer = (AnimatedSprite)this.GetNode("AnimatedSprite");
        
    }
    public override void _PhysicsProcess(float delta)
    {
        var motion = new Vector2();
        motion.x = Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left");
        motion.y = Input.GetActionStrength("move_down") - Input.GetActionStrength("move_up");
        MoveAndCollide(motion.Normalized()*moveSpeed*delta);
        
        

    if (Input.IsActionPressed("move_right"))
    {
        animatedPlayer.SetAnimation("WalkRight");
    }

    else if (Input.IsActionPressed("move_left"))
    {
        animatedPlayer.SetAnimation("WalkLeft");
    }

    else if (Input.IsActionPressed("ui_down"))
    {
        
    }

    else if (Input.IsActionPressed("ui_up"))
    {
    }
    else
    {
        animatedPlayer.SetAnimation("Idle");
    }
}
}
