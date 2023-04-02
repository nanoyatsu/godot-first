using Godot;
using GodotFirstFs;

namespace GodotFirst;

public partial class HelloWorld : MyNode
{
    public override void _Ready()
    {
        base._Ready();
        GD.Print("Csharp ready");
    }

    public override void _Draw()
    {
        base._Draw();
        GD.Print("Csharp Draw");
    }
}