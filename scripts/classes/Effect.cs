using Godot;

namespace TheSpace.scripts.classes
{
    public interface Effect
    {
        public string Name { get; set; }
        public float Damage { get; set; }
        public float Reflection { get; set; }
        public float Armor { get; set; }
        public enum EffectType { DeBuff, Buff }

    }
}