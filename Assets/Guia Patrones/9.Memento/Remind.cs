using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//4ª CLASE
public abstract class Remind : MonoBehaviour { //Mono para hero, que va a heredar de Remind
    protected MementoState memento; //Pa que todos los hijos accedan

    public abstract void BeRemind(ParamsMemento wrappers);
    public abstract IEnumerator StartToRec();
    public void Action()
    {
        BeRemind(memento.Remember()); //Funcion que llamamos al detonar el rewind
    }
}
