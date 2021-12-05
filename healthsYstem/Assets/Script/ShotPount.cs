using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPount : MonoBehaviour
{
    public GameObject bullet;
    public Transform target;
    public float timeToShoot = 0.0f;
    public float goShoot = 2.0f;
    void InstantiateShoot()
    {
        Instantiate(bullet,transform.position, transform.rotation);
    }

    void ShootLogic()
    {
        timeToShoot += Time.deltaTime;
        if (timeToShoot >= goShoot)
        {
            InstantiateShoot();
            timeToShoot = 0.0f;
        }
    }

    private void Update()
    {
        ShootLogic();
        transform.LookAt(target);
    }
}
