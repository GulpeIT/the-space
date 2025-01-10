using Godot;

namespace TheSpace.Classes.StateMachine
{
    public abstract partial class State : Node
    {
        public abstract void Init();
        
        public abstract void Delete();
        
        public virtual void Update(double delta) {}
        
        public virtual void UpdatePhysics(double delta) {}
        
        public virtual void UpdateByInput(InputEvent @event) {}
    }
}