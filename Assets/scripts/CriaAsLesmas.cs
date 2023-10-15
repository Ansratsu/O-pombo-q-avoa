using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaAsLesmas : MonoBehaviour
{
    public float speed = -10.0f;

    void Update()
    {
        transform.position = transform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
        void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Deathsquare"))
        {
            speed = 0;
			
        }     
    }
}
