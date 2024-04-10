
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Bullet prefab;
    [SerializeField] private Transform aim;
    [SerializeField] private Move playerMoov;
    private void Update()
    {
        if (Input.GetButtonDown("Bullet"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Debug.Log("Hello Shoot");
        Bullet bullet = Instantiate(prefab, aim.position, Quaternion.identity);
        bullet.initBulletSide(playerMoov.IsFacingRight);
    }
}
