using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClienteFac : MonoBehaviour { //El punto es usar la complejidad de forma sencilla, simplemente llamando las funciones del shape market.

    Fachada _shapemarket = new Fachada();

	void Start () {
        _shapemarket.DrawCircle();
        _shapemarket.DrawRectangle();
	}
}
