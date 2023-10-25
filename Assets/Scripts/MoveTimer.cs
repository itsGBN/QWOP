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
    
    public GameObject suffocate;
    SpriteRenderer suffocateSprite;
    float opacity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        timerStarted = true;
        MoveBody playerScript = body.GetComponent<MoveBody>();
        suffocateSprite = suffocate.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBody playerScript = body.GetComponent<MoveBody>();
        opacity += 0.0001f;
        
           

        if ((timerStarted) && (playerScript.caster == false))
        {
            suffocateSprite.color = new Color(0.84f, 0.05f, 0.05f, opacity);
            currentTime -= Time.deltaTime;

            if (currentTime <= 0) 
            { 
                timerStarted=false;
                currentTime = 0;
                SceneManager.LoadScene("Level");
            }

            timerText.text = currentTime.ToString("f0");
        }

    }
}
