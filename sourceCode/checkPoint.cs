using UnityEngine;
using System.Collections;

public class CheckpointSystem : MonoBehaviour{
  bool triggered; //has it been triggered?
  void Awake(){
    triggered = false;
  }
  void OnEnterTrigger2D(Collider2D Collider){ //called whenever  a collider en
  void Main(score){
    score= new newScore();
  }                                          //ters our zone
    if (! triggered){
      // check we actually collided with
              // a character. It would be best to
              // setup your layers so this check is
              // not required, by creating a layer
              // "Checkpoint" that will only collide
              // with characters.
        if (collider.gameObject.layer
            == LayerMask.NameToLayer ("Character"))
        {
          newScore+1;
          Trigger();
        }
    }
  }
  void Trigger(){
    // now we'll tell the animator about the recent triggering
    GetComponent<Animator>().SetTrigger("Triggered");
    triggered=true;
  }
  }
}
