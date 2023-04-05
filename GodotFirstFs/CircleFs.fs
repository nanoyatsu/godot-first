namespace GodotFirstFs

open Godot

type CircleFs() =
    inherit Sprite2D()

    let speed = 400
    let angularSpeed = Mathf.Pi

    override this._Process delta =
        this.Rotation <- this.Rotation + (angularSpeed * (float32 delta))
        let velocity = (Vector2.Up.Rotated this.Rotation) * (float32 speed)
        this.Position <- this.Position + (velocity * (float32 delta))
