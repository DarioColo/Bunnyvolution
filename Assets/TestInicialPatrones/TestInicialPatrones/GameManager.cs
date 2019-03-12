using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<SpawnPoint> SpawnPoints = new List<SpawnPoint>();
    public Entity frog;

    void Awake()
    {
        SpawnPoints.Add(new SpawnPoint());
        SpawnPoints[0].ammount = 10;
        EntityPool test = new EntityPool();
        FrogBuilder builder = new FrogBuilder(frog);
        // linQ para aislar la cantidad de cada enemigo k hace falta
        for (int i = 0; i < SpawnPoints[0].ammount; i++)
        {
            test.Fill(builder
                       .SetLife(Random.Range(10, 15))
                       .SetDamage(Random.Range(10, 15))
                       .SetSpeed(Random.Range(10, 15))
                       .SetName("testfrog")
                       .Finish());
        }
        test.Fill
    }
}
