using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{
    float speed = 10;
    public float direction;
    public Transform target;
    public GameObject targeta;

    private void Start()
    {
        target = transform.Find("/Player");
    }

    void DirectionShoot()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    private void Update()
    {
        DirectionShoot();
    }
}
