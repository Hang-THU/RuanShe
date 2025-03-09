using Godot;
using System;

public partial class GuidetoMasterBedroom : TextureButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void ChangeScene()
	{
		SceneTree st = this.GetTree();
		st.ChangeSceneToFile("res://Master_Bedroom.tscn");
	}
}
