using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.localScale = new Vector3 (34f, 34f, 34f); 
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3 (32f, 32f, 32f);
    }
}
