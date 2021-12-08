using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachedAnchor : MonoBehaviour
{
    public AudioClip reachTone;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(reachTone, transform.position, 1);
        Debug.Log("Anchor reached! Trigger tone.");
    }
}
