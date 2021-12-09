using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{

    private Rigidbody2D rb2_Platform;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        rb2_Platform = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "Player")
        {
            // falling platform
            StartCoroutine(Fall());
        }
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(delay);
        rb2_Platform.isKinematic = false;
    }
}
