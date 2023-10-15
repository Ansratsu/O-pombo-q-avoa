using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contadordemorte : MonoBehaviour
{
    private int count = 0;
    public bool nome = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Enemy.enemydeath == true)
        {
        count ++;
        Enemy.enemydeath = false;
        print (count);
        MoveLesmaoDaDireitaParaEsquerda.ecount = count;
        }

    }
    
}
