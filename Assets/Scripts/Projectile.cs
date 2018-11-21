using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField] float speed = 1f;

	void Update ()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
