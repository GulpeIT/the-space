using Godot;
using TheSpace.Classes;
using TheSpace.Classes.StateMachine;

public partial class PlayerPod : Ship
{
	[Export]
	public StateMachine SM { get; set;}

	public override void _Ready() 
	{
		SM.InitState(SM.StateList["IdleState"]);
	}
}
