using UnityEngine;
using System.Collections;

public enum panelsetcolor
{
	Red,
	Blue,
	Green,
	White,
};

public class CubeMove : MonoBehaviour
{
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
	public panelsetcolor winnercolor;

	private bool Colorgudge()
	{

		panelsetcolor checkcolor;

		checkcolor = panelObject[0].GetComponent<ChangeColor>().mycolor;
		Debug.Log("call" + checkcolor);
		for (int i = 0; i < 6; i++)
		{
			if (checkcolor != panelObject[i].GetComponent<ChangeColor>().mycolor)
			{
				return false;
			}
		}

		if (checkcolor == winnercolor)
		{
			return true;
		}

		return false;

	}

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
	Vector3 rotatePoint = Vector3.zero;  //��]�̒��S
	Vector3 rotateAxis = Vector3.zero;   //��]��
	float cubeAngle = 0f;                //��]�p�x

	public GameObject[] panelObject;
<<<<<<< Updated upstream
	float cubeSizeHalf;                  //�L���[�u�̑傫���̔���
	bool isRotate = false;               //��]���ɗ��t���O�B��]���͓��͂��󂯕t���Ȃ�
	bool latestisRotate = false;

=======

	float cubeSizeHalf;                  //�L���[�u�̑傫���̔���
	bool isRotate = false;               //��]���ɗ��t���O�B��]���͓��͂��󂯕t���Ȃ�
	bool latestisRotate = false;
>>>>>>> Stashed changes

	void Start()
	{


		cubeSizeHalf = transform.localScale.x / 2f;

<<<<<<< Updated upstream
	void Update()
	{
		//��]���͓��͂��󂯕t���Ȃ�
		if (isRotate)
		{
=======
	}
	void Update()
	{
		//��]���͓��͂��󂯕t���Ȃ�
		if (isRotate) { 
		
>>>>>>> Stashed changes
			latestisRotate = true;

			return;
		}
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			rotatePoint = transform.position + new Vector3(cubeSizeHalf, -cubeSizeHalf, 0f);
			rotateAxis = new Vector3(0, 0, -1);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			rotatePoint = transform.position + new Vector3(-cubeSizeHalf, -cubeSizeHalf, 0f);
			rotateAxis = new Vector3(0, 0, 1);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			rotatePoint = transform.position + new Vector3(0f, -cubeSizeHalf, cubeSizeHalf);
			rotateAxis = new Vector3(1, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			rotatePoint = transform.position + new Vector3(0f, -cubeSizeHalf, -cubeSizeHalf);
			rotateAxis = new Vector3(-1, 0, 0);
		}
		// ���͂��Ȃ����̓R���[�`�����Ăяo���Ȃ��悤�ɂ���
		if (rotatePoint == Vector3.zero){
			return;
		}

		StartCoroutine(MoveCube());

		if (latestisRotate)
		{
			if (Colorgudge())
			{
				Debug.Log("win");
			}
			latestisRotate = false;
		}

	}



	IEnumerator MoveCube()
	{
		//��]���̃t���O�𗧂Ă�
		isRotate = true;
		//��]����
		float sumAngle = 0f; //angle�̍��v��ۑ�
		while (sumAngle < 90f)
		{
			cubeAngle = 0.5f; //������ς���Ɖ�]���x���ς��
			sumAngle += cubeAngle;
			// 90�x�ȏ��]���Ȃ��悤�ɒl�𐧌�
			if (sumAngle > 90f)
			{
				cubeAngle -= sumAngle - 90f;
			}
			transform.RotateAround(rotatePoint, rotateAxis, cubeAngle);
			yield return null;
		}
		//��]���̃t���O��|��
		isRotate = false;
		rotatePoint = Vector3.zero;
		rotateAxis = Vector3.zero;

		yield break;
	}
}