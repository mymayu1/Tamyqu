using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocityX = 5f;
    float velocityY = 0f;
    Rigidbody2D rb;
    public float lives = 1;
    GameObject enemy;
    public float bulletTime = 1f;


    // Enemy Tag wird bei Kollision mit Kugel zerstoert
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // Kugel zerstoert sich nach BulletTime selbst
    void Update()
    {
        rb.velocity = new Vector2(velocityX, velocityY);
        Destroy(gameObject, bulletTime);
    }

}
