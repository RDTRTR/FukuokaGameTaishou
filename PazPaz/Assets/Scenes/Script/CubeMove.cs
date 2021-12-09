using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour
{
	Vector3 rotatePoint = Vector3.zero;  //��]�̒��S
	Vector3 rotateAxis = Vector3.zero;   //��]��
	float cubeAngle = 0f;                //��]�p�x

	float cubeSizeHalf;                  //�L���[�u�̑傫���̔���
	bool isRotate = false;               //��]���ɗ��t���O�B��]���͓��͂��󂯕t���Ȃ�



	void Start()
	{
		cubeSizeHalf = transform.localScale.x / 2f;
	}
	

		void Update()
	{
		//��]���͓��͂��󂯕t���Ȃ�
		if (isRotate)
			return;

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
		if (rotatePoint == Vector3.zero)
			return;
		StartCoroutine(MoveCube());
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


	bool ObjDic(Vector3 DirVec)
    {
		RaycastHit hit;

		Physics.Raycast(transform.position, DirVec, out hit);
		Debug.DrawRay(transform.position, DirVec);
			
		if(hit.distance <= 0.8)
        {
			return true;
        }

		return false;
	}
}