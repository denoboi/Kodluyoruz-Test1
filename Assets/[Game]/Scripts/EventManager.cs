using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static UnityEvent OnCoinPickUp = new UnityEvent();
    public static UnityEvent<int> OnScoreChange = new UnityEvent<int>();
    public static UnityEvent OnGameOver = new UnityEvent();
}
