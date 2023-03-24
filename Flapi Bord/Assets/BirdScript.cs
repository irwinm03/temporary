using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;

    public float flapstrength;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Birb";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.velocity = Vector2.up * flapstrength;

        }
    }
}
