using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingObsticle : Obsticle
{
   protected private override void PlayerCollision()
   {
      base.PlayerCollision();
      Destroy(gameObject);
   }
}
