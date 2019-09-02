using System.Collections;
using UnityEngine;

public class SpawnStar : MonoBehaviour
{
    public GameObject star;

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(UnityEngine.Random.Range(0f, Screen.width), UnityEngine.Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
            Instantiate(star, pos, Quaternion.Euler (0, 0, Random.Range (0f, 360)));
            yield return new WaitForSeconds(5.01f);
        }
    }

}