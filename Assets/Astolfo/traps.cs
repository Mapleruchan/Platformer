using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traps : MonoBehaviour
    
{
   public Animator anim;
    public int trapDmg;
    public playermove Player;
    public bool playeron;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playeron = true;
        if (collision.gameObject.CompareTag("Player"))
            {
            anim.SetBool("active", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playeron = false;
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("active", false);
        }
    }
    public void PlayerDamage()
    { 
     if (playeron) 
        {
            Player.hp -= trapDmg;
        }
    }
}
    