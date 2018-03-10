using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerLife : MonoBehaviour {
    // Use this for initialization
    int PlayerHP;
    GameObject PlayerLife1;
    GameObject PlayerLife2;
    GameObject PlayerLife3;

    GameObject PlayerCube;

    Renderer rend1;
    Renderer rend2;
    Renderer rend3;

    Vector3 scale;

    void Start() {
        PlayerHP = 3;   //HP初期値

        PlayerLife1 = GameObject.Find("PlayerLife1");
        PlayerLife2 = GameObject.Find("PlayerLife2");
        PlayerLife3 = GameObject.Find("PlayerLife3");

        rend1 = PlayerLife1.GetComponent<Renderer>();
        rend2 = PlayerLife2.GetComponent<Renderer>();
        rend3 = PlayerLife3.GetComponent<Renderer>();

        PlayerCube = GameObject.Find("Player");

        scale = PlayerLife1.transform.localScale;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {//hp減らす
            PlayerHP -= 1;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {//hp全快
            PlayerHP = 3;
        }

        if (PlayerHP == 2)
        {//hp２になったらハートを外側から消す
            rend3.material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

            //GameObject.Find("PlayerLife3").SetActive(false);
        }
        if (PlayerHP == 1)
        {//ハートを外側から消す
            rend2.material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
            //GameObject.Find("PlayerLife2").SetActive(false);
        }
        if (PlayerHP == 0)
        {//ハートを外側から消す
            rend1.material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
            //GameObject.Find("PlayerLife1").SetActive(false);
        }

        if (PlayerHP == 3)
        {//ハート再表示
            rend1.material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            rend2.material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            rend3.material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }

        //ハート鼓動
        scale.x -= 0.0002f;
        scale.z -= 0.0002f;
        if (scale.x<0.05f)
        {
            scale.x = 0.06f;
            scale.z = 0.06f;
        }
        PlayerLife1.transform.localScale = scale;

        //追従処理
        Vector3 pPos = PlayerCube.transform.position;
        pPos.z = -1;

        PlayerLife1.transform.position = pPos;




    }


}