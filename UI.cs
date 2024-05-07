using Godot;
using System;

public class UI : CanvasLayer
{
    Label scoreLabel;

    public override void _Ready()
    {
        scoreLabel = GetNode<Label>("ScoreLabel");
    }

    public void UpdateScore(int score)
    {
        scoreLabel.Text = $"Score: {score}";
    }
}
