using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public int SceneId;
    public bool requresKey;
    public int keyid;
    public GameObject text = null;
    public void Start()
    {
        if(text!=null)
        {
            text.SetActive(false);
        }
    }
    
   private void OnMouseDown()
    {
        if(requresKey==false)
        {
            gameObject.GetComponent<MoveToScene>().Move(SceneId);
        }
        else if(requresKey==true)
        {
            bool hasNoKey = true;
            InvManager InvManager= GameObject.FindAnyObjectByType<InvManager>();
            List<Item> itemsInInv = InvManager.Items;
            foreach(Item it in itemsInInv)
            {
                if(it.id==keyid)
                {
                    gameObject.GetComponent<MoveToScene>().Move(SceneId);
                    hasNoKey = false;
                }
            }
            if(hasNoKey==true)
                {
                    text.SetActive(true);
                    Invoke("disableMessage",3f);
                }
                
        }
    }
    public void disableMessage()
    {
         text.SetActive(false);
    }
}