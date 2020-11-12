using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Animator playerAnim;
    
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            playerAnim.SetBool("isstrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("isstrafe", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            playerAnim.SetBool("isstrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("isstrafe", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, -90, 0);
            playerAnim.SetBool("isstrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnim.SetBool("isstrafe", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 90, 0);
            playerAnim.SetBool("isstrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("isstrafe", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetTrigger("iattack");
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("touchcube"))
        {
            playerAnim.SetTrigger("death");
        }
    }

}
