using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    public string[] names = new string[10];
    public float number = 0f;

    public void Start()
    {
         while(number < 1);
         string randomArrayString = names [Random.Range(0, names.Length)];
         number = number + .1f;
         Debug.Log(randomArrayString);

    }






}
