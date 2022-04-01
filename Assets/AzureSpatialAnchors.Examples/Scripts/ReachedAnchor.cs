using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachedAnchor : MonoBehaviour
{
    public AudioClip reachTone;

    private float delay = 5f;
    private bool Triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!Triggered)
        {
            AudioSource.PlayClipAtPoint(reachTone, transform.position, 1);
            Debug.Log("Anchor reached! Trigger tone.");
            Triggered = true;
        }
    }

    private void FixedUpdate()
    {
        if (Triggered)
        {
            delay -= Time.deltaTime;
            if (delay < 0)
            {
                Triggered = false;
                delay = 5f;
            }
        }
    }
}
