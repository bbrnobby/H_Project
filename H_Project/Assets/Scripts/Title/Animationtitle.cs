using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationtitle : MonoBehaviour {
    bool reduction;

    // Use this for initialization
    void Start () {
        reduction = false;
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 scale = transform.localScale;
        scale.z = 1;
        if (reduction==false)
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.0f);
            if(scale.x>=1.5f)
            {
                reduction = true;
            }
        }
        if(reduction==true)
        {
            transform.localScale -= new Vector3(0.01f, 0.01f, 0.0f);
            if (scale.x <= 1.0f)
            {
                reduction = false;
            }
        }
    }
}
