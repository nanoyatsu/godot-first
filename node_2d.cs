using Godot;

public partial class node_2d : Node2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }

    public override void _Draw()
    {
        base._Draw();
        var label = new Label();
        var font = label.GetThemeFont("");
        DrawString(font, new Vector2(200, 100), "Hello World by Csharp");
    }
}