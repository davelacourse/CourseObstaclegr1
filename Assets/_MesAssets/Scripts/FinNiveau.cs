using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinNiveau : MonoBehaviour
{
    [SerializeField] private Player _player = default;
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("* Fin de la partie *");
        Debug.Log("Temps Total : " + Time.time + " secondes.");
        Debug.Log("Nombre de collisions : " + GameManager.Instance.Collision);
        Debug.Log("Temps final : " + (Time.time + GameManager.Instance.Collision) + "secondes.");
        _player.DetruireJoueur();
      
    }
}
