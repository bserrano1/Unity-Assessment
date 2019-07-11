using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Value_Handler : MonoBehaviour
{
    public InputField value;
    public Text txt;

    public void incrementValue(){
        int x = int.Parse(value.text);
        if(x >= 9){
            x = 0;
        } 
        else{
            x++;
        }
        Debug.Log(x);
        txt.text = x.ToString();
    }

    public void decrementValue(){
        int x = int.Parse(value.text);
        if(x <= 0){
            x = 9;
        } 
        else{
            x--;
        }
        Debug.Log(x);
        txt.text = x.ToString();    
    }    

}
