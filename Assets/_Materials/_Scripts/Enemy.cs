using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float	speed = 10f; 	// The speed is m/s
	public float	fireRate = 0.3f;	//Seconnds/Shot (Unused)
	public float	health = 10;
	public int 		score = 100; // Points earned for destroying this

	public bool ________________;

	public Bounds	bounds;  // The bounds of this and its children
	public Vector3	boundsCenterOffset; // Distance of bounds.center from position
	
	
	// Update is called once per frame
	void Update () {
		Move ();
}
	public virtual void Move()  {

		Vector3 tempPos = pos;
		tempPos.y -= speed * Time.deltaTime;
		pos = tempPos;
	}

	// This is a property: a method that acts like a field
	public Vector3 pos {
		get {
			return(this.transform.position);
		}

		set {
			this.transform.position = value;
		}


	}
}
