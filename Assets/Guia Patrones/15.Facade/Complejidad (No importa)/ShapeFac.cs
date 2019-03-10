using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFac : MonoBehaviour, IShapeFac
{
    public void Draw()
    {
        print("soy un circulo!");
    }
}
public class RectangleFac : MonoBehaviour, IShapeFac
{
    public void Draw()
    {
        print("soy un rectangulo!");
    }
}
public class TriangleFac : MonoBehaviour, IShapeFac
{
    public void Draw()
    {
        print("soy un triangulo!");
    }
}
