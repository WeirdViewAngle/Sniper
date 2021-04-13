using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewControl : MonoBehaviour
{
    public float RotateSpeed;
    private void Update()
    {
        if (GameManager.Instance.takeControllViewState)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            if (verticalInput != 0)
            {
                gameObject.transform.Rotate(Vector3.left * verticalInput* RotateSpeed * Time.deltaTime);
            }
            if(horizontalInput != 0)
            {
                gameObject.transform.Rotate(Vector3.back * horizontalInput * RotateSpeed * Time.deltaTime);
            }
        }
    }
}
