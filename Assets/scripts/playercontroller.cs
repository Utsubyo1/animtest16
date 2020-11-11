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
            playerAnim.SetBool("isstrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("isstrafe", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);
            playerAnim.SetBool("isstrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
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
