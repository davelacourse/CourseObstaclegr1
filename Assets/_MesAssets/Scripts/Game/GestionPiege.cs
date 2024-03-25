using System.Collections.Generic;
using UnityEngine;

public class GestionPiege : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listePieges = new List<GameObject>();
    [SerializeField] private float _intensiteForce = 500;
    private List<Rigidbody> _listeRb = new List<Rigidbody>();
    private bool _estActive;

    private void Awake()
    {
        foreach(var piege in _listePieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
            piege.GetComponent<Rigidbody>().useGravity = false;
        }
        _estActive = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && !_estActive)
        {
            foreach(var rb in _listeRb)
            {
                rb.useGravity = true;
                rb.AddForce(Vector3.down * _intensiteForce);
            }
        }
    }
}
