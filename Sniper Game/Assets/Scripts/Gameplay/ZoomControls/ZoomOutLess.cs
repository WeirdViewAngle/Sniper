using UnityEngine;

class ZoomOutLess : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.zoomX1.AddListener(ZoomScopePosition);
    }

    void ZoomScopePosition()
    {
        gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x,
                                                    gameObject.transform.localPosition.y - 15,
                                                    gameObject.transform.localPosition.z);
    }
}
