using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _vitesse = 500.0f;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MouvementsJoueur();
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);

        //Déplacement par position (téléportation)
        //transform.Translate(direction * _vitesse * Time.deltaTime);

        // Utiliser une force pour pousser l'objet
        //_rb.AddForce(direction * Time.fixedDeltaTime * _vitesse);

        //Appliquer une vélocité dans la direction définie
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
    }

    // Méthodes publiques

    public void DetruireJoueur()
    {
        Destroy(gameObject);
    }
}
