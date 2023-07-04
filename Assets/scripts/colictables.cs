using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colictables : MonoBehaviour
  
  
{

    public bool speed, helt;
        public int speedbuff, heltbuff, duration;
    public playermove Player;
    private float basespeed;

    // Start is called before the first frame update
      void Start()
    {
     basespeed = Player.speed;
    } 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (speed)
        {
            Player.speed += speedbuff;
            StartCoroutine(backtobasespeed());
        }
        if (helt)
        {
            Player.hp += heltbuff;
        }
    }
    IEnumerator backtobasespeed()
    {
        yield return new WaitForSeconds(duration);
        Player.speed = basespeed;
    }
      

    // Update is called once per frame

}
