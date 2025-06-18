using Godot;
using System;

public partial class ChaliceCollision : Area2D
{
	
	// chalice handler
	[Signal]
	public delegate void ChaliceCollidedEventHandler();
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// signal prep for chalice
		BodyEntered += Collision;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	// chalice collision
	public void Collision(Node2D Player){
		GetTree().ChangeSceneToFile("res://GameDefeated.tscn");
	}
}
