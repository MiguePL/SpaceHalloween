using UnityEngine;
using System.Collections;

public class Detector : MonoBehaviour
{

    public Rigidbody2D rb_mina;

    void OnTriggerEnter2D(Collider2D objeto)
    {
        if (objeto.tag == "Player")
        {
            rb_mina.isKinematic = false;
        }

    }

}