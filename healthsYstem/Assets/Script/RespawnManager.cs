using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{

    public List<GameObject> respawnList = new List<GameObject>();
    public PointRespawn pointRespawn;
    int current = 0;
    GameObject containList;

    private void Start()
    {
        pointRespawn = FindObjectOfType<PointRespawn>();

        for (int i = 0; i < respawnList.Count; i++)
        {
            current++;
        }
        
        if (pointRespawn.isActive)
        {
            respawnList.Add(GameObject.Find("RespawnPoint_1"));

        }
    }

    void Add()
    {
        if (pointRespawn.isActive)
        {
            respawnList.Add(GameObject.Find("RespawnPoint_1"));

        }

    }

    private void Update()
    {
       
    }
}
