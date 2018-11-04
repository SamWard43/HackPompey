 //example movement vector
 var movement = Vector3.one;
 //move whatever object this script is attached to
 transform.position += movement;
 //apply equal and opposite movement to each child
 for (var child : Transform in transform) {
     child.position -= movement;
 }
