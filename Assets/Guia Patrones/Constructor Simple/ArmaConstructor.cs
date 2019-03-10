using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaConstructor {

    int _ammo;
    Transform _pos;

	public ArmaConstructor(int ammo, Transform pos)
    {
        _ammo = ammo;
        _pos = pos;
    }
}
