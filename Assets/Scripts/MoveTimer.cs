using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MoveTimer : MonoBehaviour
{
    [SerializeField] float startTime;
    float currentTime;
    bool timerStarted = false;
    [SerializeField] TMP_Text timerText;
    public GameObject body;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        timerStarted = true;
        MoveBody playerScript = body.GetComponent<MoveBody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBody playerScript = body.GetComponent<MoveBody>();
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    timerStarted = true;
        //}

        if ((timerStarted) && (playerScript.caster == false))
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0) 
            { 
                timerStarted=false;
                currentTime = 0;
                SceneManager.LoadScene("SampleScene");
            }

            timerText.text = currentTime.ToString("f0");
        }

    }
}
