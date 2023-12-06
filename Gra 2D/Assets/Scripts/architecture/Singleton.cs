using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Singleton : MonoBehaviour


{

    public static Singleton Instance { get; private set; }

    [SerializeField] private bool dontDestroyOnLOad = false;
    protected virtual void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        Instance = this;
        if (dontDestroyOnLOad) DontDestroyOnLoad(gameObject);
    }

}
