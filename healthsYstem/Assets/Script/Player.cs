using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 5.0f;

    public int health;
    public int maxHealth = 111;
    public int minHealth = 0;
    public HealthBar1 healthBar;
    public Transform startPoition;
    public Vector3[] respawnPos = new Vector3[2];
    public GameObject respownPoint;


    private void Start()
    {
        health = maxHealth;
        respawnPos[0] = new Vector3(1, 1, 0);
    }


    void InputMovement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 motion = new Vector3(h, 0, v) * speed * Time.deltaTime;
        transform.Translate(motion);
    }

    void SetHealth()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }

        if (health < minHealth)
            health = minHealth;
    }

    void PositionBar()
    {
        //healthBar.transform.position = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            OnTakeDamage(1);

            Respawn();

        }
    }

    void Respawn()
    {
        transform.position = respownPoint.transform.position;
    }


    void OnTakeDamage(int damage)
    {
        health -= damage;
        healthBar.SetHealth(health);
    }

    void Update()
    {
        InputMovement();
        SetHealth();
        PositionBar();
    }
}
