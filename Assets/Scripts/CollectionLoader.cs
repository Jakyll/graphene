using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

public class CollectionLoader : MonoBehaviour {

	List<Card> collection = new List<Card>();

	// Use this for initialization
	void Start () 
	{
		LoadCollection ("Assets/Resources/XML/CardList.xml");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void LoadCollection(string path)
	{
		//TODO this should only read cards that the player owns, read first playerLibrary XML file

		//XElement doc= XElement.Load("Assets/Resources/XML/CardList.xml");

		//XDocument xdocument = XDocument.Load("Assets/Resources/XML/CardList.xml");
		//IEnumerable<XElement> cards = xdocument.Elements();



		XElement xelement = XElement.Load("Assets/Resources/XML/CardList.xml");
		IEnumerable<XElement> cards = xelement.Elements();
		// Read the entire XML
		foreach (var card in cards)
		{
			Card cardObject = new Card();

			cardObject.Id = int.Parse (card.Attribute("id").Value);
			cardObject.Name = card.Element("name").Value;
			cardObject.Attack = int.Parse(card.Element("attack").Value);
			cardObject.Defence = int.Parse(card.Element("defence").Value);
			cardObject.Description = card.Element("description").Value;
			cardObject.Type = card.Element("type").Value;

			IEnumerable<XElement> costs = card.Element ("manaCost").Elements();
			List<Mana> manaList = new List<Mana>();

			foreach(var e in costs)
			{
				Mana mana = new Mana(e.Name.ToString(), int.Parse (e.Value)); 
				manaList.Add (mana);
			}

			cardObject.ManaCost = manaList;

			IEnumerable<XElement> subTypes = card.Element ("subTypes").Elements ();
			List<string> typeList = new List<string>();

			foreach(var e in subTypes)
			{
				typeList.Add (e.Value);
			}

			cardObject.Subtype = typeList;
		}
	}

}
