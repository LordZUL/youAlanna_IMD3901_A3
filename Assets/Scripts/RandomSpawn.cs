using UnityEngine;

// to randomly generate coins on the map, used video https://www.youtube.com/watch?v=IbiwNnOv5So to help
public class RandomSpawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject CoinPrefab;
    //public float Radius = 1; // for spawn circle

    void Start()
    {
        // in video its spawning when pressed space, I want to spawn at beginning... so will call at start
        for (int i = 0; i < 10; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 1, Random.Range(-10,11));
            //Instantiate(CoinPrefab, randomSpawnPosition, Quaternion.identity);
            Instantiate(CoinPrefab, randomSpawnPosition, CoinPrefab.transform.rotation);
        }
    }
    
}
