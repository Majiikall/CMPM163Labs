using System.Collections;
using UnityEngine;

public class buildCity : MonoBehaviour
{
	public GameObject[] buildings;
	public int mapWidth = 50;
	public int mapHeight = 50;

	int buildingFootprint = 3;
	int [] offsetValues = new int[15];

	int count;
	int previousOffset;

    // Start is called before the first frame update
    void Start()
    {
    	float seed = 68;
    	print(seed);

    	int counter = 0;
    	for(int z = 14; z >= 0; z--)
    	{
    		offsetValues[ z ] = counter+1;
    		counter++;
    	}

        for(int x = 5; x < mapHeight-5; x++)
        {
        	int offset = 0;
        	if(x > 22)
        	{
        		offset = x - 20;

        		offset = offsetValues[offset-1];
        	}
        	else if(x < 17)
        	{
        		offset = 20 - x;

        		offset = offsetValues[offset-1];
        	}
        	else
        	{
        		offset = offsetValues[1];
        	}

        	for(int y = 5; y < mapWidth-5; y++)
        	{	
        		int result;
        		Vector3 pos;
        			
    			result = (int)(Mathf.PerlinNoise(y/8.0f + seed,x/8.0f + seed) * 10);
        		pos = new Vector3(y * buildingFootprint, (offset-0.5f), x * buildingFootprint);

        		if(result < 1)
        			Instantiate(buildings[0], pos, Quaternion.identity);
        		else if(result < 2)
        			Instantiate(buildings[1], pos, Quaternion.identity);
        		else if(result < 3)
        			Instantiate(buildings[2], pos, Quaternion.identity);
        		else if(result < 4)
        			Instantiate(buildings[3], pos, Quaternion.identity);
        		else if(result < 5)
        			Instantiate(buildings[4], pos, Quaternion.identity);
    			else if(result < 10)
    				Instantiate(buildings[5], pos, Quaternion.identity);
        	}
        }
    }

}