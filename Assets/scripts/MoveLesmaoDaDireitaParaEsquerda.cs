using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLesmaoDaDireitaParaEsquerda : MonoBehaviour
{

    public GameObject inimigoPrefab;
    public GameObject BossPrefab;
    //public GameObject barrilPrefab;
    public float intialDelay;
    public float enemyPeriod;
    public float enemyHeight;
    public static int ecount = 0;

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("CreateEnemy",intialDelay,enemyPeriod); 
    }

    void CreateEnemy()
   {
      if (ecount <= 3)
      {
        float a = Random.Range(-enemyHeight,enemyHeight);
        var enemyTransform = Instantiate(inimigoPrefab,this.gameObject.transform).transform;
        enemyTransform.position += a * Vector3.up;
      }

      if (ecount > 3 && ecount <=4)
      {  
      var enemyTransform = Instantiate(BossPrefab,this.gameObject.transform).transform;    
      ecount++;
      }

      /*if (ecount >=4)
      {  
      float a = Random.Range(-enemyHeight,enemyHeight);
      var enemyTransform = Instantiate(barrilPrefab,this.gameObject.transform).transform;
      enemyTransform.position += a * Vector3.up;          
      }*/     
   }

}
