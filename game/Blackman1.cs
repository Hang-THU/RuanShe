using Godot;
using System;
using Basicsettings;
public partial class Blackman1 : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Base.CharacterVisibility[(int)GameEnum.characterEnum.WangXiangyu] == true)
		{
			this.Visible = false;
		}
	}
}
