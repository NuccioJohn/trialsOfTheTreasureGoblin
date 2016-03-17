using UnityEngine;
using System.Collections;

public class GoblinScriptMenu : MonoBehaviour {

	[SerializeField]
	private string color;

	Animator anim;
	int jumpHash = Animator.StringToHash("Jump");
	int sliceAttackHash = Animator.StringToHash("SliceAttack");
	int spellCast = Animator.StringToHash("SpellCast");

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if(color == "Red"){
			anim.SetBool("Jump", true);
		}
		else if(color == "Blue")
		{
			anim.SetBool("Slice Attack", true);
		}
		else
		{
			anim.SetBool("Spell Cast", true);
		}
	
	}
}
