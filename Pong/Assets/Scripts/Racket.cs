using UnityEngine;

public class Racket : MonoBehaviour {
	public float speed = 30;
	public string axis = "Vertical";
	
	// Update is called once per frame
	private void FixedUpdate () {
		var v = Input.GetAxisRaw(axis);
		GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
	}
}
