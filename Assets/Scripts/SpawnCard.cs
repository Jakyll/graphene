using UnityEngine;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.Text;

public class SpawnCard : MonoBehaviour
{
	void test ()
	{
		Card card = new Card();

		card.Id = (1);
		card.Name = ("Orc Underdog");
		card.Attack = (12);
		card.Defence = (12);
		card.Type = ("Creature");
		card.Subtype = ("Orc, Warrior");
		card.Description = (UITools.WordWrap("Orc Underdog has +1/+1 for each adjacent Orc.", 20));
		card.ManaCost.Add(new Mana("neutral", 2));
		card.ManaCost.Add(new Mana("red", 2));

		transform.Find("CardName").gameObject.GetComponent<TextMesh>().text = card.Name.ToString().ToUpper();
		transform.Find("CardAttack").gameObject.GetComponent<TextMesh>().text = card.Attack.ToString().ToUpper();
		transform.Find("CardDefence").gameObject.GetComponent<TextMesh>().text = card.Defence.ToString().ToUpper();
		//transform.Find("CardManaCost").gameObject.GetComponent<TextMesh>().text = card.NeutralCost.Cost.ToString().ToUpper();
		transform.Find("CardType").gameObject.GetComponent<TextMesh>().text = card.Type.ToString().ToUpper();
		transform.Find("CardSubtype").gameObject.GetComponent<TextMesh>().text = card.Subtype.ToString().ToUpper();
		transform.Find("CardDescription").gameObject.GetComponent<TextMesh>().text = card.Description.ToString().ToUpper();
		transform.Find("CardFront").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[1].Color;
		transform.Find("CardArt").gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load(card.Id.ToString(), typeof(Sprite)) as Sprite;
	}

	public static void CreateCard(GameObject cardPrefab, Transform transform, float xPos, float yPos, int handId)
	{
		GameObject cardClone = Instantiate (cardPrefab, new Vector3 (0F, 0F, 0F), Quaternion.Euler (0, 0, 0)) as GameObject;

		Card card = new Card();

//		card.Id = (1);
//		card.Name = ("Orc Underdog");
//		card.Attack = (12);
//		card.Defence = (12);
//		card.Type = ("Creature");
//		card.Subtype = ("Orc, Warrior");
//		card.Description = (UITools.WordWrap("Orc Underdog has +1/+1 for each adjacent Orc.", 30));
//		card.ManaCost.Add(new Mana("neutral", 2));
//		card.ManaCost.Add(new Mana("red", 2));

		card.Id = (2);
		card.Name = ("Angel Knight");
		card.Attack = (2);
		card.Defence = (4);
		card.Type = ("Creature");
		card.Subtype = ("Angel, Knight");
		card.Description = (UITools.WordWrap("When this creature dies, draw a card, if that card is another Angel Knight, play it on the same tile.", 32));
		card.ManaCost.Add(new Mana("neutral", 1));
		card.ManaCost.Add(new Mana("red", 1));

		cardClone.transform.Find("CardName").gameObject.GetComponent<TextMesh>().text = card.Name.ToString().ToUpper();
		cardClone.transform.Find("CardAttack").gameObject.GetComponent<TextMesh>().text = card.Attack.ToString().ToUpper();
		cardClone.transform.Find("CardDefence").gameObject.GetComponent<TextMesh>().text = card.Defence.ToString().ToUpper();
		cardClone.transform.Find("CardManaCost").gameObject.GetComponent<TextMesh>().text = card.ManaCost[1].Cost.ToString().ToUpper();
		cardClone.transform.Find("CardType").gameObject.GetComponent<TextMesh>().text = card.Type.ToString().ToUpper();
		cardClone.transform.Find("CardSubtype").gameObject.GetComponent<TextMesh>().text = card.Subtype.ToString().ToUpper();
		cardClone.transform.Find("CardDescription").gameObject.GetComponent<TextMesh>().text = card.Description.ToString();

		cardClone.transform.Find("CardFront").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[1].Color;

		cardClone.transform.Find("CardFrontTop").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[1].Color;
		cardClone.transform.Find("CardFrontMid").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[1].Color;
		cardClone.transform.Find("CardFrontBot").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[1].Color;

		cardClone.transform.Find("CardArt").gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load(card.Id.ToString(), typeof(Sprite)) as Sprite;

		cardClone.name = "Hand_" + handId;
		cardClone.transform.parent = transform;
		cardClone.transform.localPosition = new Vector3 (xPos, yPos, 0F);
		cardClone.transform.localScale = new Vector3 (1.0F, 1.0F, 0.5F);
	}
}
