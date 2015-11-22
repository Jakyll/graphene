using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HexHover : MonoBehaviour {

	private bool mouseOver;
	public float brightness = 0.075F;

	void Update () {

	}

	void OnMouseEnter()
	{
		mouseOver = true;

		Renderer renderer = GetComponent<Renderer> ();
		Material material = renderer.material;

		Color hoverColor = new Color (brightness, brightness, brightness, 1F);

		//float emission = Mathf.PingPong (Time.time, 1.0F);
		//Color finalColor = baseColor * Mathf.LinearToGammaSpace (emission);

		material.EnableKeyword ("_EMISSION");
		material.SetColor ("_EmissionColor", hoverColor);
	}
	
	void OnMouseExit()
	{
		mouseOver = false;

		Renderer renderer = GetComponent<Renderer> ();
		Material material = renderer.material;
		
		Color baseColor = new Color (0F, 0F, 0F, 1F);

		material.EnableKeyword ("_EMISSION");
		material.SetColor ("_EmissionColor", baseColor);
	}

	void OnMouseDown()
	{
		if(mouseOver)
		{
			PlayerManager pm = new PlayerManager();
			Board board = PlayerManager.player.Board;

			List<Card> cardList = new List<Card>();
			cardList = CollectionLoader.LoadCollection();

			if(PlayerManager.selectionId >= 0)
			{
				string parentName = transform.parent.name;

				//int tileId = int.Parse(parentName.Substring(parentName.LastIndexOf("Tile_") + 1));
				int tileId = int.Parse(parentName.Substring(5));
				board.summonUnit(tileId, cardList[PlayerManager.selectionId]);
				PlayerManager.selectionId = -1;
			}
		}
	}
}
