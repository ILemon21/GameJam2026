using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string SceneName;
    void Update()
    {
        
    }
    public void LoadSpecificScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadPreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int previousSceneIndex = currentSceneIndex - 1;
        if (previousSceneIndex >= 0) {
            SceneManager.LoadScene(previousSceneIndex);
        } else {
            Debug.LogWarning("You are at the first scene! Nowhere to go back.");
        }
    }
}
