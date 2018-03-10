using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionSE : MonoBehaviour {

    // SEを流すための変数
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    private AudioSource audioSource;

    // フラグ
    public enum PLAYER_TYPE
    {
        type_none=0,
        type_walk,
        type_jump,
    }

    public PLAYER_TYPE m_type;

	// Use this for initialization
	void Start () {
        // 初期化
        m_type = PLAYER_TYPE.type_none;
    }
	
	// Update is called once per frame
	void Update () {

        // アクションに合わせて分岐
        switch (m_type)
        {
            case PLAYER_TYPE.type_walk:
                audioSource = GetComponent<AudioSource>();
                audioSource.clip = audioClip1;
                audioSource.Play();
                m_type = PLAYER_TYPE.type_none;
                break;

            case PLAYER_TYPE.type_jump:
                audioSource = GetComponent<AudioSource>();
                audioSource.clip = audioClip2;
                audioSource.Play();
                m_type = PLAYER_TYPE.type_none;
                break;
        }
	}
}
