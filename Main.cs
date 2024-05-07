using Godot;
using System;

public class Main : Node
{
    public override void _Ready()
    {
        GD.Print("Game Initialized: FAI Campus Rush");
        // Load the first level
        var levelScene = ResourceLoader.Load<PackedScene>("res://Scenes/Level.tscn");
        var level = levelScene.Instance();
        AddChild(level);
    }
}
