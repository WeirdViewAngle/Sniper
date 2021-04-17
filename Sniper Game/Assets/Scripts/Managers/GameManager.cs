using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    #region init
    static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                    Debug.LogError("GameManager is NULL");
            }
            return _instance;
        }
    }

    private void Awake() 
    {
        _instance = this;
    }
    #endregion

    int score;
    public int Score
    {
        get
        {
            return score;
        }
    }

    int enemiesLeft;
    public int EnemiesLeft
    {
        get
        {
            return enemiesLeft;
        }
    }

    public UnityEvent zoomedInState, zoomedOutState;
    public UnityEvent<int> Scope;
    public bool takeControllViewState;



    private void Start()
    {
        zoomedInState.AddListener(ControllOn);
        zoomedOutState.AddListener(ControllOff);
    }

    void ControllOn()
    {
        takeControllViewState = true;
    }
    void ControllOff()
    {
        takeControllViewState = false;
    }
}