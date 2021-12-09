using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondText : MonoBehaviour
{
    Text text;
    public static int diamondAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    // Wenn eine Kugel eingesammelt wird, Counter erhoehen
    void Update()
    {
        if (diamondAmount > 0)
        {
            text.text = "" + diamondAmount;
        }
        // Wenn der Counter = 0 ist, wird folgender Text angezeigt
        else
        {
            text.text = "0";
        }

    }
}