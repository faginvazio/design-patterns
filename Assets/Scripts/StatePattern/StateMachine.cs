using System;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine<T> where T : Enum
{
    private Dictionary<T, FsmState<T>> states = new();
    private FsmState<T> currentState;

    public void AddState(FsmState<T> state)
    {
        states[state.StateType] = state;
    }

    public void ChangeState(T newState, FsmMessage msg = default)
    {
        currentState?.OnExit(newState);
        currentState = states[newState];
        currentState.OnEnter(newState, msg);
    }

    public void Update(float deltaTime)
    {
        currentState?.OnUpdate(deltaTime);
    }
}
