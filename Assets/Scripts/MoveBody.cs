using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBody
    : MonoBehaviour
{
    Rigidbody2D myBody;
    float bodyPower = 2f;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.D))))
        {
            myBody.AddForce(transform.up * bodyPower, ForceMode2D.Impulse);
        }
    }
}
