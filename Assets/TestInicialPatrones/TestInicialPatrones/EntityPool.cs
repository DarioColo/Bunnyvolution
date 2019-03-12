using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityPool : MonoBehaviour, IPoolObject
{
    List<Entity> Pool = new List<Entity>();

    public void PlaceOnScene(Entity entity, Vector3 position)
    {
        for (int i = 0; i < Pool.Count; i++)
            if (!Pool[i].isActiveAndEnabled)
            {
                Pool[i].gameObject.SetActive(true);
                Pool[i].transform.position = position;
            }
         else
            {
                Fill(Pool[Random.Range(0, Pool.Count)]); // esto va a traer problemas, quizas usar prototype
                PlaceOnScene(entity, position);
            }
    }
    public void StoreAndReset(Entity entity)
    {
        entity.gameObject.SetActive(false);
        entity.Reset();
    }
    public void Fill (Entity sample)
    {
        Instantiate(sample);
        Pool.Add(sample);
        StoreAndReset(sample);
    }
}
