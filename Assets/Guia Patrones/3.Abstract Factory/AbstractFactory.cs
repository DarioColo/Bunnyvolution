using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//3ª CLASE
//Intermediario. Accede a las partes concretas y devuelve un producto
public abstract class AbstractFactory {
    
    //Fabricas concretas que abarcan un "tema"
    public abstract IShape GetShape(string s);
    public abstract IColor GetColor(string c);
}
public abstract class AbstractFactory1 //PracticaPRE1
{
    public abstract IShape1 GetShape(string shape);
    public abstract IColor1 GetColor(string color);
}
public abstract class FactoriaAbstracta
{
    public abstract IShape3 GetShape(string s);
}
