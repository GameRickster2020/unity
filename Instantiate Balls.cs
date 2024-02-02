using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int time = 5 ;
    public int repeatRate = 1;
    void Start()
    {
        // InvokeRepeating parameters: method name, initial delay, repeat rate
        InvokeRepeating("SpawnObject", time, repeatRate);
    }

    void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}