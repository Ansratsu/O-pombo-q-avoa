using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncaixas : MonoBehaviour
{
    public GameObject barrilPrefab;
    public float intialDelay;
    public float enemyPeriod;
    public float enemyHeight;
    
    void Start()
    {
        InvokeRepeating("CreateEnemy",intialDelay,enemyPeriod); 
       
    }

    void Update()
    {
        
    }

    void CreateEnemy()
   {
      {  
      float a = Random.Range(-enemyHeight,enemyHeight);
      var enemyTransform = Instantiate(barrilPrefab,this.gameObject.transform).transform;
      enemyTransform.position += a * Vector3.up;          
      } 

   }

}
