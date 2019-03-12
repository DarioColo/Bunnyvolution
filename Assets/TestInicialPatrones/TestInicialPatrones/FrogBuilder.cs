using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogBuilder : MonoBehaviour , IBuilder
{
    public Entity frog;
    public int life;
    public int damage;
    public int speed;

    public FrogBuilder (Entity prefab)
    {
        frog = prefab;
    }
    public FrogBuilder SetName(string _name)
    {
        gameObject.name = _name;
        return this;
    }
    public FrogBuilder SetLife(int _life)
    {
        life = _life;
        return this;
    }
    public FrogBuilder SetDamage(int _damage)
    {
        damage = _damage;
        return this;
    }
    public FrogBuilder SetSpeed(int _speed)
    {
        speed = _speed;
        return this;
    }
    public Entity Finish()
    {
        return frog;
    }
}
