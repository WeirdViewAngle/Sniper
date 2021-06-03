using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] Rigidbody bulletRB;

    public float bulletForce;

    RaycastHit rayInfo;
    private void Awake()
    {
        GameManager.Instance.rayInfo.AddListener(HandleRayInfo);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    void HandleRayInfo(RaycastHit gotRayInfo)
    {
        rayInfo = gotRayInfo;
        Vector3 direction = (rayInfo.point - gameObject.transform.position).normalized;
        ShotBullet(direction);
    }

    void ShotBullet(Vector3 direction)
    {
        bulletRB.AddForce(direction * bulletForce, ForceMode.Impulse);
        Destroy(gameObject, 2f);
    }
}
