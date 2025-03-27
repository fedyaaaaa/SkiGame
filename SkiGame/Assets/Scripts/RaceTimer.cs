using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTimer : MonoBehaviour
{
   private bool timerRunning = false;
   private float raceTime = 0;

   private void Penalty()
   {
      
   }

   private void Update()
   {
      if (timerRunning)
         raceTime += Time.deltaTime;
   }

   private void OnEnable()
   {
      GameEvents.raceStart += StartRace;
      GameEvents.raceEnd += FinishRace;
   }
   private void OnDisable()
   {
      GameEvents.raceStart -= StartRace;
      GameEvents.raceEnd -= FinishRace;
   }

   private void StartRace()
   {
      timerRunning = true;
      Debug.Log("Race Timer Started");
   }

   private void FinishRace()
   {
      timerRunning = false;
      Debug.Log("Race Timer Finished");
      Debug.Log("Race Timer Finished");
   }
   
}
