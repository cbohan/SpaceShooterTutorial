using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, Speed * Time.deltaTime, 0));

        if (transform.position.y > 10) //If this bullet has gone off the screen.
        {
            //Destroy it.
            Destroy(gameObject);
        }
    }
}
