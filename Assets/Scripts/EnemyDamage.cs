using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            soundmanager.PlaySound("enemy");
            collision.GetComponent<Health>().TakeDamage(damage);
    }

}
