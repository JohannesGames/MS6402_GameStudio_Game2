using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSounds : MonoBehaviour
{
    public AudioSource deathSound;

    public void PCDeath()
    {
        deathSound.Play();
        Invoke("ToMainMenu", deathSound.clip.length - 2);
    }

    void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
