using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBubble : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private Transform endTarget;
    [SerializeField] private Sprite spriteTwo;
    [SerializeField] private Sprite spriteThree;
    [SerializeField] private Transform timer;
    public GameObject textObject;
    public GameObject body;
    private SpriteRenderer spriteR;

    // Start is called before the first frame update
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        MoveBody playerScript = body.GetComponent<MoveBody>();
    }


    // Update is called once per frame
    void Update()
    {
        MoveBody playerScript = body.GetComponent<MoveBody>();
        transform.position = new Vector3(target.position.x + 2, target.position.y + 2, target.position.z);
        timer.transform.position = new Vector3(target.position.x - 1.5f, target.position.y + 1, target.position.z);

        if ((spriteR.sprite != spriteTwo) && (Input.GetKeyUp(KeyCode.Space)))
        {
            spriteR.sprite = spriteTwo;
        }

        if ((spriteR.sprite == spriteTwo) && (Input.GetKeyDown(KeyCode.Space)))
        {
            spriteR.color = new Color(1f, 1f, 1f, 0f);
        }

        if ((playerScript.caster == true))
        {
            spriteR.color = new Color(1f, 1f, 1f, 1f);
            spriteR.sprite = spriteThree;
        }

        if ((spriteR.sprite == spriteThree) && (Input.GetKeyUp(KeyCode.Space)))
        {
            spriteR.color = new Color(1f, 1f, 1f, 0f);
        }
    }
}
