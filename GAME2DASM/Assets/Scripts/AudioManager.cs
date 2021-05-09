using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public GameObject prefab;

    public AudioClip coin;
    private AudioSource coinsource;

    public AudioClip dead;
    private AudioSource deadsource;

    public AudioClip theme;
    private AudioSource themesource;

    private void Awake(){
        instance = this;
    }

    public void PlaySound(AudioClip clip, float volume, bool isLoopback){
        if(clip == this.theme)
        {
            Play(clip, ref themesource, volume, isLoopback);
        }
    }

    public void PlaySound(AudioClip clip, float volume)
    {
        if(clip == this.coin)
        {
            Play(clip, ref coinsource, volume);
            return;
        }

        if(clip == this.dead)
        {
            Play(clip, ref deadsource, volume);
            return;
        }


    }

    private void Play(AudioClip clip, ref AudioSource audiosource, float volume, bool isLoopback = false)
    {
        if(audiosource != null && audiosource.isPlaying)
        {
            return;
        }
        audiosource = Instantiate(instance.prefab).GetComponent<AudioSource>();

        audiosource.volume = volume;
        audiosource.loop = isLoopback;
        audiosource.clip = clip;
        audiosource.Play();
        Destroy(audiosource.gameObject, audiosource.clip.length);
    }

    public void StopSound(AudioClip clip)
    {
        if(clip == this.coin)
        {
            coinsource?.Stop();
            return;
        }

        if(clip == this.dead)
        {
            deadsource?.Stop();
            return;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
