using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{
  public GameObject particle;
  void Update()
  {
    Vector 3 mousePos = Input.mousePosition;
      Vector3 wantedPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, depth));
      transform.position = wantedPos;
  }
}
