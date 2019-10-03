using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour {

Image img;

    void Start (){
            img = this.transform.GetComponent<Image>() ;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            img.color = Color.HSVToRGB (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f)); 
            //hsvt hue saturation value
            Debug.Log("hello");
            }

            
    }
}

//Color.HSVToRGB (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));