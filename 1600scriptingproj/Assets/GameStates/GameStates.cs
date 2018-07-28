using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStates : MonoBehaviour {

    // objects for state
    public GameStateBase Starting;
    public GameStateBase Playing;
    public GameStateBase Ending;

    //enum list - creates drop down menu
    public enum States
    {
        Starting,
        Playing,
        Ending
    }

    void Update()
    {
        ChangeState();
    }

    // variable
    public States CurrentState;

    // switch statement that can "switch" states
    public void ChangeState()
    {
        switch (CurrentState)
        {
            case States.Starting:
                Starting.Run();
                break;

            case States.Playing:
                Playing.Run();
                break;

            case States.Ending:
                Ending.Run();
                break;
        }
    }
}
