using UnityEngine;
using System.Collections;

public class CardHover : MonoBehaviour {

	private bool mouseOver;
	private Vector3 scale;
	private Vector3 position;

	private float growSpeed = 0.1F;
	private float moveSpeed = 0.1F;

	private float maxScale = 0.3F;
	private float maxY = 1F;
	private float maxZ = -5F;

	private float initScale;
	private float initY;
	private float initZ;

	void Start()
	{
		scale = transform.localScale;
		position = transform.localPosition;

		//initScale = scale.magnitude;
		initScale = 0.3F;
		initY = position.y;
		initZ = position.z;
	}

	void Update()
	{
		if(mouseOver)
		{
			if(scale.x < maxScale)
			{
				scale += new Vector3(growSpeed, growSpeed, 0);
			}
			if(position.y < maxY)
			{
				position += new Vector3(0, moveSpeed, 0);
			}
			position.z = maxZ;
		}
		else
		{
			if(scale.x > initScale)
			{
				scale -= new Vector3(growSpeed, growSpeed, 0);
			}
			if(position.y > initY)
			{
				position -= new Vector3(0, moveSpeed, 0);
			}
			position.z = initZ;
		}
		transform.localScale = scale;
		transform.localPosition = position;
	}

	void OnMouseDown()
	{
		if(mouseOver)
		{
			PlayerManager.selectionId = int.Parse(gameObject.name);
		}
	}

	void OnMouseEnter()
	{
		mouseOver = true;
	}

	void OnMouseExit()
	{
		mouseOver = false;
	}
}
