using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName = "Level1";

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
