using System.Numerics;
using Godot;

public partial class PlayerTank : CharacterBody2D
{
	// Player Variables ---
	[Export]
	public int MoveSpeed { get; set; } = 40;
	public override void _PhysicsProcess(double delta)
    {
		var velocity = Velocity;

		// Player Input ---
		var up = Input.IsActionPressed("playerUpArrow");
		var down = Input.IsActionPressed("playerDownArrow");
		var left = Input.IsActionPressed("playerLeftArrow");
		var right = Input.IsActionPressed("playerRightArrow");
		
		// Basic Movement ---
		if (up)
		{
			velocity.Y -= MoveSpeed;
		}
		else if (down)
		{
			velocity.Y += MoveSpeed;
		}
		else
		{
			velocity.Y = Mathf.MoveToward(Velocity.Y, 0, 5);
		}
		
		if (left)
		{
			velocity.X -= MoveSpeed;
		}
		else if (right)
		{
			velocity.X += MoveSpeed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, 5);
		}

		Velocity = velocity;
		MoveAndSlide();
	}

    public override void _Ready()
    {
    }
}
