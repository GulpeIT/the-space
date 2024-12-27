using Godot;

namespace TheSpace.scripts.classes.state_machine
{
    public class State
    {
        public State GetState() => this;
        
        public void Init() {}
        public void PhysicUpdate() {}
        public void ProcessUpdate() {}
        public void Remove() {}
    }
}