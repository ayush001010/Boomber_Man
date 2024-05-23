using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEditor;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private float MinX = -2.4951f;
    private float MaxX = 2.4951f;

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer(){

        //Input 
        float h = Input.GetAxis("Horizontal");
        //Selecting transforming prop.
        Vector2 currentPos = transform.position;

        if(h>0){
            //getting toward right
            currentPos.x += speed * Time.deltaTime;
        }   
        else if(h<0){
            //getting toward right
            currentPos.x -= speed * Time.deltaTime;
        }  

        if (currentPos.x < MinX){
            currentPos.x = MinX;
        } 
        if (currentPos.x > MaxX){
            currentPos.x = MaxX;
        }

        transform.position = currentPos;

        } 

        void OnTriggerEnter2D(Collider2D Target){

        if(Target.tag == "Bomb"){
                
                Time.timeScale = 0;
            }
            
        }
    }
        
       
    


