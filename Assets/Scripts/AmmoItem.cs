using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoItem : MonoBehaviour
{
    // Wenn das Item mit einem Player Tag kollidiert, wird der Counter um 1 erh?ht und die Kugel zerst?rt
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag.Equals ("Player"))
        {   
            AmmoText.ammoAmount += 3;
            Destroy(gameObject);

            soundmanager.PlaySound("AppleSound");
        }
    }
}
