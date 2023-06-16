using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class playermove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigidbody;
    private Vector2 movementInput;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.W))
            {
            anim.SetTrigger("back anim");
        }
        if (Input.GetKeyUp(KeyCode.W))
            {
            anim.SetTrigger("stopbacc");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("forward anim");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetTrigger("stopfront");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("leftanim");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetTrigger("stopleft");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("rightanim");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetTrigger("stopright");
        }
    }
    private void FixedUpdate()
    {
        
    }
    private void LateUpdate()
    {
        rigidbody.velocity = movementInput * speed ;
    }
    private void OnMove(InputValue inputValue)
    {
    movementInput = inputValue.Get<Vector2>();

}

}
