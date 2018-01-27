using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryGoalTrigger : MonoBehaviour {

	Collider expectedCollider;

	public void ExpectedCollider(Collider collider)
	{
		expectedCollider = collider;
	}

	void OnTriggerEnter(Collider otherCollider)
	{
		if (otherCollider == expectedCollider) 
		{
			ScoreKeep scorekeep = FindObjectOfType<ScoreKeep> ();
			scorekeep.IncrementScore (1);
		}
	}
}
