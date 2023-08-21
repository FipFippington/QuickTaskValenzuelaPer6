using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 40.0f;

    // Update is called once per frame
    public void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
