﻿using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public const int IDLE = 0;
	public const int OPENING = 1;
	public const int OPEN = 2;
	public const int CLOSING = 3;

	public float doorDelay = 0.5f;

	private Animator animator;
	private int state = IDLE;

	void Awake () {
		animator = GetComponent<Animator> ();	
	}
	
	public void Open() {
		animator.SetInteger ("AnimationState", 1);
	}

	void Close () {
		animator.SetInteger ("AnimationState", 2);
	}

	public void CloseWithDelay() {
		Invoke("DelayedClose", doorDelay);
	}

	void EnableCollider2D () {
		collider2D.enabled = true;
	}

	void DisableCollider2D () {
		collider2D.enabled = false;
	}

	void OnOpenStart () {
		state = OPENING;
	}
	
	void OnOpenEnd () {
		state = OPEN;
	}

	void OnCloseStart () {
		state = CLOSING;
	}
	
	void OnCloseEnd () {
		state = IDLE;
	}
}
