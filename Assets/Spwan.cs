using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spwan : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightoffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spwanPipe();
            timer = 0;
        }
    }
    void spwanPipe() {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
}
