using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//3ª CLASE - CLIENTE
public class ManagerComposite : MonoBehaviour {	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Boss boss = new Boss();
            Enemy enemy1 = new Enemy("oscar");
            Enemy enemy2 = new Enemy("pepe");

            boss.Add(enemy1);
            boss.Add(enemy2);
        }
	}
}
public class ManagerComposite1
{
    void Update()
    {
        //if (pasa tal cosa - input, evento, bool...)
        Boss boss = new Boss();
        Bullet newBullet1 = new Bullet();
        Bullet newBullet2 = new Bullet();

        newBullet1.SetLife(10);
        newBullet2.SetName("lolopo");

        //boss.Add(newBullet1); 
        //boss.Add(newBullet2);
    }
}
public class ManagerComposite2 //PracticaPRE2
{
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Boss boss = new Boss();
            Enemy enemy1 = new Enemy("carlos");

            boss.Add(enemy1);
        }
    }
}
public class ManagerComposite3
{
    void Update()
    {
        //cuando apreto una tecla
        Component1 boss = new Component1();
        Enemy enemy1 = new Enemy("carlos");
        //boss.Add(enemy1);
    }
}