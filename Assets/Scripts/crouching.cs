using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouching : MonoBehaviour
{    public SpriteRenderer SpriteR;
    public Sprite standingsprite;
    public Sprite crouchingsprite;
    public BoxCollider2D collider2D;

    public Animator animator;
    
    public Vector2 standingsize;
    public Vector2 crouchingsize;
    // Start is called before the first frame update
    void Start()
    {
        collider2D=GetComponent<BoxCollider2D>();
        SpriteR= GetComponent<SpriteRenderer>();
        SpriteR.sprite=standingsprite;
        standingsize=collider2D.size;
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Crouch"))
        {   animator.enabled = false;
            SpriteR.sprite=crouchingsprite;
            collider2D.size=crouchingsize;
        }
        if(Input.GetButtonUp("Crouch"))
        {   animator.enabled = true;
            SpriteR.sprite=standingsprite;
            collider2D.size=standingsize;
        }     
    }
}
