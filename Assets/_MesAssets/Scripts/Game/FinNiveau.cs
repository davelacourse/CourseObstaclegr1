using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            int noScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(noScene + 1);
        }
    }
}
