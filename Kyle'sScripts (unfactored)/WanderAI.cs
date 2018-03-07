using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderAI : MonoBehaviour {


    //Variables needed for the Coroutine.
    public float moveSpeed = 3f;
    public float rotSpeed = 100f;
    private bool rotLeft = false;
    private bool rotRight = false;
    private bool isWandering = false;
    private bool isWalking = false;

    // Checks to see if the character is wandering, starts the coroutine if it isnt. checks bools triggered by the coroutine for calculations.
    private void Update ()
    {
        if (isWandering == false)
        {
            StartCoroutine(Wander());
        }
        if (rotRight)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }
        if (rotLeft)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
        }
        if (isWalking)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

     IEnumerator Wander()
    {
        //Random variables specific to this coroutine.
        int rotTime = UnityEngine.Random.Range(1,3);
        int rotWait = UnityEngine.Random.Range(1, 4);
        int rotLorR = UnityEngine.Random.Range(0, 3);
        int walkwait = UnityEngine.Random.Range(1, 4);
        int walktime = UnityEngine.Random.Range(1, 5);

        isWandering = true;

        //checks to see if they are wandering, if so, provides random amounts for the unit to wander.

        yield return new WaitForSeconds(walkwait);
        isWalking = true;
        yield return new WaitForSeconds(walktime);
        isWalking = false;
        yield return new WaitForSeconds(rotWait);
            if (rotLorR == 1)
            {
            rotRight = true;
            yield return new WaitForSeconds(rotTime);
            rotRight = false;
            }
            if (rotLorR == 2)
            {
            rotLeft = true;
            yield return new WaitForSeconds(rotTime);
            rotLeft = false;
            }

        isWandering = false;

    }
}
