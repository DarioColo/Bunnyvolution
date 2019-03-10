using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1º CLASE
//Abstracta - porque no seeee - La usan todos lo que sean controllers (mouse, teclado, joysticks, etc)
public abstract class IController {
    public abstract void OnUpdate();
}
