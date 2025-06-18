using Godot;
using System;

public partial class RightEdgeCollision : Area2D
{
	// area RNG initialization
	Random intPotentialArea = new Random();
		
	// right edge handler
	[Signal]
	public delegate void RightEdgeCollidedEventHandler();
	
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
	
	// right edge collision
	public void Collision(Node2D Player){
		// area RNG
		int intArea = intPotentialArea.Next(1, 11);
		// case statement for area
		switch(intArea)
		{
			case 1:
				// goes to Forest1
				GetTree().ChangeSceneToFile("res://Forest1.tscn");
				break;
			case 2:
				// goes to Beach1
				GetTree().ChangeSceneToFile("res://Beach1.tscn");
				break;
			case 3:
				// goes to SnowPlain1
				GetTree().ChangeSceneToFile("res://SnowPlain1.tscn");
				break;
			case 4:
				// goes to Forest1
				GetTree().ChangeSceneToFile("res://Forest2.tscn");
				break;
			case 5:
				// goes to Beach1
				GetTree().ChangeSceneToFile("res://Beach2.tscn");
				break;
			case 6:
				// goes to SnowPlain1
				GetTree().ChangeSceneToFile("res://SnowPlain2.tscn");
				break;
			case 7:
				// goes to Forest1
				GetTree().ChangeSceneToFile("res://Forest3.tscn");
				break;
			case 8:
				// goes to Beach1
				GetTree().ChangeSceneToFile("res://Beach3.tscn");
				break;
			case 9:
				// goes to SnowPlain1
				GetTree().ChangeSceneToFile("res://SnowPlain3.tscn");
				break;
			case 10:
				// goes to Temple
				GetTree().ChangeSceneToFile("res://Temple.tscn");
				break;
		}
	}
}
