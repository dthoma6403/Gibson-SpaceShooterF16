﻿using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {
	
	static public Hero		S;
	
	public float	speed = 30;
	public float	rollMult = -45;
	public float  	pitchMult=30;
	
	public float	shieldLevel=1;
	
	public bool	_____________________;
	public Bounds bounds;
	
	void Awake(){
		S = this;
	}
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float xAxis = Input.GetAxis("Horizontal");
		float yAxis = Input.GetAxis("Vertical");
		
		Vector3 pos = transform.position;
		pos.x += xAxis * speed * Time.deltaTime;
		pos.y += yAxis * speed * Time.deltaTime;
		transform.position = pos;

		
		// rotate the ship to make it feel more dynamic
		transform.rotation =Quaternion.Euler(yAxis*pitchMult, xAxis*rollMult,0);
	}
}