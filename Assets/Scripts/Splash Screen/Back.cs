using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Background : MonoBehaviour
{

    //using UnityEngine.SceneManagement;

    public void BackSceneChanger()
    {
        SceneManager.LoadScene("SplashScreenStart");
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