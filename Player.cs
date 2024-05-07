using Godot;
using System;

public class Player : KinematicBody2D
{
    [Export]
    public int Speed = 300;
    [Export]
    public int JumpStrength = 600;
    private Vector2 _velocity = new Vector2();
    private const int Gravity = 20;

    public override void _PhysicsProcess(float delta)
    {
        _velocity.x = 0; // Reset horizontal movement each frame

        // Handle horizontal movement
        if (Input.IsActionPressed("ui_right"))
            _velocity.x += Speed;
        if (Input.IsActionPressed("ui_left"))
            _velocity.x -= Speed;

        // Handle jumping
        if (IsOnFloor() && Input.IsActionJustPressed("ui_up"))
            _velocity.y = -JumpStrength;

        // Apply gravity
        _velocity.y += Gravity;

        // Move the player and handle collision
        _velocity = MoveAndSlide(_velocity, new Vector2(0, -1));
    }
}
