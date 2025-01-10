using Godot;

namespace TheSpace.Classes
{
    public partial class Ship : Entity
    {
        public enum ShipType
        {
            SPACE_POD = 5,
            SMALL = 4,
            MEDIUM = 3,
            LARGE = 2,
            PLANETARY = 1
        }
        public enum ReactorType
        {
            NUCLEAR = 1,
            ANTIMATERIAL = 2,
            STAR = 3
        }

        [Export] public ShipType CurrentShipType { get; set; }
        [Export] public ReactorType CurrentReactorType { get; set; }

        [ExportCategory("Ship Movement")]
        [Export] public float MaxSpeed { get; set; }
        [Export] public float Acceleration { get; set; }
        [Export] public float RotationMaxSpeed { get; set; }
        [Export] public float RotationAcceleration { get; set; }

        [ExportCategory("Ship Energy")]
        [Export] public float EnergyOutput { get; set; }
        [Export] public float EnergyStorage { get; set; }
        [Export] public float PowerConsumption { get; set; }


        public Ship()
        {
            CurrentShipType = ShipType.SPACE_POD;
            CurrentReactorType = ReactorType.NUCLEAR;
        }
    }
}