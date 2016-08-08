using UnityEngine;
using System.Collections;

public class cameraPivotC : MonoBehaviour
{

    float chargingLaunch = 0, timer = 0;
    int counter = 0;
    Vector3 fixedPos = new Vector3(0, 1, 0);
    Quaternion initialRot;
    Vector3 initialCamPos;

    public float t = 0.0f;
    bool resetPos = false;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked; // blocca il mouse a rimanere al centro della visuale , fa cagare , usare control-p per uscire di scena 
        initialRot = this.transform.rotation;
        initialCamPos = this.transform.FindChild("Main Camera").position;
    }

    // Update is called once per frame
    void Update()
    {



        MouseLook();
        MouseZoom();
        //ResetPosition();
        ResetPositionCo();

    

    }



    private void MouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X");

        float mouseY = Input.GetAxis("Mouse Y");


        transform.Rotate(Vector3.up, 180 * Time.deltaTime * mouseX, Space.World);
        transform.Rotate(-transform.right, 180 * Time.deltaTime * mouseY, Space.World);
    }

    private void MouseZoom()
    {

        float mouseWheel = Input.GetAxis("Mouse ScrollWheel");


        transform.FindChild("Main Camera").position += transform.FindChild("Main Camera").forward * Time.deltaTime * mouseWheel * 500;

     

    }

    private void ResetPosition()
    {
        

        if (Input.GetKeyDown(KeyCode.R))
        {

            resetPos = true;
            Invoke("ResetPosToFalse", 0.9f);
           
        }
        if (resetPos && this.transform.rotation != initialRot)
        {
            t += Time.deltaTime;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, initialRot, t) * initialRot;
        }
        
            
    }


    private void ResetPositionCo()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            StartCoroutine(Resetting());

        }
    }

    private void ResetPosToFalse()
    {
        resetPos = false;
        t = 0.0f;
    }

    IEnumerator Resetting()
    {
        Quaternion currentRot = transform.rotation;
        while (t < 1)
        {
            t += Time.deltaTime;
            this.transform.rotation = Quaternion.Slerp(currentRot, initialRot, t) * initialRot;
            yield return null;
        }

        t = 0;


    }

}
