using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1º CALSE - Interfaz
public interface IPoolObject  {
    void PlaceOnScene(Entity entity,Vector3 position); //Al guardar los obj
    void StoreAndReset(Entity entity); //Al activar los obj
}
public interface IPoolObject1 //PracticaPRE1
{
    void OnAcquire();
    void OnRelease();
}
