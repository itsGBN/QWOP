using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightArm
    : MonoBehaviour
{
    Rigidbody2D myArm;
    float armPower = 1f;
    Vector3 arm = new Vector3(0, -2, 0);
    Vector3 armdown = new Vector3(0, 2, 0);


    // Start is called before the first frame update
    void Start()
    {
        myArm = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            myArm.AddForce(arm * armPower, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myArm.AddForce(armdown * armPower, ForceMode2D.Impulse);
        }
    }
}
