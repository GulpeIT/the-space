using Godot;
using Godot.Collections;

namespace TheSpace.Classes.StateMachine
{
    [GlobalClass]
    public partial class StateMachine : Node
    {
        // Список состояний, которые находятся 
        // под дочернем контролем StateMachine 
        // <Названия узла состояния, состояние>
        [Export]
        public Dictionary<string, State> StateList = new Dictionary<string, State>();
        
        private State CurrentState;


        public override void _Ready()
        {
            // Добавляет все дочерние состояния в словарь
            foreach (State state in GetChildren())
            {
                StateList.Add(state.Name, state);
            }
        }

        /// <summary>
        /// Определение исходного состояния.
        /// </summary>
        /// <param name="initState"> Исходное состояние </param>
        public void InitState(State initState)
        {
            CurrentState = initState;
            CurrentState.Init();
        }

        /// <summary>
        /// Смена состояния на новое
        /// </summary>
        /// <param name="newState"> Новое состояние </param>
        public void UpdateState(State newState)
        {
            CurrentState.Delete();
            CurrentState = newState;
            CurrentState.Init();
        }

        public override void _PhysicsProcess(double delta)
        {
            CurrentState.UpdatePhysics(delta);
        }
        public override void _Process(double delta)
        {
            CurrentState.Update(delta);
        }
        public override void _Input(InputEvent @event)
        {
            CurrentState.UpdateByInput(@event);
        }
    }
}