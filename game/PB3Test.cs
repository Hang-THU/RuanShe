using Godot;
using System;

public partial class PB3Test : TextureButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void GetCharacterFile()
	{
		Node root = this.GetTree().CurrentScene;
		Sprite2D node = (Sprite2D)root.FindChild("FileBackground");
		node.Visible = true;
		TextureButton node1 = (TextureButton)root.FindChild("CloseButton2");
		node1.Visible = true;
		Sprite2D node2 = (Sprite2D)root.FindChild("3合伙人");
		node2.Visible = true;
	}
}
