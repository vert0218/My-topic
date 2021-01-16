//using SharpDX.Direct3D9;
using System.Collections;
using System.Collections.Generic;
//using System.Windows.Media.Media3D;
using UnityEngine;
using Material = UnityEngine.Material;

public class GreenLight : MonoBehaviour
{
    private float lastTime;//计时器

    private float curTime;
    float gtime = 4;//绿灯亮4秒，从第零秒开始
    float darktime = 4;//从第四秒变黑
    float alltime = 10;//黄灯2秒，一轮总共10秒
    
   // void start（）{

    //Material material = new Material(Shader.Find("Transparent/Diffuse"));
    //material.color = Color.black;
      //  GetComponent<Renderer>().material = material;//开始时将灯设置为黑色
        //InvokeRepeating("GreenTurn", 0f, alltime);//0秒后调用GreenTurn() 函数，之后每10秒调用一次
    //InvokeRepeating("TurnBlack", darktime, alltime);//绿灯灭
}
    //void update（）{}
//void GreenTurn()
//{
   // Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
   // material1.color = Color.green;
   // GetComponent<Renderer>().material = material1;
//}

