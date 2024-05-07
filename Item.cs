using Godot;
using System;

public class Item : Area2D
{
    [Signal]
    public delegate void ItemCollected(Item item);

    public override void _Ready()
    {
        Connect("body_entered", this, nameof(OnBodyEntered));
    }

    private void OnBodyEntered(Node body)
    {
        if (body is Player)
        {
            EmitSignal(nameof(ItemCollected), this);
            QueueFree(); // Remove the item from the scene
        }
    }
}
