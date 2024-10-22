using Godot;
using System;

public partial class splash_screen : ColorRect
{
    public override void _Ready()
    {
        GetNode<Timer>("Timer").Timeout += ()=>GetNode<SceneLoader>("/root/SceneLoader").ChangeToScene("main_menu.tscn");
    }
}
