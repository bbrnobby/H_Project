using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldObjectSE : MonoBehaviour {

    // SEを流すための変数
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    public AudioClip audioClip4;
    private AudioSource audioSource;

    // フラグ
    public enum FIELD_SE
    {
        type_none = 0,
        type_transform,
        type_fall,
        type_door,
        type_etc1,
    }

    // フラグの変数
    public FIELD_SE f_type;

    // Use this for initialization
    void Start () {
        // 初期化
        f_type = FIELD_SE.type_none;
	}
	
	// Update is called once per frame
	void Update () {
        // オブジェクトの状況に合わせて分岐
		switch(f_type)
        {
            case FIELD_SE.type_transform:
                audioSource = GetComponent<AudioSource>();
                audioSource.clip = audioClip1;
                audioSource.Play();
                f_type = FIELD_SE.type_none;   // 再初期化
                break;

            case FIELD_SE.type_fall:
                audioSource = GetComponent<AudioSource>();
                audioSource.clip = audioClip2;
                audioSource.Play();
                f_type = FIELD_SE.type_none;   // 再初期化
                break;

            case FIELD_SE.type_door:
                audioSource = GetComponent<AudioSource>();
                audioSource.clip = audioClip3;
                audioSource.Play();
                f_type = FIELD_SE.type_none;   // 再初期化
                break;

            case FIELD_SE.type_etc1:
                audioSource = GetComponent<AudioSource>();
                audioSource.clip = audioClip4;
                audioSource.Play();
                f_type = FIELD_SE.type_none;   // 再初期化
                break;
        }
	}
}
