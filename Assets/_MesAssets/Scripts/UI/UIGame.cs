using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UIGame : MonoBehaviour
{
    //Singleton
    public static UIGame Instance;

    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private TMP_Text _txtCollisions = default;
    [SerializeField] private GameObject _panneauPause = default;

    private bool _enPause = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        ChangerCollisions();
        Time.timeScale = 1;
    }

    private void Update()
    {
        float temps = Time.time - GameManager.Instance.TempsDepart;
        _txtTemps.text = "Temps : " + temps.ToString("f2");
        GestionPause();
    }

    private void GestionPause()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !_enPause)
        {
            _panneauPause.SetActive(true);
            Time.timeScale = 0;
            _enPause = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && _enPause)
        {
            EnleverPause();
            
        }
    }

    public void EnleverPause()
    {
        _panneauPause.SetActive(false);
        Time.timeScale = 1;
        _enPause = false; 
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void ChangerCollisions()
    {
        _txtCollisions.text = "Collisions : " + GameManager.Instance.Collision.ToString();
    }

    public void Quitter()
    {
            
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
        
    }

    public void Recommencer()
    {
        SceneManager.LoadScene(0);
    }
}
