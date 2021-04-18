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
            RotateSpeed = 2;
        else
            RotateSpeed = 5;
    }

    private void Update()
    {
        if (GameManager.Instance.takeControllViewState)
        {

            float h = RotateSpeed * -Input.GetAxis("Mouse X");
            float v = RotateSpeed * -Input.GetAxis("Mouse Y");
            float z = RotateSpeed * -Input.GetAxis("QandE") * 90;
            transform.Rotate(v, z, h);


            /*float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            if (verticalInput != 0)
            {
                gameObject.transform.Rotate(Vector3.left * verticalInput* RotateSpeed * Time.deltaTime);
            }
            if(horizontalInput != 0)
            {
                gameObject.transform.Rotate(Vector3.back * horizontalInput * RotateSpeed * Time.deltaTime);
            }*/
        }
    }
}
