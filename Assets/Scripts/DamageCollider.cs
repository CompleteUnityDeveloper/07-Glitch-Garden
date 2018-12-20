using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour {

    private void OnTriggerEnter2D()
    {
        FindObjectOfType<LivesDisplay>().TakeLife();
    }
}
