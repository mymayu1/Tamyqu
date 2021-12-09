using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 1;
    public float jumpForce = 1;
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;

    private Rigidbody2D rBody;

    private bool facingRight = true;

    private bool isJumping;

    //public int diamondCounter;
    //public Text diamondText;
    public float ground;

    public float bulletSpeed = 500f;
    public GameObject bulletToRight, bulletToLeft;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;

    public Transform keyFollowPoint;

    public Key followingKey;

    private BonusDoor bonusDoor;

    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        //diamondCounter = 0;
        bonusDoor = FindObjectOfType<BonusDoor>();

    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * runSpeed;

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            soundmanager.PlaySound("jump");

            rBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
        changeDirection(movement);

        //Wenn "," gedrückt, wird geschossen und AmmoText wird abgezogen + es kann nur geschossen werden wenn der AmmoCounter nicht kleiner als null ist
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire && AmmoText.ammoAmount > 0)
        {
            AmmoText.ammoAmount -= 1;
            nextFire = Time.time + fireRate;
            fire();
        }

        // Restart scene wenn R gedrückt wird + der AmmoCounter wird auf 0 gestellt
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
            AmmoText.ammoAmount = 0;
            DiamondText.diamondAmount = 0;
            //diamondCounter = 0;
            //diamondText.text = diamondCounter.ToString();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    void Flip()
    {
        //flip the character image if the direction that the character is facing is changed
        facingRight = !facingRight;
        transform.rotation = Quaternion.Euler(0, facingRight ? 0 : 180, 0);
    }
    void changeDirection(float horizontal)
    {
        if ((horizontal > 0 && !facingRight) || (horizontal < 0 && facingRight))
        {
            Flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        //if (other.CompareTag("Door"))
        //{
        //    if (bonusDoor.doorOpen == true)
        //    {
        //        DiamondText.diamondAmount -= 10;
        //    }
        //}
    }

    //wenn nach rechts geguckt wird = Kugel rechts, else links
    void fire()
    {
        bulletPos = transform.position;
        if (facingRight)
        {
            bulletPos += new Vector2(+1f, -0.1f);
            soundmanager.PlaySound("shoot");
            Instantiate(bulletToRight, bulletPos, Quaternion.identity);
        }
        else
        {
            bulletPos += new Vector2(-1f, -0.1f);
            soundmanager.PlaySound("shoot");
            Instantiate(bulletToLeft, bulletPos, Quaternion.identity);
        }
    }
}
