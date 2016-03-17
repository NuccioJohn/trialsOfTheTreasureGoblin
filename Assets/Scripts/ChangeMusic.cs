using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

	public AudioClip menuMusic;
	public AudioClip level1Music;

	private AudioSource source;

	void Start () {

		source = GetComponent<AudioSource>();
	}

	void OnLevelWasLoaded(int level)
	{
		if (level == 0)
		{
			source.clip = menuMusic;
			source.Play ();
		}
		else if (level >= 1)
		{
			source.clip = level1Music;
			source.Play ();
		}
	}

}
