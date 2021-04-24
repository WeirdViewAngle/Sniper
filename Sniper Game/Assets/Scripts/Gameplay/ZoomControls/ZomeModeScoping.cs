using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomeModeScoping : MonoBehaviour
{
    public GameObject defaultPosition;
    void Start()
    {
        GameManager.Instance.Scope.AddListener(ZoomScopePosition);
        GameManager.Instance.zoomedOutState.AddListener(MoveBack);
    }

    void ZoomScopePosition(int posToAdd)
    {
        gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x,
                                                        gameObject.transform.localPosition.y + posToAdd,
                                                        gameObject.transform.localPosition.z);
    }

    void MoveBack()
    {
        gameObject.transform.localPosition = defaultPosition.transform.localPosition;
    }
}
