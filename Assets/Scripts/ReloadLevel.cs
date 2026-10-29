using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Unexpected Error!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}