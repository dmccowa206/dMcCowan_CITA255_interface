using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Vector3 GetMouseWorldPos()
    {
        Vector3 result = Input.mousePosition;
        result.z = Camera.main.WorldToScreenPoint(transform.position).z;//translate result.z to something the world can understand
        result = Camera.main.ScreenToWorldPoint(result);//convert the entire thing to a world pos

        return result;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("click");
            Vector3 mousePos = GetMouseWorldPos();
            //check if mousePos overlaps any collider2D
            Collider2D collider = Physics2D.OverlapPoint(mousePos);
            //Debug.Log(mousePos);
            if (collider != null)//check if there is a collider where clicked
            {

                //Debug.Log("collider");
                if (collider.TryGetComponent(out IInteract interact))
                {//using try get component to avoid having an object that doesn't implement IInteract
                    //Debug.Log("tryget");
                    interact.Interact();
                }
            }
        }
    }
}
