using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.Instance.takeControllViewState)
        {
            GameObject newBullet = Instantiate(bullet, gameObject.transform.position, Quaternion.identity);

            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) 
            {
                GameManager.Instance.rayInfo.Invoke(hit);
            }
        }
    }
}
