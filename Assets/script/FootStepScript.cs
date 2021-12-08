using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepScript : MonoBehaviour
{

	public AudioSource footStep;
	private bool IsMoving;

	// Update is called once per frame
	void Update()
	{

		if ((Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f))
		{
			IsMoving = true;
		}
		else
		{
			IsMoving = false;
		}

		if (IsMoving && !footStep.isPlaying)
		{
			footStep.Play();
		}
		if (!IsMoving)
		{
			footStep.Stop();
		}
	}



}
