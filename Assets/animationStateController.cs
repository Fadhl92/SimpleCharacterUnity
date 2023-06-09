using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        
    }

    // Update is called once per frame
    void Update()
    {

        bool forwardPressed = Input.GetKey("w");
        bool isWalking = animator.GetBool(isWalkingHash);

        // if player presse w key

        if (!isWalking && forwardPressed)
        {
            // then set the isWalking boolean to be true
            animator.SetBool("isWalking", true);
        }

        // if player is not pressing w key
        if(isWalking && !forwardPressed)
        {
            // then set the isWalking boolean to be false
            animator.SetBool("isWalking", false);
        }
        
    }
}
