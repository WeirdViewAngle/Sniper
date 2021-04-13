using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet =  Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
        }
    }
}
