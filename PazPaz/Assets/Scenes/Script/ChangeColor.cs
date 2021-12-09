using UnityEngine;
public class ChangeColor : MonoBehaviour
{
    // Unityエディタ上で変えたい色を指定できる。
    public Color color = Color.red;
    public GameObject plane;
    int count = 0;
    bool changeflag = false;
    public panelsetcolor mycolor = panelsetcolor.White;

    //オブジェクトが衝突したとき
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Blue")
        {
            var change = other.gameObject.GetComponent<Renderer>().material;

            plane.gameObject.GetComponent<Renderer>().material = change;

            mycolor = panelsetcolor.Blue;
        }

        if (other.gameObject.name == "Red")
        {
            var change = other.gameObject.GetComponent<Renderer>().material;

            plane.gameObject.GetComponent<Renderer>().material = change;

            mycolor = panelsetcolor.Red;
        }

        //Debug.Log(count);
    }
}