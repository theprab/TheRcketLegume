using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opInstantiate : MonoBehaviour
{
    public GameObject[] allOpps;
    public GameObject[] allFriends;
    public GameObject friends;
    public GameObject opponents;
    public int numOpp = 1;
    void Start()
    {
        for (int i = 0; i < numOpp; i++) {
            Instantiate(opponents, new Vector3(Random.Range(12.0f, 16.3f), 0.96f, Random.Range(0.0f, 15.0f)), Quaternion.Euler(0.0f, -90.0f, 0.0f));
        }
        allOpps = GameObject.FindGameObjectsWithTag("opponent");

        for (int i = 0; i < numOpp-1; i++) {
            Instantiate(friends, new Vector3(Random.Range(-16.3f, -12.0f), 0.96f, Random.Range(-15.0f, 0.0f)), Quaternion.Euler(0.0f, 90.0f, 0.0f));
        }
        allFriends = GameObject.FindGameObjectsWithTag("earthFriend");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
