using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //シーン遷移用

public class ChangeToResult : MonoBehaviour
{

	// Use this for initialization
	void Start()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Result");
        }
    }
}
