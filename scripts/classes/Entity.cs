using Godot;

namespace TheSpace.Classes
{
    public abstract partial class Entity : CharacterBody2D
    {
        [Export]
        public virtual float CurrentHealth { get; set; }        
        [Export]
        public virtual float MaxHealth { get; set; }
        [Export]
        public virtual float CurrentArmor { get; set; }
        [Export]
        public virtual float MaxArmor { get; set; }

        /// <summary>
        /// Delete Entity from scene
        /// </summary>
        public virtual void Destroy() => QueueFree();
    }
}