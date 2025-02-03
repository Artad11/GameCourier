using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacter : MonoBehaviour
{
    [SerializeField] GameObject _PersonWalk;
    [SerializeField] GameObject _PersonBike;
    [SerializeField] GameObject _PersonScooter;
    static int Character;
    void Start()
    {
       
            _PersonWalk.SetActive(true);
          
        
        /*if (Character == 1)
        {
            _PersonBike.SetActive(true);
        }
        if (Character == 2)
        {
            _PersonScooter.SetActive(true);
        }*/
    }

    
}
