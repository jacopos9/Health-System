using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointRespawn : MonoBehaviour
{
    /// classe che si occupa di respawnare il giocatore

    // detectare il trigger

    public bool isActive = false;
    public Light light;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isActive = true;
            
        }
    }

    private void Update()
    {
        if (isActive)
        {
            light.color = Color.green;
        }
    }

}
