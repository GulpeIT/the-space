using Godot;
using TheSpace.scripts.interfaces;

public partial class cup_of_beer : Node, IMyItem
{
    int IMyItem.Id => 1;

    public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
	}

    public Node PickUp()
    {
		return this;
    }

    public void ThrowDown(Vector2 position)
    {

    }	
}
