using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            EventBus.TriggerEvent("Shoot");
        }
        if (Input.GetKeyDown("w"))
        {
            EventBus.TriggerEvent("Launch");
        }
        if (Input.GetKeyDown("e"))
        {
            EventBus.TriggerEvent("Eject");
        }
        if (Input.GetKeyDown("r"))
        {
            EventBus.TriggerEvent("Accelerate");
        }
        if (Input.GetKeyDown("t"))
        {
            EventBus.TriggerEvent("SelfDestruct");
        }
    }
}

