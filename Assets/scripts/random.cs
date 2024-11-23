using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class random : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Random.Range(1,21);
      Debug.Log(Random.Range(1,21)); 

      int counter =1;
      while(counter<20)
      {
       int randomNumber = Random.Range(1,21);
       
       Debug.Log(Random.Range(1,21));
       counter++;

       if (randomNumber==5)
       break;

      if (randomNumber==15)continue;

      }
    }

}
