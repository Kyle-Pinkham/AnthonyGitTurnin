using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HueJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.H)){
            CharacterController cc = this.GetComponent<CharacterController>();
            cc.transform.Translate(0, 4, 0);

        }
	}
}
