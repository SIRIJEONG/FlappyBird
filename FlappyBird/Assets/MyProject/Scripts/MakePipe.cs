using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;

    private void Update()
    {
        timer += Time.deltaTime; 
        if(timer > timeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3 (6,Random.Range(-3f , 4f), 0);
            timer = 0;
            Destroy(newPipe ,8.0f);
        }
    }
}
