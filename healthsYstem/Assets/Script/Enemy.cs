using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float speed = 0.1f;
    Vector3 ActualPosition;
    public GameObject bullet;
    public Transform shootPoint;
    public float timeToShoot = 0.0f;
    public float goShoot = 2.0f;


    void FollowPlayer()
    {

        Vector3 positionTarget = Vector3.Lerp(transform.position, player.transform.position, speed);
        transform.position = positionTarget;

    }

    void ShootLogic()
    {
        timeToShoot += Time.deltaTime;
        if(timeToShoot >= goShoot)
        {
            InstantiateShoot();
            timeToShoot = 0.0f;
        }

    }

    void InstantiateShoot()
    {
        Instantiate(bullet, shootPoint.transform.position, transform.rotation);
    }

    void Update()
    {
       // FollowPlayer();
        //ShootLogic();

        //shootPoint.transform.LookAt(player);
    }
}
