using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public delegate void raceEvent();

    public static event raceEvent raceStart;
    public static event raceEvent raceEnd;
    public static event raceEvent racePenalty;

    public static void CallRaceStart()
    {
        if (raceStart != null)
            raceStart();
    }

}
