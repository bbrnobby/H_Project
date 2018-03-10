using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour {
    //宣言
    GameObject m_gameObject;

    // Use this for initialization
    void Start () {
        //検索
        m_gameObject = GameObject.Find("Player");

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 Position = m_gameObject.transform.position;
        Position.z -= 10.0f;
        this.transform.position = Position;
	}
}
