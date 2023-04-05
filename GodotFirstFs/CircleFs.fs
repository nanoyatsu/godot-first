namespace GodotFirstFs

open Godot

type CircleFs() =
    inherit Sprite2D()

    let speed = 400
    let angularSpeed = Mathf.Pi

    override this._Process delta =
        let direction =
            if Input.IsActionPressed "ui_left" then -1
            elif Input.IsActionPressed "ui_right" then 1
            else 0

        this.Rotation <- this.Rotation + (angularSpeed * (float32 delta)) * float32 direction
        let velocity = (Vector2.Up.Rotated this.Rotation) * (float32 speed)

        if Input.IsActionPressed "ui_up" then
            this.Position <- this.Position + (velocity * (float32 delta))
        elif Input.IsActionPressed "ui_down" then
            this.Position <- this.Position - (velocity * (float32 delta))
