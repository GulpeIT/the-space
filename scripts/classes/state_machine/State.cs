namespace TheSpace.Classes.StateMachine
{
    public abstract class State
    {
        public State GetState() => this;
        
        public virtual void Init() {}
        public virtual void PhysicUpdate() {}
        public virtual void ProcessUpdate() {}
        public virtual void Remove() {}
    }
}