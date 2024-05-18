using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{
    // при зіткненні іншого обʼєкту з даним колайдером
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
