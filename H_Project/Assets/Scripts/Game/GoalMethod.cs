using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMethod : MonoBehaviour {
    //宣言
    GameObject PlayerObject;

    // Use this for initialization
    void Start () {
        //検索
        PlayerObject = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
