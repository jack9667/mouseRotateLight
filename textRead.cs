using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;

public class textRead : MonoBehaviour {



	// Use this for initialization
	void Start () {
        var gobject = GameObject.Find("New Text");
        //Debug.Log(gobject.GetComponentInChildren<Transform>().lossyScale);
        //Debug.Log(gobject.transform.position);
        //gobject.GetComponentInChildren<TextMesh>().text = "fucktheworld";
        ArrayList info = LoadFile(Application.dataPath, "gg.txt");
        foreach(string str in info)
        {
            gobject.GetComponentInChildren<TextMesh>().text += '\n';
            Debug.Log(str);
            gobject.GetComponentInChildren<TextMesh>().text += str;
        }
	
	}

    ArrayList LoadFile(string path, string name)
    {
        StreamReader sr = null;
        try
        {
            sr = File.OpenText(path + "/" + name);
        }catch(Exception e)
        {
            Debug.Log(Application.dataPath);
            Debug.Log("没有发现文件");
            return null;
        }
        string line;
        ArrayList arrlist = new ArrayList();
        while((line=sr.ReadLine())!=null)
        {
            arrlist.Add(line);
        }
        sr.Close();
        sr.Dispose();
        return arrlist;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
