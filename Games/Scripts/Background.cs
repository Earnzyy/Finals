using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-200 * Time.deltaTime, 0);

        if(transform.position.x<-1094.001f)
        {
            transform.position=new Vector3(1092.999f, transform.position.y);
        }
    }
}