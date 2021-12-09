using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BonusDoor : MonoBehaviour
{

    private PlayerMovement Player;
    public bool doorOpen;
    public Animator transition;
    void Start()
    {
        Player = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        if (doorOpen && Vector3.Distance(Player.transform.position, transform.position) < 1f && Input.GetAxis("Vertical") > 0.1f)
        {
            // SceneManager.LoadScene("Level2");

            // soundmanager.PlaySound("nextlevel");
            loadNextLevel();
            Debug.Log("Door is Open");

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           if(DiamondText.diamondAmount >= 10)
           {
                doorOpen = true;
                DiamondText.diamondAmount -= 10;
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
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

}
