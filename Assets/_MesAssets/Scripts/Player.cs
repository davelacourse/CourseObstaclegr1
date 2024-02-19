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

        //D�placement par position (t�l�portation)
        //transform.Translate(direction * _vitesse * Time.deltaTime);

        // Utiliser une force pour pousser l'objet
        //_rb.AddForce(direction * Time.fixedDeltaTime * _vitesse);

        //Appliquer une v�locit� dans la direction d�finie
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
    }

    // M�thodes publiques

    public void DetruireJoueur()
    {
        Destroy(gameObject);
    }
}
