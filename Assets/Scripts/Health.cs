using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    public GameObject gameOverScreen;
    [Header ("iFrames")]
    [SerializeField] private float iFramesDuration;
    [SerializeField] private int numberOfFlashes;
    private SpriteRenderer spriteRend;

    private shake shake;
    void Start()
    {
        shake=GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<shake>();

    }

    private void Awake()
    {
        currentHealth = startingHealth;
        spriteRend=GetComponent<SpriteRenderer>();

    }

    public void TakeDamage(float _damage)
    {   soundmanager.PlaySound("enemy");
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            // player hurt
            shake.CamShake();
            StartCoroutine(Invunerability());
        }
        else
        {
            // player dead

            gameOverScreen.SetActive(true);
            AmmoText.ammoAmount = 0;
            DiamondText.diamondAmount = 0;
            // Time.timeScale = 0f;
        }
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
    private IEnumerator Invunerability(){
        Physics2D.IgnoreLayerCollision(8,9,true);
        //wait
        for (int i = 0; i < numberOfFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
        }

        Physics2D.IgnoreLayerCollision(8,9,false);


    }
   
     
}
