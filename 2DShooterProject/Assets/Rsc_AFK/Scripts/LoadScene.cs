using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("BaseScene");
    }

    public void LoadPlayScene()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

}
