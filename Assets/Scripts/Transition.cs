using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{

    public void OnParticleCollision(GameObject other)
    {
        if(SceneManager.GetSceneByName("Main").isLoaded)
        {
            SceneManager.LoadScene("Level");
        }

        if (SceneManager.GetSceneByName("Level").isLoaded)
        {
            other.GetComponent<ParticleSystem>().Stop(true, ParticleSystemStopBehavior.StopEmitting);
        }
    }
}
