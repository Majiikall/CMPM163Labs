using System.Collections;
using UnityEngine;

public class buildCity : MonoBehaviour
{
	public GameObject[] buildings;
	public int mapWidth = 20;
	public int mapHeight = 20;


    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x < mapHeight; x++)
        {
        	for(int y = 0; y < mapWidth; y++)
        	{
        		Vector3 pos = new Vector3(y,0,x);
        		int n = Random.Range(0, buildings.Length);
        		Instantiate(buildings[n], pos, Quaternion.identity);
        	}
        }
    }

}
