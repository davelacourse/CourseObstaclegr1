using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _panneauInstructions = default;
    [SerializeField] private GameObject _panneauBoutons = default;

    public void Quitter()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void ChangerScene()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(noScene + 1);
    }

    public void AfficherInstructions()
    {
        _panneauInstructions.SetActive(true);
        _panneauBoutons.SetActive(false);
    }

    public void AfficherBoutons()
    {
        _panneauInstructions.SetActive(false);
        _panneauBoutons.SetActive(true);
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }

}
