using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] Rigidbody bulletRB;
    public float bulletForce;

    private void OnEnable()
    {
        bulletRB.AddForce(Vector3.forward * Time.deltaTime * bulletForce, ForceMode.Impulse);
    }
}
