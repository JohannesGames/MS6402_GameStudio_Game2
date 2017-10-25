using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public float loadingTime = 3;

    void Start()
    {
        Invoke("LoadNext", loadingTime);
    }
    
    void LoadNext()
    {
        SceneManager.LoadScene(2);
    }
}
