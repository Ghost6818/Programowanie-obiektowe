using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class PlayerAi : MonoBehaviour

{
    public Transform targetObj;
    void Start()
    {
        moveAi();
    }

    [SerializeField] float stopDistance = 8.0f;
 
    public void moveAi()
    {

         transform.DOMove(targetObj.position, 3).onComplete+=checkDistance;
    }

    private void checkDistance()
    {
        float distance = Vector3.Distance(transform.position, targetObj.position);
        
        if (distance > stopDistance)
        {
            moveAi();
        }
        else
        {
            StartCoroutine(Example());
        }
    }

    bool distanceAI = false;

    IEnumerator Example()
    {
        yield return new WaitUntil(() => distanceAI);
        moveAi();
    }
    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetObj.position);
            distanceAI = distance > stopDistance;
    }
}
