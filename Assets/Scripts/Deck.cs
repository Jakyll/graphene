using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;
using System;

public class Deck : MonoBehaviour {

	ArrayList deck = new ArrayList();
	string path;
	
	public Deck(string deckPath)
	{
		path = deckPath;
		ReadDeck (path);
		Shuffle ();
	}

	void Start () 
	{
	
	}
	
	void ReadDeck(string path)
	{
		XmlReader reader = XmlReader.Create("Assets/Cards/deck.xml");
		
		while(reader.ReadToFollowing ("card"))
		{
			reader.ReadToFollowing("id");
			int id = reader.ReadElementContentAsInt ();
			reader.ReadToFollowing("count");
			int count = reader.ReadElementContentAsInt ();
			for(int i=0; i<count; i++)
			{
				deck.Add (id);
			}	
		}	
	}



	void Shuffle()
	{
		int tmp;
		int index;
		System.Random rand = new System.Random();
		for(int i=0; i<deck.Count; i++)
		{
			tmp = (int)deck[i];
			index = rand.Next(deck.Count);
			deck[i] = deck[index];
			deck[index] = tmp;
		}
		for(int i=0; i<deck.Count; i++)
		{
			print (deck[i]);
		}

	}
}
