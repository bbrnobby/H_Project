using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HauntedGauge : MonoBehaviour {
    public Vector3 scale;
    Renderer rend;
    GameObject PlayerCube;

    // Use this for initialization
    void Start () {
        scale = transform.localScale;
        rend = GetComponent<Renderer>();
        PlayerCube = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.H))
        {//Hキーでxを減らす
            scale.x -= 0.005f;
        }
        else
        {
            scale.x += 0.005f;
        }
        transform.localScale = scale;

        if(scale.x < 0.19)
        {//赤
            rend.material.color = new Color(1.0f, 0.3f, 0.3f);
        }
        else if(scale.x < 0.35)
        {//黃
            rend.material.color = new Color(1.0f, 1.0f, 0.3f);
        }
        else
        {//緑
            rend.material.color = new Color(0.5f, 1.0f, 0.5f);
        }

        if(scale.x<=0.0f)
        {//0以下で止める
            scale.x = 0.0f;
            rend.material.color = new Color(1.0f, 0.3f, 0.3f,0.0f);
        }
        if(scale.x>=0.5f)
        {
            scale.x = 0.5f;
        }

        //追従処理
        Vector3 pPos = PlayerCube.transform.position;

        transform.position = new Vector3(pPos.x, pPos.y+1, pPos.z);
    }

    public float GetGaugeWidhtValue()
    {
        return scale.x;
    }

}
