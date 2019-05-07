using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] Transform barrierPrefab;
    public float timeBeetweneBarriers;
    public float countdown;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0f)
        {
            Instantiate(barrierPrefab, barrierPrefab.position, barrierPrefab.rotation);
            countdown = timeBeetweneBarriers;
        }

        countdown -= Time.deltaTime;
        //Debug.Log(score);

    }
    public void AddScore()
    {
        score += 1;
    }
    
}
