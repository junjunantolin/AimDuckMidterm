using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class Logic : MonoBehaviour
 {
     public bool isAllEnemiesDied;

     // Update is called once per frame
     void Update()
     {
         GameObject[] enemies= GameObject.FindGameObjectsWithTag("duck");
 
         if (enemies.Length == 0&&isAllEnemiesDied==true) 
         {
             Debug.Log("You killed all enemies wp=)");
             SceneManager.LoadScene("Winner");
             Cursor.visible = true;
         }
  
         for(int i = 0; i < enemies.Length; i++) 
         {
             if (enemies[i] != null&&isAllEnemiesDied==false) 
             {
                 isAllEnemiesDied = false;
                 
             }
         }
 
     }
 }