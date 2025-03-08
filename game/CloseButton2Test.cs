using Godot;
using System;

public partial class CloseButton2Test : TextureButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.Visible = false;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void CloseFile()
	{
		this.Visible = false;
		Node root = this.GetTree().CurrentScene;
		Sprite2D node = (Sprite2D)root.FindChild("FileBackground");
		node.Visible = false;
		//用foreach语句无法有效更改显示状态
		Sprite2D temp1 = (Sprite2D)root.FindChild("1富商");
		temp1.Visible = false;
		Sprite2D temp2 = (Sprite2D)root.FindChild("2妻子");
		temp2.Visible = false;
		Sprite2D temp3 = (Sprite2D)root.FindChild("3合伙人");
		temp3.Visible = false;
		Sprite2D temp4 = (Sprite2D)root.FindChild("4女儿金伊一");
		temp4.Visible = false;
		Sprite2D temp5 = (Sprite2D)root.FindChild("5女儿男友");
		temp5.Visible = false;
		Sprite2D temp6 = (Sprite2D)root.FindChild("6管家");
		temp6.Visible = false;
		Sprite2D temp7 = (Sprite2D)root.FindChild("7女佣");
		temp7.Visible = false;
		Sprite2D temp8 = (Sprite2D)root.FindChild("8侦探");
		temp8.Visible = false;
		Sprite2D temp9 = (Sprite2D)root.FindChild("9宋延好友");
		temp9.Visible = false;
	}
}
