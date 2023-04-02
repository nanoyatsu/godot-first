extends Node2D


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass

func _draw():
	var label = Label.new()
	var font = label.get_theme_font("")
	draw_string(font, Vector2(200,100), "Hello, World!?")
	
