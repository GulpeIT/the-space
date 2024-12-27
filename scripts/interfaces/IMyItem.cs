using Godot;

namespace TheSpace.scripts.interfaces
{
    public interface IMyItem
    {
        int Id { get; }
        
        Node PickUp();
        void ThrowDown(Vector2 position);
    }
}