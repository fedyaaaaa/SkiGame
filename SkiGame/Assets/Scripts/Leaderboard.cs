using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    [SerializeField] private List<float> bestTimes = new();

    private void Awake()
    {
    DontDestroyOnLoad(gameObject);    
    }
    
    public void AddTime(float time)
    {
        bestTimes.Add(time);
        bestTimes.Sort();
    }
}
