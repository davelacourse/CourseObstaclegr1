using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton
    public static GameManager Instance;

    private float _tempsDepart = 0;
    public float TempsDepart => _tempsDepart;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //Attributs
    [SerializeField] private int _collision;
    public int Collision => _collision;  // Accesseur

    private int _collisionNiveau1;
    public int CollisionNiveau1 => _collisionNiveau1;

    private float _tempsNiveau1;
    public float TempsNiveau1 => _tempsNiveau1;

    private void Start()
    {
        _collision = 0;
        _tempsDepart = Time.time;
    }

    // Méthodes publiques

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1
            || SceneManager.GetActiveScene().buildIndex == 0) ;
        {
            Destroy(gameObject);
        }    
    }

    public void AugmenterCollision()
    {
        _collision++;
        UIGame.Instance.ChangerCollisions();
    }

    public void SetNiveau1(int collisionNiveau1, float tempsNiveau1)
    {
        _collisionNiveau1 = collisionNiveau1;
        _tempsNiveau1 = tempsNiveau1;
    }
}
