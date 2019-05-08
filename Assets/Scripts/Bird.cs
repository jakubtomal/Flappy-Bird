using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D rigidbody;
    Quaternion downRotation;
    Quaternion forwardRotation;
    [SerializeField] int tapForce;
    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0,0,-90);
        forwardRotation = Quaternion.Euler(0, 0, 40);



    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetTouch(0).phase == TouchPhase.Began ) 
        {
            //Debug.Log("space");
            //rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector2.up * tapForce ,ForceMode2D.Force);
            transform.rotation = forwardRotation;

        }
        transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, 1 * Time.deltaTime);

        
    }

}
