using UnityEngine;

public class MouvementRotatif : MonoBehaviour
{

    [SerializeField] private float _vitesseRotationY = 0.5f;
    private void Update()
    {
        transform.Rotate(0f, _vitesseRotationY * Time.deltaTime, 0f);
    }
}
