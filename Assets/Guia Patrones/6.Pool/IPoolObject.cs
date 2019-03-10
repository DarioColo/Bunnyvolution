using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1º CALSE - Interfaz
public interface IPoolObject  {
    void OnAcquire(); //Al guardar los obj
    void OnRelease(); //Al activar los obj
}
public interface IPoolObject1 //PracticaPRE1
{
    void OnAcquire();
    void OnRelease();
}
