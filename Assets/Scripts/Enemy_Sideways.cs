using UnityEngine;

public class Enemy_Sideways : MonoBehaviour
{
    [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    private bool movingLeft;
    private float leftEdge;
    private float rightEdge;

    private void Awake()
    {
        leftEdge = transform.position.x - movementDistance;
        rightEdge = transform.position.x + movementDistance;
    }

    private void Update()
    {    

        if (movingLeft)
        {
            if (transform.position.x > leftEdge)
            {   
                transform.rotation=Quaternion.Euler(0,!movingLeft?0:180,0);

                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.y);
            }
            else

                movingLeft = false;
        }
        else
        {
            if (transform.position.x < rightEdge)
            { 
                transform.rotation=Quaternion.Euler(0,!movingLeft?0:180,0);

                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.y);
            }
            else
            {
                movingLeft = true;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
        else if (collision.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
        void Flip(){
        //flip the character image if the direction that the character is facing is changed
        movingLeft =!movingLeft;
        transform.rotation=Quaternion.Euler(0,movingLeft?0:180,0);
    }
    void changeDirection(float horizontal){
        if((horizontal<0 && !movingLeft) || (horizontal>0 && movingLeft)){
            Flip();
        }
    }
}
