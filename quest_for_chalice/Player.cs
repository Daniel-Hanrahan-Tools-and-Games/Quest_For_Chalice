using Godot;
using System;

public partial class Player : CharacterBody2D
{
	// initialization for animation
	private AnimatedSprite2D PlayerAnimation;
	
	// initialization for dblSpeed dblJumpVelocity and dblGravity
	public const float dblSpeed = 200f;
	public const float dblJumpVelocity = -500f;
	public const float dblGravity = 500f;
	
	public float dblMoveLock = 0f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// player animation
		PlayerAnimation = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		Vector2 vel = Velocity;
		
		// checks if player is on floor and what happens when not on ground
		if(!IsOnFloor()){
			vel.Y += dblGravity * (float)delta;
			// stops animation
			PlayerAnimation.Stop();
		}
		
		// Move lock is set to unlock when on ground
		if(IsOnFloor()){
			dblMoveLock = 0f;
		}
		
		// jump physics
		if(Input.IsActionJustPressed("Jump") && IsOnFloor()){
			vel.Y = dblJumpVelocity;
			dblMoveLock = 1f;
		}
		
		// if statements for animation
			if (Input.IsActionPressed("Right"))
			{
				// Makes sure player cannot move while jumping
				if (dblMoveLock != 1){
					// flips sprite
					PlayerAnimation.FlipH = false;
					// plays animation
					PlayerAnimation.Play("walk");
					// move to right
					vel.X = dblSpeed;
				}
			}
			else if (Input.IsActionPressed("Left"))
			{
				// Makes sure player cannot move while jumping
				if (dblMoveLock != 1){
					// flips sprite
					PlayerAnimation.FlipH = true;
					// plays animation
					PlayerAnimation.Play("walk");
					// move to left
					vel.X = -dblSpeed;
				}
			}
			else
			{
				// Makes sure player cannot move while jumping
				if (dblMoveLock != 1){
					// stops animation
					PlayerAnimation.Stop();
					// stops player
					vel.X = 0;
				}
			}
			// neccessary movement code
			Velocity = vel;
			MoveAndSlide();
		
	}
}
