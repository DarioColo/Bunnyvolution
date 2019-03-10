using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2ª CLASE
public class MonsterPrototype : IPrototype //Prototipo de Objeto/
{
    public string type;
    public float velcity;
    public Vector3 position;

    public object Clone() //Accion clonar
    {
        MonsterPrototype newMonster = new MonsterPrototype();

        //Se copia el estado al nuevo clone
        newMonster.type = this.type;
        newMonster.velcity = this.velcity;
        newMonster.position = this.position;

        return newMonster; //Devuelvo el clone!
    }
}
public class HeroPrototype : IPrototype1 //PracticaPRE1
{
    public string type;
    public float velocity;
    public Vector3 position;
    public object Clone()
    {
        HeroPrototype newHero = new HeroPrototype();
        newHero.type = this.type;
        newHero.velocity = this.velocity;
        newHero.position = this.position;
        return newHero;
    }
}
public class LevelPrototype : IPrototype2 //PracticaPRE2
{
    public string levelName;
    public int goldAmmount;

    public object Clone()
    {
        LevelPrototype newLevel = new LevelPrototype();
        newLevel.levelName = this.levelName;
        newLevel.goldAmmount = this.goldAmmount;
        return newLevel;
    }
}
