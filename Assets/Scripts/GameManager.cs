using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject BubbleTransition;

    public void Start()
    {
        BubbleTransition.SetActive(false);
    }

    public void LoadGame()
    {
        BubbleTransition.SetActive(true);
    }
}
