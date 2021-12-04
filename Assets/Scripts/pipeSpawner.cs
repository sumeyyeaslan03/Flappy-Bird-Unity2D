using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{

    public float maxTime=2;
    private float timer=0;
    public GameObject pipes;
    public float height;

    void Start()
    {
        GameObject pipe =Instantiate(pipes);
        pipe.transform.position =transform.position+ new Vector3(0, Random.Range(-height, height), 0);
        
    }

    void Update()
    {
        if(timer>maxTime){
            GameObject pipe =Instantiate(pipes);
            pipe.transform.position =transform.position+ new Vector3(0, Random.Range(-height, height), 0);
            Destroy(pipe, 10);
            timer=0;
        }
        timer +=Time.deltaTime;
        
    }
}
