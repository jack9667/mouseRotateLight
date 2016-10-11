using UnityEngine;
using System.Collections;

public class MainCameraControl : MonoBehaviour {
    //方向灵敏度  
    public float sensitivityX = 5F;   
    public float sensitivityY = 5F;   
      
    //上下最大视角(Y视角)  
    public float minimumY = -60F;  
    public float maximumY = 60F;

    float rotationY = 0F;
    public float rotateX = 0f;
    public float rotateY = 0f;

    void Start()
    {
        rotateX = transform.localEulerAngles.y;
        rotateY = (-transform.localEulerAngles.x);
        //transform.localEulerAngles = new Vector3(0, 0, 0);
        // Make the rigid body not change rotation  
        //if (GetComponent<Rigidbody>())  
        // GetComponent<Rigidbody>().freezeRotation = true;  
    }  
      
    void Update ()  {
        if (Input.GetMouseButton(1))
        {
            
            rotateX += Input.GetAxis("Mouse X") * sensitivityX;
            
            rotateY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotateY = Mathf.Clamp(rotateY, minimumY, maximumY);
            transform.localEulerAngles = new Vector3(-rotateY, rotateX, 0);
            /*
            //根据鼠标移动的快慢(增量), 获得相机左右旋转的角度(处理X)  
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

            //根据鼠标移动的快慢(增量), 获得相机上下旋转的角度(处理Y)  
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            //角度限制. rotationY小于min,返回min. 大于max,返回max. 否则返回value   
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            //总体设置一下相机角度  
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
            */
        } 
    }
        
      







	/*// Use this for initialization
    int count = 0;
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(1))
        {
            //Debug.Log("鼠标右键被摁啦！！！");
            float h = Input.GetAxis("Mouse X");
            float v = Input.GetAxis("Mouse Y");
            //float k = Input.GetAxis("Mouse z");
            transform.Rotate(0,h,0);
        }
      
	
	}*/
}
