using Godot;
using TheSpace.Resources;

namespace TheSpace.Classes
{
    public partial class Ship : CharacterBody2D
    {
        [Export]
        public ShipStats Stats;
        [Export]
        public string ShipTitle = "";

        public override void _Ready()
        {

        }

        public override void _PhysicsProcess(double delta)
        {

        }

        public override void _Process(double delta)
        {

        }
    }
}