using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject gameOverScreen;
    //TrigegrZone resetet die Szene wenn PlayerTag kollidiert
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.tag == "Player")
        {
            gameOverScreen.SetActive(true);
            AmmoText.ammoAmount = 0;
            DiamondText.diamondAmount = 0;
            //Time.timeScale = 0f;

        }
    }
}
