using UnityEngine;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.Text;

public class SpawnCard : MonoBehaviour
{
	public static void CreateCard(GameObject cardClone, Card card)
	{
		cardClone.transform.Find("CardName").gameObject.GetComponent<TextMesh>().text = card.Name.ToString().ToUpper();
		cardClone.transform.Find("CardAttack").gameObject.GetComponent<TextMesh>().text = card.Attack.ToString().ToUpper();
		cardClone.transform.Find("CardDefence").gameObject.GetComponent<TextMesh>().text = card.Defence.ToString().ToUpper();
		//cardClone.transform.Find("CardManaCost").gameObject.GetComponent<TextMesh>().text = card.ManaCost[0].Cost.ToString().ToUpper();
		cardClone.transform.Find("CardType").gameObject.GetComponent<TextMesh>().text = card.Type.ToString().ToUpper();

		string subtype = card.Subtype[0];
		for(int i = 1; i < card.Subtype.Count; i++)
		{
			subtype += ", " + card.Subtype[i];
		}
		cardClone.transform.Find("CardSubtype").gameObject.GetComponent<TextMesh>().text = subtype.ToUpper();
		cardClone.transform.Find("CardDescription").gameObject.GetComponent<TextMesh>().text = card.Description.ToString();

		cardClone.transform.Find("CardFront").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[1].Color;
		//cardClone.transform.Find("CardFrontTop").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[1].Color;
		//cardClone.transform.Find("CardFrontMid").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[1].Color;
		//cardClone.transform.Find("CardFrontBot").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[1].Color;

		cardClone.transform.Find("CardArt").gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load(card.Id.ToString(), typeof(Sprite)) as Sprite;
	}
}
