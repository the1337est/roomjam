using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

    public delegate void StateAction(GameState state);
    public static event StateAction OnGameStateChange;

    [SerializeField]
    private GameState state;
    public GameState State
    {
        get
        {
            return state;
        }
        set
        {
            state = value;
            if (OnGameStateChange != null)
            {
                OnGameStateChange(state);
            }
        }
    }

    public void StartGame()
    {

    }

}
