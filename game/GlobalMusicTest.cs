using Godot;
using System;

public partial class GlobalMusicTest : AudioStreamPlayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if(!Playing)
		{
			Connect("finished", new Callable(this, nameof(OnAudioFinished)));
			Play();
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void OnAudioFinished()
	{
		Play();
	}
}
