using UnityEngine;
using System.Collections;

public class MousePointer : MonoBehaviour {


    Camera ciccio;

    RaycastHit hit;

	void Awake()
    {
        ciccio = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {


        Vector3 screenPos = Input.mousePosition;

        Vector3 screenPosView = screenPos.normalized;

        Ray raggioSuper = ciccio.ViewportPointToRay(screenPosView);

        if (Physics.Raycast(raggioSuper, out hit, 1000) && CheckMousePos())
        {
            Debug.DrawLine(raggioSuper.origin, hit.point, Color.yellow);
            Debug.Log("" + ciccio.name);
           
        }

	}


    bool CheckMousePos()
    {
        Vector3 mouseViewPort = Input.mousePosition.normalized;


        Debug.Log(mouseViewPort);

        if ((mouseViewPort.x > ciccio.rect.x && mouseViewPort.x < ciccio.rect.width)
            && (mouseViewPort.y > ciccio.rect.y && mouseViewPort.y < ciccio.rect.height))
            return true;
        else
            return false;
    }
}
