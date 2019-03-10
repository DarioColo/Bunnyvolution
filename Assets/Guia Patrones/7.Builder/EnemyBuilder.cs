using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBuilder : MonoBehaviour { //Mono por si hay que acceder al gameobject para modificarlo

    //Variables del constructor.
    public string myName;
    public float myLife;

    public EnemyBuilder SetName(string name)
    {
        gameObject.name = name; //modifica el nombre de go. meh.
        myName = name;
        return this;
    }
    public EnemyBuilder SetLife(float life)
    {
        myLife = life;
        return this;
    }
}
public class BossBuilder : MonoBehaviour //PracticaPRE1
{
    public string bossName;
    public int bossLife;
    public BossBuilder SetName(string name)
    {
        gameObject.name = name;
        bossName = name;
        return this;
    }
    public BossBuilder SetLife(int life)
    {
        bossLife = life;
        return this;
    }
}
public class HeroBuilder : MonoBehaviour //PracticaPRE2
{
    public int heroLife;
    public int heroGun; //Clase del arma (o interfaz)

    public HeroBuilder SetLife(int life) { heroLife = life; return this; }
    public HeroBuilder SetGun(int gunID) {
        if (gunID == 1) heroGun = 1; //la clase del arma
        return this;
    }
}

