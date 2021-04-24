using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewControl : MonoBehaviour
{
    public float RotateSpeed;

    private void Start()
    {
        GameManager.Instance.Scope.AddListener(SensetivityReduser);
    }

    void SensetivityReduser(int unused)
    {
        if (unused > 0)
            RotateSpeed /= 2;
        else
            RotateSpeed *= 2;
    }

    private void Update()
    {
        if (GameManager.Instance.takeControllViewState)
        {

            float h = RotateSpeed * -Input.GetAxis("Mouse X") * Time.deltaTime;
            float v = RotateSpeed * -Input.GetAxis("Mouse Y") * Time.deltaTime;
            float z = RotateSpeed * -Input.GetAxis("QandE") * 90 * Time.deltaTime;
            transform.Rotate(v, z, h);
        }
    }
}
