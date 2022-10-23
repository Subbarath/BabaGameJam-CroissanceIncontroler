using Godot;
using System.Collections.Generic;

public partial class normal_pumpkin : StaticBody2D
{
	[Export]
	private AnimatedSprite2D _pumpkinSprite;

	MainScene mainScene;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		mainScene = GetParent<MainScene>();
		List<Vector2> brambles = new List<Vector2>(){Vector2.Up,Vector2.Down,Vector2.Left,Vector2.Right};
		foreach(Vector2 dir in brambles){
			mainScene.PlaceTiles(GlobalPosition + dir*16,true);
		}
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void Destroyed(){
		_pumpkinSprite.Animation = "Death";
	}

}
