using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string nextSceneName; // Set this in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        // Ensure only the parent Player object triggers the transition
        if (other.gameObject.CompareTag("Player"))
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
