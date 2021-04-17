using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] Rigidbody bulletRB;
    public float bulletForce;

    private void OnEnable()
    {
        Ray ray = Camera.main.ViewportPointToRay(Camera.main.transform.position);

        Debug.DrawRay(ray.origin, ray.direction,Color.blue);

        RaycastHit rayHitInfo;

        if(Physics.Raycast(ray, out rayHitInfo))
        {
            Vector3 direction = (gameObject.transform.position - rayHitInfo.point).normalized;
            bulletRB.AddForce(direction * Time.deltaTime * bulletForce, ForceMode.Impulse);
        } 

        Destroy(gameObject, 2);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}
