using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBuilder : MonoBehaviour {

    public string newName; //pa edita no ma
    public float newLife;

    public EnemyBuilder prefab;

	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            EnemyBuilder newEnemy = Instantiate(prefab);
            newEnemy.SetLife(newLife);
            newEnemy.SetName(newName);
        }
	}
}
public class ManagerBuilder1 : MonoBehaviour //PracticaPRE1
{
    public BossBuilder prefab;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            BossBuilder newBoss = Instantiate(prefab).SetLife(10).SetName("cocos");
        }
    }
}
public class ManagerBuilder2 : MonoBehaviour //PracticaPRE2
{
    public HeroBuilder prefab;
    void Update()
    {
        if (Input.GetMouseButton(0)) { HeroBuilder newHero = Instantiate(prefab).SetLife(10).SetGun(1); }
    }
}
