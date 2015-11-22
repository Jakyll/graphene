using UnityEngine;
using System.Collections;

public class SpawnBoard : MonoBehaviour {

	public GameObject tilePrefab;

	void Start() {
		//change offsetX to change spacing between hex tiles
		float offsetX = 4.1F;
		float offsetY = offsetX + 0.6F;

		float xPos = -(offsetX * 2);
		float yPos = offsetY;

		int tileId = 0;

		PlayerManager pm = new PlayerManager();
		Board board = PlayerManager.player.Board;

		for(int i = 0; i < 5; i++)
		{
			//if 2nd or 4th column
			if(UITools.IsOdd(i)) {
				yPos = offsetY / 2;
				for(int j = 0; j < 3; j++) {
					CreateTile(xPos, yPos, tileId, board.HexBoard[tileId]);
					tileId += 1;
					yPos -= offsetY;
				}
			//1st, 3rd or 5th Column
			} else {
				yPos = offsetY;
				//3 rows for the 1st, 3rd, 5th Column
				for(int j = 0; j < 3; j++) {
					CreateTile(xPos, yPos, tileId, board.HexBoard[tileId]);
					tileId += 1;
					yPos -= offsetY;
				}
			}
			xPos += offsetX;
			yPos = offsetY;
		}
	}

	void Update() {
		PlayerManager pm = new PlayerManager();
		Board board = PlayerManager.player.Board;

		foreach(Tile tile in board.HexBoard)
		{
			UpdateTile(tile);
		}
	}

	void CreateTile(float xPos, float yPos, int tileId, Tile tile)
	{
		GameObject tileClone = Instantiate (tilePrefab, new Vector3 (0F, 0F, 0F), Quaternion.Euler (0, 0, 0)) as GameObject;

		tileClone.transform.Find("CardArt").gameObject.GetComponent<SpriteRenderer>().enabled = false;
		tileClone.transform.Find("CardAttack").gameObject.GetComponent<TextMesh>().text = "";
		tileClone.transform.Find("CardDefence").gameObject.GetComponent<TextMesh>().text = "";

		if(tile.Card != null)
		{
			tileClone.transform.Find("CardArt").gameObject.GetComponent<SpriteRenderer>().enabled = true;
			tileClone.transform.Find("CardArt").gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load(tile.Card.Id.ToString(), typeof(Sprite)) as Sprite;
			tileClone.transform.Find("CardArt").gameObject.GetComponent<SpriteRenderer>().material.mainTexture = Resources.Load(tile.Card.Id.ToString(), typeof(Texture)) as Texture;

			tileClone.transform.Find("CardAttack").gameObject.GetComponent<TextMesh>().text = tile.Card.Attack.ToString();
			tileClone.transform.Find("CardDefence").gameObject.GetComponent<TextMesh>().text = tile.Card.Defence.ToString();
		}

		tileClone.name = "Tile_" + tileId.ToString();
		tileClone.transform.parent = transform;
		tileClone.transform.localPosition = new Vector3 (xPos, yPos, 0F);
		tileClone.transform.localScale = new Vector3 (1F, 1F, 1F);
	}

	void UpdateTile(Tile tile)
	{
		if(tile.Card != null)
		{
			transform.Find("Tile_" + tile.Id.ToString() + "/" + "CardArt").gameObject.GetComponent<SpriteRenderer>().enabled = true;
			transform.Find("Tile_" + tile.Id.ToString() + "/" + "CardArt").gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load(tile.Card.Id.ToString(), typeof(Sprite)) as Sprite;
			
			transform.Find("Tile_" + tile.Id.ToString() + "/" + "CardAttack").gameObject.GetComponent<TextMesh>().text = tile.Card.Attack.ToString();
			transform.Find("Tile_" + tile.Id.ToString() + "/" + "CardDefence").gameObject.GetComponent<TextMesh>().text = tile.Card.Defence.ToString();
		}
		else
		{
			transform.Find("Tile_" + tile.Id.ToString() + "/" + "CardArt").gameObject.GetComponent<SpriteRenderer>().enabled = false;
			transform.Find("Tile_" + tile.Id.ToString() + "/" + "CardAttack").gameObject.GetComponent<TextMesh>().text = "";
			transform.Find("Tile_" + tile.Id.ToString() + "/" + "CardDefence").gameObject.GetComponent<TextMesh>().text = "";
		}
	}
}