using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FigureTapAction : MonoBehaviour
{
    [SerializeField] private ParticleSystem _rightFire, _leftFire;

    private void Start()
    {
        SetUpEventTrigger();
    }

    private void SetUpEventTrigger()
    {
        EventTrigger trigger = gameObject.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((eventDate) => { OnTapFigure(); });
        trigger.triggers.Add(entry);
    }

    private void OnTapFigure()
    {
        _rightFire.Play();
        _leftFire.Play();
    }
}
