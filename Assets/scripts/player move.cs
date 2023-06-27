using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class playermove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigidBody;
    private Vector2 movementInput;
    private Animator anim;
    public int cash;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       //if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
       // {
       //     anim.enabled = true;
       //     anim.SetTrigger("back anim");
            
       // }
 

       // if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
       // {
       //     anim.enabled = true;
       //     anim.SetTrigger("forward anim");
            
       // }
    

       // if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
       // {
       //     anim.enabled = true;
       //     anim.SetTrigger("leftanim");
            
       // }
    

       // if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
       // {
       //     anim.enabled = true;
       //     anim.SetTrigger("rightanim");
       // }   
            

       // if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A))
       // {
       //     anim.enabled= false;
       // }
       anim.SetFloat("horizontal", movementInput.x);
       anim.SetFloat("vertical", movementInput.y);
        anim.SetFloat("sped",movementInput.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        
    }
    private void LateUpdate()
    {
        rigidBody.velocity = movementInput * speed ;
    }
    private void OnMove(InputValue inputValue)
    {
    movementInput = inputValue.Get<Vector2>();

}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.CompareTag("coins"))
        {
            Destroy(collision.gameObject);
            cash++;
        }
    }

}
