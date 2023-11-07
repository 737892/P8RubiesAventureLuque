using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyControllerr controller = other.GetComponent<RubyControllerr>();
        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
       
    }
}
