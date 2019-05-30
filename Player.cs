using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 10;

    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement.
        float input = Input.GetAxisRaw("Horizontal");
        transform.Translate(new Vector3(input * Time.deltaTime * Speed, 0, 0));

        float maxXPosition = Camera.main.aspect * Camera.main.orthographicSize;

        if (transform.position.x > maxXPosition)
        {
            transform.position = new Vector3(maxXPosition, transform.position.y, 0);
        }
        else if (transform.position.x < -maxXPosition)
        {
            transform.position = new Vector3(-maxXPosition, transform.position.y, 0);
        }

        //Shooting.
        if (Input.GetButtonDown("Jump")) //If the player press Jump (which is the space button).
        {
            GameObject bullet = Instantiate(BulletPrefab); //Create new bullet.
            bullet.transform.position = transform.position + new Vector3(0, .5f, 0); //Place the bullet at the position of the player.
        }
    }
}
