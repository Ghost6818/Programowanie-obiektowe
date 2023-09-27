using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class playerContlorer : MonoBehaviour
{


    public bool points = false;


     public void AddPoint()
     {
       points = true;
       Debug.Log("Dodano punkt. Aktualna liczba punktów: " + points);
     }
}
