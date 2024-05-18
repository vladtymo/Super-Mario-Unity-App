using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroDeath : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Hero")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
