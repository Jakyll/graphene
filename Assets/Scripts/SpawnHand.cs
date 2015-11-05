using UnityEngine;
using System.Collections;

public class SpawnHand : MonoBehaviour {

	public GameObject cardPrefab;

	// Use this for initialization
	void Start () {
		float xPos = 0;
		float yPos = 0;

		int handId = 0;

		for(int i = 0; i < 1; i++) {
			xPos += 6;
			SpawnCard.CreateCard(cardPrefab, transform, xPos, yPos, handId);
			handId += 1;
		}

		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
