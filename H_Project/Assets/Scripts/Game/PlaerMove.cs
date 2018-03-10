using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.identity;
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
        //右移動
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(0.5f, 0.0f, 0.0f);
        //左移動
        if (Input.GetKey(KeyCode.A))
            transform.position -= new Vector3(0.5f, 0.0f, 0.0f);
        //ジャンプ
        if (Input.GetKey(KeyCode.Space))
            transform.position += new Vector3(0.0f, 0.5f, 0.0f);
    }
}
