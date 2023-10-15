using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebarril : MonoBehaviour
{
    public float speed = -5.0f;

    void Update()
    {
        transform.position = transform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}
