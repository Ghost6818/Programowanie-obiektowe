
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
