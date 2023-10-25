using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject BubbleTransition;

    public AudioSource audioSource;
    public AudioClip audioclip;

    public void Start()
    {
        if (SceneManager.GetSceneByName("Main").isLoaded)
        {
            BubbleTransition.SetActive(false);
        }
        //BubbleTransition.SetActive(false);
    }

    public void LoadGame()
    {
        BubbleTransition.SetActive(true);
        audioSource.PlayOneShot(audioclip);
    }


    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
        audioSource.PlayOneShot(audioclip);
    }
}
