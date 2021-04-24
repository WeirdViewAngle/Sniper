using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] Transform DefaultPosition, ScopePosition;
    bool zoomX2;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!GameManager.Instance.takeControllViewState)
            {
                gameObject.transform.position = ScopePosition.position;
                gameObject.transform.rotation = ScopePosition.rotation;
                GameManager.Instance.zoomedInState.Invoke();
                zoomX2 = false;
            }
            else
            {
                gameObject.transform.position = DefaultPosition.position;
                gameObject.transform.rotation = DefaultPosition.rotation;
                GameManager.Instance.zoomedOutState.Invoke();               
            }
        }

        if (GameManager.Instance.takeControllViewState)
        {
            float mouseWheelInput = Input.GetAxis("Mouse ScrollWheel");
            if (mouseWheelInput > 0 && !zoomX2)
            {
                zoomX2 = true;
                GameManager.Instance.Scope.Invoke(GameManager.Instance.zoomAmmount);
            }
            else if(mouseWheelInput < 0 && zoomX2)
            {
                zoomX2 = false;
                GameManager.Instance.Scope.Invoke(-GameManager.Instance.zoomAmmount);
            }
        }
    }

    private void FixedUpdate()
    {
        if (GameManager.Instance.takeControllViewState)
        {
            gameObject.transform.position = ScopePosition.position;
            gameObject.transform.rotation = ScopePosition.rotation;
        }
    }
}
