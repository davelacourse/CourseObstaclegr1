using TMPro;
using UnityEngine;

public class UIGame : MonoBehaviour
{
    //Singleton
    public static UIGame Instance;

    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private TMP_Text _txtCollisions = default;

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
    }

    private void Update()
    {
        float temps = Time.time - GameManager.Instance.TempsDepart;
        _txtTemps.text = "Temps : " + temps.ToString("f2");
    }

    public void ChangerCollisions()
    {
        _txtCollisions.text = "Collisions : " + GameManager.Instance.Collision.ToString();
    }
}
