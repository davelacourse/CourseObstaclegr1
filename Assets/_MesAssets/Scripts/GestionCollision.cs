using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    [SerializeField] private Material _materielTouche = default;
    private bool _touche;

    private void Start()
    {
        _touche = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Acc�der au component et changer la couleur du mat�riel.
        //GetComponent<MeshRenderer>().material.color = Color.red;

        // Acc�der au component et changer le mat�riel.
        if (!_touche)
        {
            GetComponent<MeshRenderer>().material = _materielTouche;
            GameManager.Instance.AugmenterCollision();
            _touche = true;
        }
        
    }
}
