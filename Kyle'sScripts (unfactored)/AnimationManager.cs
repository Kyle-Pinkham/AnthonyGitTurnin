using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationManager : MonoBehaviour {

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void WalkingAndIdle()
    {
        if (animator.GetFloat("isWalking") == 0)
        {
            animator.SetTrigger("toIdle");
        }
        else
        {
            animator.SetFloat("isWalking", 1);
        }
    }

    public void Magic()
    {
        animator.SetTrigger("castMagic");
    }

    public void Attack()
    {
        animator.SetTrigger("useAttack");
    }

    public void Jump()
    {
        animator.SetTrigger("doJump");
    }

    public void ForceWalk()
    {
        animator.SetFloat("isWalking", 1);
    }

}
