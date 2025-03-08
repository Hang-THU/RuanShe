using Godot;
using System;

public partial class LabelTest : Label
{
	private Label _label;
	private float _blinkSpeed = 1.0f;
	private float _timer = 0.0f;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_label = GetNode<Label>("Label(1)");
		Visible = true;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		_timer += (float)delta;
		float alpha = (Mathf.Sin(_timer * _blinkSpeed) + 1) / 2;
		alpha = Mathf.Clamp(alpha, 0.2f, 1.0f);
		_label.Modulate = new Color(1,1,1,alpha);
	}

	public override void _Input(InputEvent @event)
	{
		if((@event is InputEventKey keyEvent && keyEvent.Pressed) ||(@event is InputEventMouseButton mouseevent && mouseevent.Pressed))
		{
			GetTree().ChangeSceneToFile("res://Study(1).tscn");
		}
	}
}
