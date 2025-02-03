using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekpointManager : MonoBehaviour
{

    
    [SerializeField] GameObject[] __chekpointsWalkEasy;
    [SerializeField] GameObject[] __chekpointsWalkMedium;
    [SerializeField] GameObject[] __chekpointsWalkHard;
    [SerializeField] GameObject[] __chekpointsBikeEasy;
    [SerializeField] GameObject[] __chekpointsBikeMedium;
    [SerializeField] GameObject[] __chekpointsBikeHard;
    [SerializeField] GameObject[] __chekpointsScooterEasy;
    [SerializeField] GameObject[] __chekpointsScooterMedium;
    [SerializeField] GameObject[] __chekpointsScooterHard;

    int chekpoint;
    static public int Level = 0;


    
    public void EasyLevel()
    {
        int index = PlayerPrefs.GetInt("SelectPlayer");

        Level = 1;
        if (index == 0)
        {

            int chekpointWalk = Random.Range(0, 5);
            __chekpointsWalkEasy[chekpointWalk].SetActive(true);
            
        }
        if (index == 1)
        {
            int chekpointBike = Random.Range(0, 13);
            __chekpointsBikeEasy[chekpointBike].SetActive(true);
        }
        if (index == 2)
        {
            int chekpointScooter = Random.Range(0, 17);
            __chekpointsScooterEasy[chekpointScooter].SetActive(true);
        }
        GameObject.Find("TaskComleteReward").GetComponent<TaskCompleteReward>().Add80();
    }
    public void MediumLevel()
    {
        int index = PlayerPrefs.GetInt("SelectPlayer");

        Level = 2;
        if (index == 0)
        {

            int chekpointWalk = Random.Range(0, 10);
            __chekpointsWalkMedium[chekpointWalk].SetActive(true);

        }
        if (index == 1)
        {
            int chekpointBike = Random.Range(0, 18);
            __chekpointsBikeMedium[chekpointBike].SetActive(true);
        }
        if (index == 2)
        {
            int chekpointScooter = Random.Range(0, 21);
            __chekpointsScooterMedium[chekpointScooter].SetActive(true);
        }
        GameObject.Find("TaskComleteReward").GetComponent<TaskCompleteReward>().Add100();
    }
    public void HardLevel()
    {
        int index = PlayerPrefs.GetInt("SelectPlayer");

        Level = 3;
        if (index == 0)
        {

            int chekpointWalk = Random.Range(0, 9);
            __chekpointsWalkHard[chekpointWalk].SetActive(true);

        }
        if (index == 1)
        {
            int chekpointBike = Random.Range(0, 16);
            __chekpointsBikeHard[chekpointBike].SetActive(true);
        }
        if (index == 2)
        {
            int chekpointScooter = Random.Range(0, 25);
            __chekpointsScooterHard[chekpointScooter].SetActive(true);
        }
        GameObject.Find("TaskComleteReward").GetComponent<TaskCompleteReward>().Add120();
    }


}

    
    



