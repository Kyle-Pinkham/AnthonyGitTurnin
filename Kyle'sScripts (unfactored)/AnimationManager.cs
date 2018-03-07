using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationManager : MonoBehaviour {

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Walking()
    {
        animator.SetFloat("isWalking", 1);
    }

    public void Magic()
    {
        animator.SetTrigger("castMagic");
    }

    public void Attack()
    {
        animator.SetTrigger("useAttack");
    }

}
