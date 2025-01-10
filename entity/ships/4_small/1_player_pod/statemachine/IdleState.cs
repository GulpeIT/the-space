using Godot;
using TheSpace.Classes.StateMachine;

public partial class IdleState : State
{
    [Export]
    public PlayerPod playerPod;

    public override void Init()
    {
        GD.Print($"Idle state init {Name}");
	}

    public override void Delete()
    {
        GD.Print("Idle state Delete");
    }

    public override void UpdateByInput(InputEvent @event)
    {
        if (Input.IsPhysicalKeyPressed(Key.Space))
		{
			playerPod.SM.UpdateState(playerPod.SM.StateList["FlightState"]);
		}
    }

    public override void UpdatePhysics(double delta)
    {
        base.UpdatePhysics(delta);
        
    }
}
