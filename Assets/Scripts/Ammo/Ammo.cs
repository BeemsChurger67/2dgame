using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    private float currentSpeed = 5f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * -1 * currentSpeed * Time.fixedDeltaTime);
    }
}
