using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public TMP_Text my_text;
    private static int coins = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // score ++
        gameObject.SetActive(false);
        my_text.text = $"Score: {++coins}";
    }
}
