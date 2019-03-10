using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    ArmaConstructor arma1;
    ArmaConstructor arma2;

    public void Start()
    {
        arma1 = new ArmaConstructor(50, this.transform);
        arma2 = new ArmaConstructor(100, transform);
    }
}
