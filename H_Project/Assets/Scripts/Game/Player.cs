using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 秋谷

public class Player : MonoBehaviour
{
    //宣言
    GameObject m_gameObject;

    public float dx;

    /// <summary>
    /// 動いてるか
    /// </summary>
    public bool is_active;
    public Animator anime;

    // Use this for initialization
    void Start()
    {
        //検索
        m_gameObject = GameObject.Find("Player");
        is_active = true;
        
        anime.SetBool("move", true);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(1, 0, 0);

        /*
         Vector3 pos = transform.position;
        pos.x += 1;
        transform.position = pos;
        */

        if (is_active == true)
        {
            // 1秒にdx分だけ動くように
            m_gameObject.transform.position += new Vector3(dx * Time.deltaTime, 0, 0);
        }
        else
        {

        }
    }
    /// <summary>
    /// アニメーション用フラグ T:移動
    /// </summary>
    /// <param name="is_landing"></param>
    public void set_move_flag(bool is_landing)
    {
        is_active = is_landing;
        anime.SetBool("move", is_landing);
    }

    public bool get_move_flag()
    {
        return is_active;
    }

    public void OnValidate()
    {
        anime.SetBool("move", is_active);
    }
}
