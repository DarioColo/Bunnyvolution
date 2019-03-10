using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fachada : MonoBehaviour { //Shape Market

    IShapeFac _circle;
    IShapeFac _rectangle;

    void Start()
    {
        _circle = new CircleFac();
        _rectangle = new RectangleFac();
    }

    public void DrawCircle() { _circle.Draw(); }
    public void DrawRectangle() { _rectangle.Draw(); }
}
