using UnityEngine;

// Code based on https://www.youtube.com/watch?v=6iSJ_jh6Rdo&list=LL&t=105s

// Step 1: Basically player collide, coin destroys, counter + 1;
// Step 2: Change Terrain + make player able to jump 
// Step 3: random assortment of coin order scattered on map
// Step 4: Implement multi-player by 8 - 9 pm
// step 5: Write up 9 - 10 pm
// step 6: Light mechanism?? Basically each player emits light, more player = wider range of vision?? 11-11:30
// Step 7: Sumbit at 11:58
// 

public class CoinCollection : MonoBehaviour
{
    private int coin = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag( "Coin"))
        {
            coin++;
            Debug.Log(coin);
            Destroy(other.gameObject);
        }
    }
}
