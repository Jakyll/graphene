using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class CollectionController : MonoBehaviour {

	public GameObject cardPrefab;
	public GameObject manaPrefab;

	// Use this for initialization
	void Start ()
	{
		List<Card> cardCollection = new List<Card>();
		cardCollection = CollectionLoader.LoadCollection();

		float xPos = -4F;

		foreach(Card card in cardCollection)
		{
			GameObject cardClone = Instantiate(cardPrefab, new Vector3 (0F, 0F, 0F), Quaternion.Euler (0, 0, 0)) as GameObject;

			SpawnCard SpawnCard = new SpawnCard();

			SpawnCard.CreateCard(cardClone, card, manaPrefab);

			cardClone.name = "Card_" + card.Id;
			cardClone.transform.parent = transform;
			cardClone.transform.localPosition = new Vector3 (xPos, 0F, 0F);
			cardClone.transform.localScale = new Vector3 (0.35F, 0.35F, 0.5F);

			xPos += 4;
		}
	}
}
