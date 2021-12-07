using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointRespawn : MonoBehaviour
{
    /// classe che si occupa di respawnare il giocatore

    // detectare il trigger

    public bool isActive = false;
    public new Light light;
    public Color notActiveColor = Color.red;
    public Color isActiveColor = Color.green;

    private void Start()
    {
        light.color = notActiveColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isActive = true;
        }
    }

    public GameObject AddingObject(GameObject thiss)
    {
        if (isActive)
        {
            //return this.gameObject;
            return thiss;
        }
        else return null;
    }

    void BehaviourCheckPoint()
    {
        if (isActive) light.color = isActiveColor;
    }

    private void Update()
    {
        BehaviourCheckPoint();
    }

}
