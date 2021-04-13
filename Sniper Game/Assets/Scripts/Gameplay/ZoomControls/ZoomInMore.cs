using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInMore : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.zoomX2.AddListener(ZoomScopePosition);
    }

    void ZoomScopePosition()
    {
        gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x,
                                                        gameObject.transform.localPosition.y + 15,
                                                        gameObject.transform.localPosition.z);
    }
}
