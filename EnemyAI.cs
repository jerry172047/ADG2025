using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public EnemyState currentState;

    public bool isAttacking;
    public bool isChasing;
    public bool isIdle;
    public bool isFleeing;

    void Start()
    {
        isIdle = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isIdle)
        {
            currentState = EnemyState.Idle;
        }
        else if(isChasing)
        {
            currentState = EnemyState.Chase;
        }
        else if(isAttacking)
        {
            currentState = EnemyState.Attack;
        }
        else
        {
            currentState = EnemyState.Flee;
        }
        
        switch (currentState)
        {
            case EnemyState.Idle: IdleBehaviour(); break;
            case EnemyState.Chase: ChaseBehaviour(); break;
            case EnemyState.Attack: AttackBehaviour(); break;
            case EnemyState.Flee: FleeBehaviour(); break;
        }

    }

    public void IdleBehaviour()
    {
        Debug.Log("I am idle right now");
    }
    public void ChaseBehaviour()
    {
        Debug.Log("I am chasing right now!");
    }
    public void AttackBehaviour()
    {
        Debug.Log("I am attacking right now!");
    }
    public void FleeBehaviour()
    {
        Debug.Log("Bhagooooooo!");
    }
}

public enum EnemyState
{
    Idle,
    Chase,
    Attack,
    Flee
}