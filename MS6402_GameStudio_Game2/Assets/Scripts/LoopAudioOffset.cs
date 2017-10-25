using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// plays an ambient looping element beginning another when reaching an ofset time from the end of the loop 
/// (useful for elements without a clear beginning and end to the loop)
/// </summary>

public class LoopAudioOffset : MonoBehaviour
{
    public AudioSource songToPlay;    //the audio attached to this component
    AudioSource songToLoop;
    bool playingFirst = true;

    public float offset = 30;   //the time before the end the next song is to be played;
    private float timeToStart;

    void Start()
    {
        songToPlay.Play();
        timeToStart = Time.time + (songToPlay.clip.length - offset);
        songToLoop = Instantiate(songToPlay, transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToStart)
        {
            PlayNext();
        }
    }

    void PlayNext()
    {
        if (playingFirst)
            songToLoop.Play();
        else
            songToPlay.Play();

        timeToStart = Time.time + (songToPlay.clip.length - offset);
        playingFirst = !playingFirst;
    }
}
