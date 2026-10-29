using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liczby : MonoBehaviour
{
    List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
    List<int> jedynki = new List<int>();
    List<int> dwojki = new List<int>();
    List<int> trojki = new List<int>();

    void Start()
    {
        foreach (int i in dane)
        {
            if (i == 1)
                jedynki.Add(i);
            else if (i == 2)
                dwojki.Add(i);
            else if (i == 3)
                trojki.Add(i);
        }

        Debug.Log("Jedynki: " + jedynki.Count);
        Debug.Log("Dwojki: " + dwojki.Count);
        Debug.Log("Trojki: " + trojki.Count);
        Debug.Log("Dane: " + dane.Count);

        dane.Clear();
    }
}

