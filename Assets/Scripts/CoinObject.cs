using System;
using UnityEngine;

public class CoinObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<LimitedPlatformerMovement>().coinsCollected++;
            other.gameObject.GetComponent<LimitedPlatformerMovement>().coinText.text = "Coins:" + other.gameObject.GetComponent<LimitedPlatformerMovement>().coinsCollected;
            Destroy(gameObject);
        }
    }
}
