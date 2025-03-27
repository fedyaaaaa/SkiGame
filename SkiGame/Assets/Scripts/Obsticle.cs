using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject.CompareTag("Player"))
      {
         PlayerCollision();
      }
   }

   protected private virtual void PlayerCollision() //protected - redz tas kas manto 
   {
      Debug.Log("Player hit " + name);
   }
}
