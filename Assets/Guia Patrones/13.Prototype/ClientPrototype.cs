using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//3ª CLASE
public class ClientPrototype : MonoBehaviour {
	void Start () {
        MonsterPrototype ghost = new MonsterPrototype();
        ghost.type = "ghost";
        ghost.velcity = 5;

        MonsterPrototype ghostMejorado = ghost.Clone() as MonsterPrototype;
        ghostMejorado.position = new Vector3(1, 1, 1);

        print("GHOST " + ghost.type);
        print("GHOST MEJORAD " + ghostMejorado.type + " posicion: " + ghostMejorado.position);
	}
}
public class ClientPrototype1 //PracticaPRE1
{
    void Start()
    {
        HeroPrototype _caballero = new HeroPrototype();
        _caballero.type = "caballero";
        _caballero.velocity = 1;

        HeroPrototype _caballero2 = _caballero.Clone() as HeroPrototype;
    }
}
public class ClientPrototype2 //PracticaPRE2
{
    void Start()
    {
        LevelPrototype level1 = new LevelPrototype();
        level1.levelName = "calabozo";
        level1.goldAmmount = 100;

        LevelPrototype level2 = level1.Clone() as LevelPrototype;
    }
}
