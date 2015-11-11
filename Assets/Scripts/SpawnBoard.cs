using UnityEngine;
using System.Collections;

public class SpawnBoard : MonoBehaviour {

	public GameObject tilePrefab;

	void Start () {
		//change offsetX to change spacing between hex tiles
		float offsetX = 4.1F;
		float offsetY = offsetX + 0.6F;

		float xPos = -(offsetX * 2);
		float yPos = offsetY;

		int tileId = 0;

		for(int i = 0; i < 5; i++)
		{
			//if 2nd or 4th column
			if(UITools.IsOdd(i)) {
				yPos = offsetY / 2;
				for(int j = 0; j < 3; j++) {
					CreateTile(xPos, yPos, tileId);
					tileId += 1;
					yPos -= offsetY;
				}
			//1st, 3rd or 5th Column
			} else {
				yPos = offsetY;
				//3 rows for the 1st, 3rd, 5th Column
				for(int j = 0; j < 3; j++) {
					
					CreateTile(xPos, yPos, tileId);
					tileId += 1;
					yPos -= offsetY;
				}
			}
			xPos += offsetX;
			yPos = offsetY;
		}
	}

	void CreateTile(float xPos, float yPos, int tileId)
	{
		GameObject tileClone = Instantiate (tilePrefab, new Vector3 (0F, 0F, 0F), Quaternion.Euler (0, 0, 0)) as GameObject;

		tileClone.name = "Tile_" + tileId;
		tileClone.transform.parent = transform;
		tileClone.transform.localPosition = new Vector3 (xPos, yPos, 0F);
		tileClone.transform.localScale = new Vector3 (1F, 1F, 0F);
	}
}