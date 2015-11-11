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
			xPos += 6F;
			Card card = new Card();
			GameObject cardClone = Instantiate(cardPrefab, new Vector3 (0F, 0F, 0F), Quaternion.Euler (0, 0, 0)) as GameObject;

			card.Id = (1);
			card.Name = ("Orc Underdog");
			card.Attack = (12);
			card.Defence = (12);
			card.Type = ("Creature");
			card.Subtype.Add("Orc");
			card.Subtype.Add("Warrior");
			card.Description = (UITools.WordWrap("Orc Underdog has +1/+1 for each adjacent Orc.", 30));
			card.ManaCost.Add(new Mana("neutral", 2));
			card.ManaCost.Add(new Mana("red", 2));


			SpawnCard SpawnCard = new SpawnCard();
			//SpawnCard.CreateCard(cardClone, card, manaGem);



			cardClone.name = "Hand_" + handId;
			cardClone.transform.parent = transform;
			cardClone.transform.localPosition = new Vector3 (xPos, yPos, 0F);
			cardClone.transform.localScale = new Vector3 (1.0F, 1.0F, 0.5F);
			handId += 1;
		}

		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
