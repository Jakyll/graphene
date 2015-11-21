using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Board : MonoBehaviour 
{
	public List<tile> board;
	// Use this for initialization
	void Start () 
	{
		for(int i; i < 15; i++)
		{
			board.Add(new Tile());
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
