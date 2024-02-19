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
        // Accéder au component et changer la couleur du matériel.
        //GetComponent<MeshRenderer>().material.color = Color.red;

        // Accéder au component et changer le matériel.
        if (!_touche)
        {
            GetComponent<MeshRenderer>().material = _materielTouche;
            GameManager.Instance.AugmenterCollision();
            _touche = true;
        }
        
    }
}
