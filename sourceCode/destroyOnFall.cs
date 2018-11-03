using UnityEngine;
using System.Collections;

public class FallOffTheEdge : MonoBehaviour
{
  public GameObject Fall;
  public GameObject playerDeath;
  public int scoreValue;
  private GameController gameController;

  void Start()
  {
    GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
    if gameControllerObject != null)
    {
      gameController = gameControllerObject.GetComponent <GameController>();
    }
    if (gameController == null)
    {
      Debug.Log ("Cannot find 'GameController' script");
    }
  }

  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Boundary")
    {
      return;
    }
    Instantiate(Fall, transform.position, transform.rotation);
    if (other.tag == "Player")
    {
      Instantiate(playerDeath, other.transform.position, other.transform.rotation);
    }
    gameController.AddScore (scoreValue);
    Destroy(other.gameObject);
    Destroy(gameObject);
  }
}
