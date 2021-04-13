using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    #region Init
    static HUD _hud;

    public static HUD _HUD
    {
        get
        {
            if(_hud == null)
            {
                Debug.LogError("Hud is NULL");
            }

            return _hud;
        }
    }
    private void Awake()
    {
        _hud = this;
    }
    #endregion

    [SerializeField] Text ScoreGO;
    [SerializeField] GameObject ScopeLinesGO;

    private void Start()
    {
        GameManager.Instance.zoomedInState.AddListener(ScopeLayoutActivator);
        GameManager.Instance.zoomedOutState.AddListener(ScopeLayoutDeactivator);
    }

    void ScopeLayoutActivator()
    {
        ScopeLinesGO.SetActive(true);
    }
    void ScopeLayoutDeactivator()
    {
        ScopeLinesGO.SetActive(true);
    }
}
