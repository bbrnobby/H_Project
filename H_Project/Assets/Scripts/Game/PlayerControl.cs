using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    float y;
    bool NG = false;
    bool OK = true;
    float y_old;

    // Use this for initialization
    void Start()
    {

        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("down"))
        {
            transform.position += new Vector3(1, 0, 0);
        }

        if (Input.GetKey("up"))
        {
            transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(0, 0, 1);
        }

        if (Input.GetKey("left"))
        {
            transform.position += new Vector3(0, 0, -1);
        }

        if (Input.GetKey("space"))
        {
            NG = true;

            if (y + 5 < transform.position.y)
            {
                NG = false;
                OK = false;

            }
        }

        if (NG == true && OK == true)
        {
            transform.position += new Vector3(0, 1, 0);
        }

        y_old = transform.position.y;
    }
}
