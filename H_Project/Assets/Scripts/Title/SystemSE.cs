using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemSE: MonoBehaviour {

    // SEを流すための変数
    public AudioClip audioClip1;    // 決定音
    public AudioClip audioClip2;    // 戻るボタン音 　
    public AudioClip audioClip3;    // カーソル移動音
    public AudioSource audioSource;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {

        /*キーによって流すシステム音です*/

        

        //現在のシーンを調べてSEを再生する
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Title")
        {
            //if (Input.GetMouseButtonDown(0))
            if (Input.GetKeyDown(KeyCode.Return))  　 // 仮でエンターキーを設定しています
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.clip = audioClip1;
                audioSource.Play();
            }
        }

        //現在のシーンを調べてSEを再生する
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Game")
        {
            //if (Input.GetMouseButtonDown(0))
            if (Input.GetKeyDown(KeyCode.Return))　　　// 仮でエンターキーを設定しています
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.clip = audioClip2;
                audioSource.Play();
            }
        }


        //現在のシーンを調べてSEを再生する
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Result")
        {
            //if (Input.GetMouseButtonDown(0))
            if (Input.GetKeyDown(KeyCode.Return))　　　// 仮でエンターキーを設定しています
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.clip = audioClip3;
                audioSource.Play();
            }
        }

        


    }
}
