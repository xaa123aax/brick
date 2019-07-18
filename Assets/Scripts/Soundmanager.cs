
using UnityEngine;
using System.Collections;

public class Soundmanager : MonoBehaviour
{
    //儲存背景音樂的AudioSource Component
    private AudioSource bgMusicAudioSource;
    public float pitch =0.7f;


    void OnEnable()
    {
        //在所有Game Object中找尋Background Music
        bgMusicAudioSource = GameObject.FindGameObjectWithTag("Background Music").GetComponent<AudioSource>();

        //暫停音樂
        bgMusicAudioSource.Pause();
    }

    void OnDisable()
    {
        //繼續音樂
        bgMusicAudioSource.UnPause();
    }
    private void Update()
    {
        //如果不是死亡
        if (GameStatus.Instance.now != GameStatus.Status.Stop)
        {
            
            OnDisable();
        }
        //如果死了
        if (GameStatus.Instance.now == GameStatus.Status.Stop)
        {
            OnEnable();
            bgMusicAudioSource.pitch = pitch;  //改變pitch
            OnDisable();
        }

        if (GameStatus.Instance.now == GameStatus.Status.GameEnd)
        {
            bgMusicAudioSource.pitch = pitch;  //改變pitch
           
        }
        
    }
}