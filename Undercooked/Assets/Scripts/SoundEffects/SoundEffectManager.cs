using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
    private static SoundEffectManager Instance;
    private static AudioSource audioSource;
    private static SoundEffectLibrary soundEffectLibrary;
    
    private void Awake(){
        if(Instance == null){
            Instance = this;
            audioSource = GetComponent<AudioSource>();
            soundEffectLibrary = GetComponent<SoundEffectLibrary>();
            DontDestroyOnLoad(gameObject);
        }
        else    
            Destroy(gameObject);
    }

    public static void Play(string soundName){
        AudioClip audioClip = soundEffectLibrary.GetRandomClip(soundName);
        if(audioClip != null)
            audioSource.PlayOneShot(audioClip);
    }

    public static void SetVolume(){
        audioSource.volume  = 0.75f;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
