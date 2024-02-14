using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _vitesse = 15.0f;

    private void Start()
    {
        
    }

    
    private void Update()
    {

        float positionX = Input.GetAxisRaw("Horizontal");
        float positionZ = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        
        transform.Translate(direction * _vitesse * Time.deltaTime);


    }
}
