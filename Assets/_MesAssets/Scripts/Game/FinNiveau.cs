using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{
    [SerializeField] private Player _player = default;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            int noScene = SceneManager.GetActiveScene().buildIndex;

            if(noScene == SceneManager.sceneCountInBuildSettings - 1)
            {
                int accrochagesTotal = GameManager.Instance.Collision;
                float tempsFinalNiv1 = GameManager.Instance.TempsNiveau1 + GameManager.Instance.CollisionNiveau1;
                int accrochagesNiv2 = accrochagesTotal - GameManager.Instance.CollisionNiveau1;
                float tempsNiv2 = Time.time - GameManager.Instance.TempsNiveau1;
                float tempsFinalNiv2 = tempsNiv2 + accrochagesNiv2;

                Debug.Log("* Fin de la partie *");
                Debug.Log("Temps pour le niveau 1 : " + GameManager.Instance.TempsNiveau1.ToString("f2") + " secondes.");
                Debug.Log("Accrochages niveau 1 : " + GameManager.Instance.CollisionNiveau1);
                Debug.Log("Temps final niveau 1 " + tempsFinalNiv1.ToString("f2"));
                Debug.Log("*******************************************************");
                Debug.Log("Temps pour le niveau 2 : " + tempsNiv2.ToString("f2") + " secondes.");
                Debug.Log("Accrochages niveau 2 : " + accrochagesNiv2);
                Debug.Log("Temps final niveau 2 " + tempsFinalNiv2.ToString("f2"));
                Debug.Log("*******************************************************");
                Debug.Log("Temps Total : " + Time.time.ToString("f2") + " secondes.");
                Debug.Log("Nombre de collisions : " + GameManager.Instance.Collision);
                Debug.Log("Temps final : " + (Time.time + GameManager.Instance.Collision).ToString("f2") + "secondes.");
                _player.DetruireJoueur();
            }
            else
            {
                GameManager.Instance.SetNiveau1(GameManager.Instance.Collision, Time.time);
                SceneManager.LoadScene(noScene + 1);
            }

        }
    }
}
