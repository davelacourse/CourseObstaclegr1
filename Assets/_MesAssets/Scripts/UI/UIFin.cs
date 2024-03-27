using TMPro;
using UnityEngine;

public class UIFin : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtTempsTotal = default;
    [SerializeField] private TMP_Text _txtCollisionsTotales = default;
    [SerializeField] private TMP_Text _txtTempsFinal = default;

    private void Start()
    {
        _txtTempsTotal.text = "Temps total : " + (Time.time - GameManager.Instance.TempsDepart).ToString("f2") + " sec.";
        _txtCollisionsTotales.text = "Collisions totales : " + GameManager.Instance.Collision.ToString();
        float pointageTotal = (Time.time - GameManager.Instance.TempsDepart) + GameManager.Instance.Collision;
        _txtTempsFinal.text = "Temps final : " + pointageTotal.ToString("f2") + " sec.";
    }
}
