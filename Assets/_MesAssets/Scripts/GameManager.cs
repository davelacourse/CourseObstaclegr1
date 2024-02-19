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
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //Attributs
    [SerializeField] private int _collision;
    public int Collision => _collision;  // Accesseur

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
}
