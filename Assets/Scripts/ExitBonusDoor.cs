using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitBonusDoor : MonoBehaviour
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
            //SceneManager.LoadScene("Level2");

            // soundmanager.PlaySound("nextlevel");

            Debug.Log("exit");
            loadNextLevel();
            //Debug.Log("exit");
         
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            doorOpen = true;

            // Update();
            // Debug.Log("exit2");
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
        // Debug.Log(SceneManager.GetActiveScene().buildIndex - 1);
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        

    }

}