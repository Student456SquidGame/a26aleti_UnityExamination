using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{
    [SerializeField] private int finalSceneIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void LoadPreviousScene()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex -1);
    }
    
    public void LoadEndScene()
    {
        SceneManager.LoadScene (finalSceneIndex);
    }
}
