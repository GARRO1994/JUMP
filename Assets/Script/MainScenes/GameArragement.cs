using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameArragement : MonoBehaviour
{
    public GameObject[] cubeses;
    public GameObject mainCube, spawn_blocks, rest;
    public Animation cubes_anim ,block;
    public Text playTXT, gameName , record;
    
    
        //mag, recor, sett, letti,
        
    private bool clicked;

    void OnMouseDown()
    {
        if (!clicked) {
            StartCoroutine(delCubes());
        clicked = true;
        playTXT.gameObject.SetActive(false);
        gameName.text = "0";
            /*mag.GetComponent<ScrolObj>().speed = -5f;
            mag.GetComponent<ScrolObj>().checkPos = -125f;
            recor.GetComponent<ScrolObj>().speed = -5f;
            recor.GetComponent<ScrolObj>().checkPos = -125f;
            sett.GetComponent<ScrolObj>().speed = -5f;
            sett.GetComponent<ScrolObj>().checkPos = -125f;
            letti.GetComponent<ScrolObj>().speed = -5f;
            letti.GetComponent<ScrolObj>().checkPos = -125f;*/
            //cubes.GetComponent<Animation>().Play("CubesPos");
            //but.GetComponent<ScrolObj>().speed = -5f;
            // but.GetComponent<ScrolObj>().checkPos = -125f;
            //restart.GetComponent<ScrolObj>().speed = -5f;
            //restar.GetComponent<ScrolObj>().checkPos = -125f;
            record.gameObject.SetActive(true);
            mainCube.GetComponent<Animation>().Play("Next");
            StartCoroutine(toblock());
            mainCube.transform.localScale = new Vector3(1f, 1f, 1f);
            cubes_anim.Play();
            
        }
    }
    IEnumerator delCubes()
    {
        for(int i = 0; i<3; i++)
        {
            yield return new WaitForSeconds(0.5f);
            cubeses[i].GetComponent<FallCubes>().enabled = true;
        }

        spawn_blocks.GetComponent<SpawnBlocks>().enabled = true;
        mainCube.AddComponent<Rigidbody>();
    }
    IEnumerator toblock()
    {
        yield return new WaitForSeconds(mainCube.GetComponent<Animation>().GetClip("Next").length);
        block.Play();
        //
    }
    
    //System.Threading.Thread.Sleep(2000);
}
