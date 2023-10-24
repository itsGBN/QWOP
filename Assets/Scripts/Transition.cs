using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public GameObject bodyCollider;
    public GameObject BubbleExit;


    private void Update()
    {
        if (SceneManager.GetSceneByName("Level").isLoaded)
        {
            MoveBody bodyScript = bodyCollider.GetComponent<MoveBody>();

            if (bodyScript.caster)
            {
                BubbleExit.SetActive(true);
            }
        }
    }



    public void OnParticleCollision(GameObject other)
    {

        if (SceneManager.GetSceneByName("Main").isLoaded)
        {
            SceneManager.LoadScene("Level");
        }

        if (SceneManager.GetSceneByName("Complete").isLoaded)
        {
            other.GetComponent<ParticleSystem>().Stop(true, ParticleSystemStopBehavior.StopEmitting);
        }

        if (SceneManager.GetSceneByName("Level").isLoaded)
        {
            other.GetComponent<ParticleSystem>().Stop(true, ParticleSystemStopBehavior.StopEmitting);
        }

        MoveBody bodyScript = bodyCollider.GetComponent<MoveBody>();

        if (SceneManager.GetSceneByName("Level").isLoaded && bodyScript.caster == true)
        {
            SceneManager.LoadScene("Complete");
        }
    }


}
