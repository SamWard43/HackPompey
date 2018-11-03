using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
  public static int score; // this establishes the score variable
  Text text; // Calls the text component

  void Awake()
  {
    // Now the refference needs to be set up
    text = GetComponent <Text> ();

    // Reset the score
    score = 0;
  }

  void Update()
  {
    //Sets the score display
    text.text = "Score" + score;
  }
}
