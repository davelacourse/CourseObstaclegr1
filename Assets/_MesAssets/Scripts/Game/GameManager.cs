using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton
    public static GameManager Instance;

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
        Instructions();
        _collision = 0;
    }

    private void Instructions()
    {
        Debug.Log("*** Cours à obstacles");
        Debug.Log("Le but est d'atteindre la zone finale le plus rapidement possible.");
    }

    // Méthodes publiques

    public void AugmenterCollision()
    {
        _collision++;
        Debug.Log("Nombre de collisions : " + _collision.ToString());
    }

    public void SetNiveau1(int collisionNiveau1, float tempsNiveau1)
    {
        _collisionNiveau1 = collisionNiveau1;
        _tempsNiveau1 = tempsNiveau1;
    }
}
