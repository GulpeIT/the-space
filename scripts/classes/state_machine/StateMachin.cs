using Godot;

namespace TheSpace.Classes.StateMachine
{
    public partial class StateMachine : Node2D
    {
        private State CurrentState;

        public void InitState(State initState)
        {
            CurrentState = initState;
            CurrentState.Init();
        }
        public void UpdateState(State newState)
        {
            CurrentState = newState;
            CurrentState.Remove();
        }

        public override void _PhysicsProcess(double delta)
        {
            CurrentState.PhysicUpdate();            
        }
        public override void _Process(double delta)
        {
            CurrentState.ProcessUpdate();
        }
    }
}