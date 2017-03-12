using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour 
{
	public Animator anim;
	int scream;
	int basicAttack;
	int getHit;
	int walk;
	int die;
	int run;
	public float Speed = 1f;


	void Awake () 
	{
		anim = GetComponent<Animator>();
		scream = Animator.StringToHash("Scream");
		basicAttack = Animator.StringToHash("Basic Attack");
		getHit = Animator.StringToHash("Get Hit");
		walk = Animator.StringToHash("Walk");
		die = Animator.StringToHash("Die");
		run = Animator.StringToHash ("Run");
	}


	public void Update()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			Speed += 0.01f;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			Speed -= 0.01f;
		}
		anim.SetFloat ("Speed", Speed);

		transform.Rotate(Vector3.up, Speed * Time.deltaTime);

		transform.Translate (Vector3.forward * (Speed * Time.deltaTime));
	}		
}
