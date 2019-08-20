using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField]
    private List<GameEvent> gameEvents = new List<GameEvent>();

    [SerializeField]
    private UnityEvent response;

    private void OnEnable()
    {
        for (int i = 0; i < gameEvents.Count; ++i)
        {
            gameEvents[i].RegisterListener(this);
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < gameEvents.Count; ++i)
        {
            gameEvents[i].UnregisterListener(this);
        }
    }

    public void OnEventRaised()
    {
        response.Invoke();
    }
}
