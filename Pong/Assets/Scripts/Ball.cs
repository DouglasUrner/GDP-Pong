using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Ball : MonoBehaviour {
	public float speed = 30f;

	// Use this for initialization
	private void Start() {
		// Start the ball moving
		GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
	
	// 
	private void OnCollisionEnter2D(Collision2D col) {
		
		// Ignore collisions with walls.
		
		if (col.gameObject.name == "PaddleLeft") {
			float hf = hitFactor(transform, col);
			Vector2 dir = new Vector2(1, hf).normalized;
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}
		
		if (col.gameObject.name == "PaddleRight") {
			float hf = hitFactor(transform, col);
			Vector2 dir = new Vector2(-1, hf).normalized;
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}
	}

	private static float hitFactor(Transform t, Collision2D c) {
		return (t.position.y - c.transform.position.y) / c.collider.bounds.size.y;
	}
}
