using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {

    // BGMを流すための変数
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    private AudioSource audioSource;
    string prevescenename;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {

        
        //現在のシーンを調べてBGMを再生する
        if ((UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Title")&&(prevescenename != "Title"))
        {
            prevescenename = "Title";
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = audioClip1;
            audioSource.Play();
        }

        //現在のシーンを調べてBGMを再生する
        if ((UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Game")&&(prevescenename != "Game"))
        {
            prevescenename = "Game";
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = audioClip2;
            audioSource.Play();
        }


        //現在のシーンを調べてBGMを再生する
        if ((UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Result")&&(prevescenename != "Result"))
        {
            prevescenename = "Result";
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = audioClip3;
            audioSource.Play();
        }

    }
}
