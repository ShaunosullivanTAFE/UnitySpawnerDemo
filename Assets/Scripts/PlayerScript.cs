using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float playerSpeed = 7f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + (Input.GetAxis("Horizontal") * playerSpeed) * Time.deltaTime , transform.position.y);
        
        // transform.TransformDirection <- more efficient
         
        //transform.position.x = transform.position.x + (Input.GetAxis("Horizontal") * playerSpeed) * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
