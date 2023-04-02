namespace GodotFirstFs

open Godot

type MyNode() =
    inherit Node2D()
    override this._Ready() =
        GD.Print "Hello World by FSharp _Ready()!!"
        
    override this._Process delta = ()
        
    override this._Draw() =
        base._Draw()
        let label = new Label()
        let font = label.GetThemeFont ""
        let pos = Vector2(200f,100f)
        this.DrawString(font, pos, "Hello World by Fsharp!!"
                        // HorizontalAlignment.Left -1f 16 null (TextServer.JustificationFlag.Kashida or TextServer.JustificationFlag.WordBound) TextServer.Direction.Auto TextServer.Orientation.Horizontal
                        )