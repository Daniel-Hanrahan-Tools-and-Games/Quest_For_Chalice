using Godot;
using System;

public partial class Fireball : Area2D
{
	public float moveSpeed = 100.0f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// signal prep
		BodyEntered += Collision;	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// tells barrels to move left
		Position += new Vector2(0, moveSpeed * (float)delta);
	}
	
	public void Collision(Node2D Player){
		// goes to main menu
		GetTree().ChangeSceneToFile("res://MainMenu.tscn");
	}
}
