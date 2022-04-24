using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldbuild : MonoBehaviour
{
    public Transform flr;
    public Transform wall;
    public Transform sofa_g;
    public Transform img1;

    public Transform beda;
    public Transform tv;
 
    /*array for on-click text advancement, might need to go into its own class
    public string[] scriptArray = new string [54];
    public int arrayPos = 0;*/


    // below is the randomised spawns
    private int spawnchance;
    // ende randomised spawns


    void Start()
    {

        /* adding each line of text manually 
            scriptArray[0] = " Sage: Instruction on killing a ghost";
			scriptArray[1] = " ";
			scriptArray[2] = "The ghost is the one who plays with the wires in our head";
			scriptArray[3] = " tweaking the feedback loops of dopamine";
			scriptArray[4] = "self regulated reward and punishment, to remain comfortable";
			scriptArray[5] = "consumable, compliant and complicit";
	 		scriptArray[6] = " a citizen and subject of carceral logics";
			scriptArray[7] = " It haunts our reflexes and reactions";
			scriptArray[8] = " and governs our relationships through commodifiable exchanges of productivity and profitability";
			scriptArray[9] = "or as Césaire put it";
			scriptArray[10] = " complete and utter “thingification”.";
			scriptArray[11] = " ";
			scriptArray[12]= "Haunted home:";
			scriptArray[13] = " ";
			scriptArray[14] = "a life of contentment and normality";
			scriptArray[15] " The need for a conceptual, solid, home to be fulfilled";
			scriptArray[16] = "or the hollow inside is haunted husks of impressions";
			scriptArray[17] = "In the fear of dark water I sit in a warm pool of small size in the dim light ";
			scriptArray[18] = "It is soothing to sit here";
	 		scriptArray[19] = "I am uncertain of my surroundings I am less worried than before I suppose";
			scriptArray[20] = "but from time to time the drains on the side of the walls grabs my arms with such a sudden pull ";
		 	scriptArray[21] = " of suction into the density of a circular darkness in the narrow space of floaty things";
			scriptArray[22] = " shattered memories fell-off hair and unlimited tuby void ";
			scriptArray[23] = "The spook of shames";
			scriptArray[24] = " ";
			scriptArray[25] = " Sage: Instruction on killing a ghost";
			scriptArray[26] = " ";
			scriptArray[27] = "This ghost is a tricky one, a slippery spectre that spills out into everything";
			scriptArray[28] = "Check the shadows";
			scriptArray[29] = "see if he still lurks there";
			scriptArray[30] = "Not one speck can remain";
			scriptArray[31] = "Haunted home";
			scriptArray[32] = " ";
			scriptArray[33] = "anxiousness plays the background tune";
		 	scriptArray[34] = "everything great becomes temporary stretched thin";
			scriptArray[35] = "slowly but certainly exhausted body";
			scriptArray[36] = "there is nowhere to return to or hide from";
	 	 	scriptArray[37] = "the drain comes within this body that feels cold and";
			scriptArray[38] = "recalls the night mom and I got lost finding the bus home";
	        scriptArray[39] = "on a strange street of neon light restaurants she asked me to remember";
			scriptArray[40] = " this feeling of never arriving home";
			scriptArray[41] = " ";
			scriptArray[42] = "lol more yum words needed here ";
			scriptArray[43] = " Sage: Instruction on killing a ghost";
			scriptArray[44] = " ";
			scriptArray[45] = "So even when things seemed to get a little better";
			scriptArray[46] = " it was actually getting more efficient";
			scriptArray[47] = "we need to kill the capitalist in our heads";
			scriptArray[48] = " the ghost that haunts us";
			scriptArray[49] = "Fill yourself with an unending optimism";
			scriptArray[50] = "Equal parts love and rage";
			scriptArray[51] = "And Endless hope in the face of the impossible";
			scriptArray[52] = "Throw a brick through a window, use the debris to unbuild the walls that imprison";
			scriptArray[53] = "Hijack and hack into an old satellite falling out of orbit";
			scriptArray[54] = " ";
        */

        for (float xPos = -72; xPos < 72; xPos += 4)
        {

            for (float zPos = 0; zPos < 84; zPos += 4)
            {
                Instantiate(flr, new Vector3(xPos, 0, zPos), flr.rotation);

                // below is the randomised spawned sofas
                spawnchance = Random.Range(1, 81);
                if (spawnchance > 79 && spawnchance < 81)
                {
                    Instantiate(sofa_g, new Vector3(xPos, 4, zPos), Quaternion.Euler(0, Random.Range(0, 2) * 90, 0));
                }
                // end is the randomised spawned sofas

                // below is the randomised spawned img1
                spawnchance = Random.Range(1, 91);
                if (spawnchance > 89 && spawnchance < 91)
                {
                    Instantiate(img1, new Vector3(xPos, Random.Range(4, 10), zPos), Quaternion.Euler(0, Random.Range(0, 2) * 90, 0));
                }
                // end is the randomised spawned img1

                // below is the randomised spawned beda
                spawnchance = Random.Range(1, 191);
                if (spawnchance > 189 && spawnchance < 191)
                {
                    Instantiate(beda, new Vector3(xPos, Random.Range(4, 10), zPos), Quaternion.Euler(0, Random.Range(0, 2) * 90, -5));
                }
                // end is the randomised spawned beda

                // below is the randomised spawned tv
                spawnchance = Random.Range(1, 221);
                if (spawnchance > 219 && spawnchance < 221)
                {
                    Instantiate(tv, new Vector3(xPos, Random.Range(4, 10), zPos), Quaternion.Euler(0, Random.Range(0, 2) * 90, -8));
                }
                // end is the randomised spawned tv
            }
        }

        for (float xPos = -68; xPos < 76; xPos += 12)
        {

            for (float zPos = 4; zPos < 80; zPos += 12)
            {
        
                // below is the randomised spawned walls
                spawnchance = Random.Range(1, 21);
                if (spawnchance > 8 && spawnchance < 20)
                {
                    Instantiate(wall, new Vector3(xPos, 4, zPos), Quaternion.Euler(0, Random.Range(0, 2) * 90, 0));
                }
                // ende randomised spawned walls


            }
        }

        for (float xPos = -68; xPos < 76; xPos += 12)
        {
            Instantiate(wall, new Vector3(xPos, 4, -8), wall.rotation);
            Instantiate(wall, new Vector3(xPos, 4, 76), wall.rotation);
        }

        for (float zPos = 4; zPos < 80; zPos += 12)
        {
            Instantiate(wall, new Vector3(-80, 4, zPos), Quaternion.Euler(0,90,0));
            Instantiate(wall, new Vector3(64, 4, zPos), Quaternion.Euler(0, 90, 0));
        }

    }



    void Update()
    {
        
    }
}
