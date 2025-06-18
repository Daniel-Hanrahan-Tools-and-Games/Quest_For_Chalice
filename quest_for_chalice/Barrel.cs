using Godot;
using System;

public partial class Barrel : Area2D
{
	// initialization for animation
	private AnimatedSprite2D BarrelAnimation;
	
	// initializes movement
	public float moveSpeed = -100.0f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// signal prep
		BodyEntered += Collision;	
		
		// Barrel animation
		BarrelAnimation = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// tells barrels to move left
		Position += new Vector2(moveSpeed * (float)delta, 0);
		
		// plays animation
		BarrelAnimation.Play("roll");
	}
	
	public void Collision(Node2D Player){
		// goes to main menu
		GetTree().ChangeSceneToFile("res://MainMenu.tscn");
	}
	
}
