using Godot;
using TheSpace.Classes.StateMachine;

public partial class FlightState : State
{
    [Export]
    public PlayerPod playerPod;

    public override void Init()
    {
        GD.Print("FlightState init");
    }

    public override void Delete()
    {
        GD.Print("FlightState Delete");
    }

    public override void UpdateByInput(InputEvent @event)
    {
        if (Input.IsKeyPressed(Key.Shift))
        {
            playerPod.SM.UpdateState(playerPod.SM.StateList["IdleState"]);
        }
    }
}
