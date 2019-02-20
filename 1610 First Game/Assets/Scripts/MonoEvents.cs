using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, MouseDownEvent, UpdateEvent;
    
    void Start()
    {
        StartEvent.Invoke();
    }

    private void OnEnable()
    {
        print("Enabled");
    }

    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }

    void Update()
    {
        
    }
}
