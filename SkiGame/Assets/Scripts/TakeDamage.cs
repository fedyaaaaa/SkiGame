using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{

 private void OnEnable()
 {
  PlayerEvents.OnHitEvent += TakeDmg;
 }

 private void OnDisable()
 {
  PlayerEvents.OnHitEvent -= TakeDmg;
 }
 
 
 private void TakeDmg()
 {
  Debug.Log("player took damage");
 }
}
