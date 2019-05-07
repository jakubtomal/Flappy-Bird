using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Level : MonoBehaviour
{
    [SerializeField] Transform barrierPrefab;
    [Range(0,10)][SerializeField] float timeBeetweneBarriers;
    private float countdown;
    [Range(0, 10)] [SerializeField] float speed;
    [SerializeField] TextMeshProUGUI scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        countdown = timeBeetweneBarriers;
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (countdown <= 0f && speed > 0)
        {
            Instantiate(barrierPrefab, barrierPrefab.position, barrierPrefab.rotation);
            countdown = timeBeetweneBarriers;
        }

        countdown -= Time.deltaTime;

        scoreText.text = score.ToString();

    }
    public void AddScore()
    {
        score += 100;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void Stop()
    {
        speed = 0;
    }

    
}
