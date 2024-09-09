using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Collider : MonoBehaviour
{
    public UnityEvent OnTriggerEnterEvent;
    public string Tag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag(Tag))
        {
            OnTriggerEnterEvent?.Invoke();
        }
    }
}
