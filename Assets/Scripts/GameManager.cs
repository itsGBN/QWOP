using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject BubbleTransition;

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
    }


    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }
}
