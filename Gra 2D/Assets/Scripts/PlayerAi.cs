using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAi : MonoBehaviour

{
    public Transform targetObj;
    void Start()
    {
        transform.DOMove(targetObj.position, 10);
    }

    float stopDistance = 2.0f;
 
    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetObj.position);
        if (distance > stopDistance)
        {
            transform.DOMove(targetObj.position, 5);
        }
        
    }
}
