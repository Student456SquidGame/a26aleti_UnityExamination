using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        }
    }
}
