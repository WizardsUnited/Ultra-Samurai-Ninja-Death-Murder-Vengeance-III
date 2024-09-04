using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roninanims : MonoBehaviour
{
    // Start is called before the first frame update
    Animator roninAnimator;
    Transform currentTransform;
    bool isKicking;
    private void Awake()
    {
        roninAnimator = GetComponent<Animator>();
    }


    void Start()
    {
        currentTransform = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {

      
        
       



        if (Input.GetKeyDown(KeyCode.F))
            {
            currentTransform = gameObject.transform; //hopefuly resets transform
            roninAnimator.Play("ind_kick");
            currentTransform = gameObject.transform;

        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            currentTransform = gameObject.transform;
            roninAnimator.Play("ind_heavyAttack");
            currentTransform = gameObject.transform;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            currentTransform = gameObject.transform;
            roninAnimator.SetBool("isWalking", true);
            currentTransform = gameObject.transform;
        }
             else if (Input.GetKeyDown(KeyCode.J))
             {
                 roninAnimator.SetBool("isWalking", false);
              }
        if (Input.GetKeyDown(KeyCode.K))
        {
            currentTransform = gameObject.transform;
            roninAnimator.SetBool("isRunning", true);
            currentTransform = gameObject.transform;
        }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                roninAnimator.SetBool("isRunning", false);
            }else if (Input.GetKeyDown(KeyCode.N))
        {
            currentTransform = gameObject.transform;
            roninAnimator.Play("ind_sprintdeath");
            currentTransform = gameObject.transform;
        }
            
        
        
        ////memes/////
        
        
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            currentTransform = gameObject.transform;
            roninAnimator.Play("meme_backflip");
            currentTransform = gameObject.transform;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            currentTransform = gameObject.transform;
            roninAnimator.Play("meme_bd");
            currentTransform = gameObject.transform;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            currentTransform = gameObject.transform;
            roninAnimator.Play("meme_macarena");
            currentTransform = gameObject.transform;
        }

        ////deaths///
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentTransform = gameObject.transform;
            roninAnimator.Play("ind_death1");
            currentTransform = gameObject.transform;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentTransform = gameObject.transform;
            roninAnimator.Play("ind_death2");
            currentTransform = gameObject.transform;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentTransform = gameObject.transform;
            roninAnimator.Play("ind_death4");
            currentTransform = gameObject.transform;
        }




    }
}
