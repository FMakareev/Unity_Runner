using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{

    // Одинаковый интервал спавна или разный 
    public bool IsSameDelay;

    // Рандомный объект или разные
    public bool IsRandomObject;
 
    // Если рандомный спавн выключен то спавнится только этот объект
    public GameObject ObjectToSpawn;

    //  Если рандомный спавн включен то спавнится оди из этих объектов
    public GameObject[] ObjectsToSpawn;

    // время до начала спавна объектов
    public float TimeBeforSpawn;
    
    // задержка между спавнами
    public float SpawnDelay;
    
    // минимальная задержка
    public float MinDelay;

    //  максимальная задержка
    public float MaxDelay;


    void Start () {
        if (IsSameDelay)
        {
                InvokeRepeating("Spawn", TimeBeforSpawn, SpawnDelay);
        }
        else
        {
            StartCoroutine(Spawner());
        }
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(Random.Range(MinDelay, MaxDelay));
        Spawn();
    }

    void Spawn()
    {
        if (!IsRandomObject)
        {
            GameObject obj = Instantiate(ObjectToSpawn, transform.position,transform.rotation) as GameObject;
        } else if (IsRandomObject)
        {
            GameObject obj = Instantiate(ObjectsToSpawn[Random.Range(0,ObjectsToSpawn.Length)], transform.position,transform.rotation) as GameObject;
        }

        if (!IsSameDelay)
        {
            StartCoroutine(Spawner());
        }
    }
}
