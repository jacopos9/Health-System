using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform player;

    private void Start()
    {
      
    }

    void Restart()
    {
        player.transform.position = new Vector3(0, 0, 0);
    }

    public Vector3 Position(Vector3 pos)
    {
        
        
        return pos;
    }

    public void Update()
    {
        //Restart();
        
    }

    // restrt position 
    /// 

}
