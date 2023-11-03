
using UnityEngine;

public class PlayerContlorer : MonoBehaviour
{

    public bool points { get; private set; } = false;

     public void AddPoint()
     {
       points = true;
       Debug.Log("Dodano punkt. Aktualna liczba punktów: " + points);
     }
}
