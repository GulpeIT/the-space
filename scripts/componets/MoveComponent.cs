using Godot;
using TheSpace.Classes;

namespace TheSpace.Components
{
    [GlobalClass]
    public partial class MoveComponent : Node2D
    {
        [Export] public Entity ParentObject { get; set; }
        
        private Vector2 Motion = Vector2.Zero;
        

        public override void _PhysicsProcess(double delta)
        {
            base._PhysicsProcess(delta);            
            Vector2 dir = Input.GetVector("uc_left", "uc_right", "uc_up", "uc_down");

            Motion = dir * 20;
            ParentObject.Velocity = Motion; 
            ParentObject.MoveAndSlide();
        }

        public void DoAcceleration(Vector2 dir)
        {
            
        }
        
    }
}
