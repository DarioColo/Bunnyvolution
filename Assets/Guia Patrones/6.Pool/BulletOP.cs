using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2º CLASE 
//Es mono porque va a interactuar con Unity, haciendo lo que tiene que hacer una bomba.
public class BulletOP : MonoBehaviour, IPoolObject
{
    public void OnAcquire()
    {
        gameObject.SetActive(true);
    }

    public void OnRelease()
    {
        gameObject.SetActive(false);
    }

    //Van el resto de las funciones propias de una  bomba, como explosion.
}
public class EnemyOP : MonoBehaviour, IPoolObject1 //PracticaPRE1
{
    public void OnAcquire() { gameObject.SetActive(true); }
    public void OnRelease() { gameObject.SetActive(false); }
}
