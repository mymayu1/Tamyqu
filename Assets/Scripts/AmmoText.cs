using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour
{
    Text text;
    public static int ammoAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    // Wenn eine Kugel eingesammelt wird, Counter erhoehen
    void Update()
    {
        if (ammoAmount > 0)
        {
            text.text = "" + ammoAmount;
        }
        // Wenn der Counter = 0 ist, wird folgender Text angezeigt
        else
        {
            text.text = "Out of Ammo!";
        }
       
    }
}
