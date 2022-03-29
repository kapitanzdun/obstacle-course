
using UnityEngine;

public class игрокCollision : MonoBehaviour

 {
   public move_player movement ; 

   void OnCollisionEnter (Collision collisionInfo )
   {
       if (collisionInfo.collider.tag == "ф")
       {
           movement.enabled = false;
       }
       
   }
}
