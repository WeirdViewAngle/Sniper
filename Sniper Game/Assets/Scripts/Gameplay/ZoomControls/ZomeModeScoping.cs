using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomeModeScoping : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.Scope.AddListener(ZoomScopePosition);
    }

    void ZoomScopePosition(int posToAdd)
    {
        gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x,
                                                        gameObject.transform.localPosition.y + posToAdd,
                                                        gameObject.transform.localPosition.z);
    }
}
