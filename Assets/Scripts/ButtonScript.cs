using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public int SceneId;
    
   private void OnMouseDown()
    {
        gameObject.GetComponent<MoveToScene>().Move(SceneId);
    }
}