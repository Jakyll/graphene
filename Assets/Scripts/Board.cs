using System.Collections;
using System.Collections.Generic;

public class Board
{
	private List<Tile> hexBoard = new List<Tile>();

	public Board()
	{
		for(int i = 0; i < 15; i++)
		{
			Tile tile = new Tile(i);
			this.hexBoard.Add(tile);
		}
	}

	public List<Tile> HexBoard {
		get {
			return hexBoard;
		}
		set {
			hexBoard = value;
		}
	}

	public void summonUnit(int tileId, Card card)
	{
		hexBoard[tileId].Card = card;
	}

	public void moveUnit(int targetTile, int destTile)
	{
		hexBoard[destTile].Card = hexBoard[targetTile].Card;
		hexBoard[targetTile].Card = null;
	}
}
