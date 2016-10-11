using UnityEngine;
using System.Collections;

public class MouseLight : MonoBehaviour {

    bool tri1 = false;      //变色
    bool tri2 = false;      //旋转  
    int countMouse = 0;
    Color orgColor;
	// Use this for initialization
	void Start () {
        orgColor = gameObject.GetComponent<Renderer>().material.color;
        GameObject.Find("Spotlight").GetComponent<Light>().intensity = 0.0f;
        //orgColor = renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
        if (tri2 == true && (countMouse % 2 != 0))
        //transform.Rotate(Vector3.up * Time.deltaTime * 200);
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 200, Space.World);
            GameObject.Find("Spotlight").GetComponent<Light>().intensity += 0.02f;
        }
        else
            transform.Rotate(Vector3.up * Time.deltaTime, Space.World);

	}

    void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        tri1 = true;
    }
    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = orgColor;
        tri1 = false;
    }
    void OnMouseDown()
    {
        if (tri1 == true)
            tri2 = true;
        countMouse++;

    }

    void OnGUI()
    {
        if (tri2)
            GUI.Label(new Rect(10, 20, 100, 50), "你看见这行小字了吗？");
    }
    
}
