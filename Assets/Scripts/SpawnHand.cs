using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnHand : MonoBehaviour {

	public GameObject cardPrefab;
	public GameObject manaPrefab;

	// Use this for initialization
	void Start () {
		float xPos = 0F;
		float yPos = 0F;

		float scale = 0.25F;
		float xOffset = scale * 10F;
		//float rotation = 6F;

		int handId = 0;
		List<Card> hand = new List<Card>();
		hand = CollectionLoader.LoadCollection();

		for(int i = 0; i < 3; i++)
		{
			Card card = hand[i];
			GameObject cardClone = Instantiate(cardPrefab, new Vector3 (0F, 0F, 0F), Quaternion.Euler (0, 0, 0)) as GameObject;
			
			SpawnCard SpawnCard = new SpawnCard();
			
			SpawnCard.CreateCard(cardClone, card, manaPrefab);
			cardClone.name = handId.ToString();
			cardClone.transform.parent = transform;
			cardClone.transform.localPosition = new Vector3 (xPos, yPos, (float)-handId);
			cardClone.transform.localScale = new Vector3 (scale, scale, 0.5F);

			xPos += xOffset;
			handId += 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
