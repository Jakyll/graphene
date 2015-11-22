using UnityEngine;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.Text;

public class SpawnCard : MonoBehaviour
{
	public void CreateCard(GameObject cardClone, Card card, GameObject manaPrefab)
	{
		cardClone.transform.Find("CardFrontDuoLeft").gameObject.GetComponent<SpriteRenderer>().enabled = false;
		cardClone.transform.Find("CardFrontTriLeft").gameObject.GetComponent<SpriteRenderer>().enabled = false;
		cardClone.transform.Find("CardFrontTriRight").gameObject.GetComponent<SpriteRenderer>().enabled = false;

		cardClone.transform.Find("CardName").gameObject.GetComponent<TextMesh>().text = card.Name.ToString().ToUpper();
		cardClone.transform.Find("CardAttack").gameObject.GetComponent<TextMesh>().text = card.Attack.ToString().ToUpper();
		cardClone.transform.Find("CardDefence").gameObject.GetComponent<TextMesh>().text = card.Defence.ToString().ToUpper();

		float xPos = -1.45F;
		int manaId = 0;

		foreach(Mana mana in card.ManaCost)
		{
			GameObject manaGem = Instantiate(manaPrefab, new Vector3 (0F, 0F, 0F), Quaternion.Euler (0, 0, 0)) as GameObject;

			manaGem.transform.Find("Cost").gameObject.GetComponent<TextMesh>().text = mana.Cost.ToString();
			manaGem.transform.Find("Gem").gameObject.GetComponent<SpriteRenderer>().color = mana.Color;

			manaGem.name = "Mana_" + manaId;
			manaGem.transform.parent = cardClone.transform.Find("CardManaCost").gameObject.transform;
			manaGem.transform.localPosition = new Vector3 (xPos, 0F, 0F);
			manaGem.transform.localScale = new Vector3 (0.75F, 0.75F, 0.5F);

			xPos += 1F;
			manaId += 1;
		}


		//cardClone.transform.Find("CardManaCost").gameObject.GetComponent<TextMesh>().text = card.ManaCost[0].Cost.ToString().ToUpper();
		cardClone.transform.Find("CardType").gameObject.GetComponent<TextMesh>().text = card.Type.ToString().ToUpper();

		string subtype = card.Subtype[0];
		for(int i = 1; i < card.Subtype.Count; i++)
		{
			subtype += ", " + card.Subtype[i];
		}
		cardClone.transform.Find("CardSubtype").gameObject.GetComponent<TextMesh>().text = subtype.ToUpper();
		cardClone.transform.Find("CardDescription").gameObject.GetComponent<TextMesh>().text = UITools.WordWrap(card.Description.ToString(), 30);


		if(card.ManaCost.Count == 1)
		{
			MonoMana(cardClone, card, 0);
		}
		else if(card.ManaCost.Count == 2)
		{
			if(card.ManaCost[0].Type == "neutral")
			{
				MonoMana(cardClone, card, 1);
			}
			else
			{
				DuoMana(cardClone, card, 0);
			}
		}
		else if(card.ManaCost.Count == 3)
		{
			if(card.ManaCost[0].Type == "neutral")
			{
				DuoMana(cardClone, card, 1);
			}
			else
			{
				TriMana(cardClone, card, 0);
			}
		}
		else if(card.ManaCost.Count == 4)
		{
			TriMana(cardClone, card, 1);
		}

		cardClone.transform.Find("CardArt").gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load(card.Id.ToString(), typeof(Sprite)) as Sprite;
	}

	void MonoMana(GameObject cardClone, Card card, int index)
	{
		cardClone.transform.Find("CardFront").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[index].Color;
	}

	void DuoMana(GameObject cardClone, Card card, int index)
	{
		cardClone.transform.Find("CardFrontDuoLeft").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[index].Color;
		cardClone.transform.Find("CardFront").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[index + 1].Color;
		
		cardClone.transform.Find("CardFrontDuoLeft").gameObject.GetComponent<SpriteRenderer>().enabled = true;
	}

	void TriMana(GameObject cardClone, Card card, int index)
	{
		cardClone.transform.Find("CardFrontTriLeft").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[index].Color;
		cardClone.transform.Find("CardFront").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[index + 1].Color;
		cardClone.transform.Find("CardFrontTriRight").gameObject.GetComponent<SpriteRenderer>().color = card.ManaCost[index + 2].Color;

		cardClone.transform.Find("CardFrontTriLeft").gameObject.GetComponent<SpriteRenderer>().enabled = true;
		cardClone.transform.Find("CardFrontTriRight").gameObject.GetComponent<SpriteRenderer>().enabled = true;
	}

}
