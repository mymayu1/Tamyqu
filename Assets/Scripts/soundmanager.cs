using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundmanager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    public static AudioClip AppleSound,DiamondSound,NextLevelSound,KeySound, HeartSound,JumpSound,ShootSound,EnemySound, DeathSound,BackgroundMusic;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        AppleSound= Resources.Load<AudioClip>("AppleSound");
        DiamondSound= Resources.Load<AudioClip>("diamond");
        HeartSound= Resources.Load<AudioClip>("heart");
        JumpSound= Resources.Load<AudioClip>("jump");
        ShootSound= Resources.Load<AudioClip>("shoot");
        EnemySound= Resources.Load<AudioClip>("Enemy");
        DeathSound= Resources.Load<AudioClip>("death");
        BackgroundMusic= Resources.Load<AudioClip>("background");
        KeySound= Resources.Load<AudioClip>("key");
        NextLevelSound= Resources.Load<AudioClip>("winLevel");




        audioSource= GetComponent<AudioSource>();

        if (!PlayerPrefs.HasKey("background"))
        {
            PlayerPrefs.SetFloat("background", 1);
            Load();
        }

        else
        {
            Load();
        }

    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();

    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("background");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("background", volumeSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch(clip){
            case "AppleSound":
            audioSource.PlayOneShot(AppleSound);
            break;
            case "diamond":
            audioSource.PlayOneShot(DiamondSound);
            break;
            case "heart":
            audioSource.PlayOneShot(HeartSound);
            break;
            case "jump":
            audioSource.PlayOneShot(JumpSound);
            break;
            case "shoot":
            audioSource.PlayOneShot(ShootSound);
            break;
            case "enemy":
            audioSource.PlayOneShot(EnemySound);
            break;
            case "death":
            audioSource.PlayOneShot(DeathSound);
            break;
            case "background":
            audioSource.PlayOneShot(BackgroundMusic);
            break;
            case "key":
            audioSource.PlayOneShot(KeySound);
            break;
            case "winLevel":
            audioSource.PlayOneShot(NextLevelSound);
            break;

            

        }
    }
}
