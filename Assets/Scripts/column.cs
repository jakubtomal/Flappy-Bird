using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class column : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<Level>().Stop();
    }
}
