using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBody
    : MonoBehaviour
{
    Rigidbody2D myBody;
    float bodyPower = 2f;
    public bool caster = false; 

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.D))))
        {
            myBody.AddForce(transform.up * bodyPower, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ladder")
        {
            caster = true;
        }

    }
}
