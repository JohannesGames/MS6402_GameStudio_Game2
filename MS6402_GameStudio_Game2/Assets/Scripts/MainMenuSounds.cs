using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSounds : MonoBehaviour
{
    public AudioSource backgroundLoop;
    public AudioSource playButton;
    public float changeSceneOffset = 1.5f;
    public float loadingTime = 4;
    private float timeToSwitch;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);    //plays audio across scenes
    }

    void Start()
    {
        backgroundLoop.Play();
    }

    public void PressPlay()
    {
        playButton.Play();
        Invoke("NextScene", changeSceneOffset); //set to audio effect delay
    }

    void NextScene()
    {
        backgroundLoop.Stop();
        Destroy(gameObject, playButton.clip.length);
        SceneManager.LoadScene(1);
    }
}
