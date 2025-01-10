using Godot;

namespace TheSpace.Resources
{
    [GlobalClass][Tool]
    public partial class ShipStats : Resource
    {
        public enum ShipType
        {
            SMALL = 4,
            MEDIUM = 3,
            LARGE = 2,
            PLANETARY = 1
        }
        public enum ReactorType
        {
            A = 1,
            B = 2,
            c = 3
        }

        [Export]
        public ShipType CurrentShipType { get; set; }

        [Export]
        public float Speed { get; set; }
        [Export]
        public float Acceleration { get; set; }
        [Export]
        public float RotationSpeed { get; set; }
        
        [Export]
        public float Health { get; set; }
        [Export]
        public float Armor { get; set; }

        [Export]
        public float EnergyOutput { get; set; }
        [Export]
        public float EnergyStorage { get; set; }
        [Export]
        public ReactorType CurrentReactorType { get; set; }

        public ShipStats()
        {
            CurrentShipType = ShipType.SMALL;

            Speed = 0;
            Acceleration = 0;
            RotationSpeed = 0;

            Health = 0;
            Armor = 0;

            EnergyOutput = 0;
            EnergyStorage = 0;

            CurrentReactorType = ReactorType.A;
        }
    }
}