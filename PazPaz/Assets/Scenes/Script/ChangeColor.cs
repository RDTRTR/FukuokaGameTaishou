using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Unity�G�f�B�^��ŕς������F���w��ł���B
    public Color color = Color.red;
    public GameObject plane;
    //�I�u�W�F�N�g���Փ˂����Ƃ�
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            var change = other.gameObject.GetComponent<Renderer>().material;

            plane.gameObject.GetComponent<Renderer>().material = change;
        }
    }
}