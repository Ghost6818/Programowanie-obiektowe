using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private List<Transform> aim;
    private WaitForSeconds waitTimeToShoot = new WaitForSeconds(2);
    void SpamBullet(Transform aim)
    {
        Bullet bullet = Instantiate(bulletPrefab, aim.position, aim.rotation);
        bullet.initBulletSide();

    }
    void Shoot()
    {
        foreach (Transform t in aim)
        {
            SpamBullet(t);
        }
        StartCoroutine(WaitToShoot());
    }
    IEnumerator WaitToShoot()
    {
        yield return waitTimeToShoot;
        Shoot();
    }
    private void Awake()
    {
        StartCoroutine(WaitToShoot());
    }

}
