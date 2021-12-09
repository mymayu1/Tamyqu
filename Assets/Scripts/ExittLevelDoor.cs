using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ExittLevelDoor : MonoBehaviour
{
    private PlayerMovement thePlayer;
    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;

    public bool doorOpen, waitingToOpen;
    public Animator transition;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToOpen)
        {
            if (Vector3.Distance(thePlayer.followingKey.transform.position, transform.position) < 0.1f)
            {
                waitingToOpen = false;
                doorOpen = true;
                theSR.sprite = doorOpenSprite;

                thePlayer.followingKey.gameObject.SetActive(false);
                thePlayer.followingKey = null;
            }
        }
        if (doorOpen && Vector3.Distance(thePlayer.transform.position, transform.position) < 1f && Input.GetAxis("Vertical") > 0.1f)
        {
            //SceneManager.LoadScene("Level2");

            soundmanager.PlaySound("winLevel");
            loadNextLevel();
            AmmoText.ammoAmount = 0;
            DiamondText.diamondAmount = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followTarget = transform;
                waitingToOpen = true;
            }
        }
    }
    IEnumerator loadLevel(int levelIndex)
    {

        yield return new WaitForSeconds(1);
        //transition
        transition.SetTrigger("start");
        //wait
        yield return new WaitForSeconds(1);
        //load scene
        SceneManager.LoadScene(levelIndex);

    }
    void loadNextLevel()
    {
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex - 4));
    }
}

