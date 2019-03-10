using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1ª CLASE - Interfaz - suscrpitores
public interface IObserver  {
    void OnNotify(string pass);
}
public interface IObserver1 //PracticaPRE1
{ void OnNotify(string pass); }
public interface IObserver2 //PracticaPre2
{ void OnNotify(string pass); }
public interface IObserver3
{
    void OnNotify(string pass);
}
