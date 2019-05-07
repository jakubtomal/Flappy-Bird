using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] GameObject down;
    [SerializeField] GameObject up;
    [SerializeField] GameObject pass;
    public float speed = 0;
    public Vector3 des;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        des = new Vector3(-8, 0, 0);
        down.transform.localScale = new Vector3(down.transform.localScale.x , Random.RandomRange(1f,48f) , down.transform.localScale.z);
        up.transform.localScale = new Vector3(up.transform.localScale.x, Random.RandomRange(1f, (48f - down.transform.localScale.y)), up.transform.localScale.z);

        //Debug.Log("down : " + down.transform.localScale.y);
        //Debug.Log("up : " +up.transform.localScale.y);
        //Debug.Log(48f -down.transform.localScale.y);

        //Debug.Log(down.GetComponent<SpriteRenderer>());






    }

    // Update is called once per frame
    void Update()
    {
        dir = des - transform.position;
        if( Vector3.Distance(des , transform.position) > 0.5)
        {
            //transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        }
        else
        {
            Destroy(gameObject);
        }
        
        if (pass.GetComponent<BoxCollider2D>(). )
        {
            FindObjectOfType<Level>().AddScore();
            Debug.Log("point");
            Destroy(gameObject);

        }
        


    }
}
