using UnityEngine;
using System.Collections;

public class myfpc : MonoBehaviour
{


    float chargingLaunch = 0, timer = 0;
    int counter = 0;
    Vector3 fixedPos = new Vector3(0, 1, 0);

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked; // blocca il mouse a rimanere al centro della visuale , fa cagare , usare control-p per uscire di scena 
    }

    // Update is called once per frame
    void Update()
    {


        timer += Time.deltaTime;

        if (timer / 10 >= counter)
        {
            weedleSpawning();
            counter++;
        }

        MouseLook();
        
        
        PokeBallLaunch();
    }

    void FixedUpdate()
    {
        MovementImproved();
    }

    private void Movement()
    {

        if (Input.GetKey(KeyCode.S))
            this.transform.localPosition -= this.transform.forward * Time.deltaTime * 2;
        if (Input.GetKey(KeyCode.W))
            this.transform.localPosition += this.transform.forward * Time.deltaTime * 2;
        if (Input.GetKey(KeyCode.D))
            this.transform.localPosition += this.transform.right * Time.deltaTime * 2;
        if (Input.GetKey(KeyCode.A))
            this.transform.localPosition -= this.transform.right * Time.deltaTime * 2;
    }

    private void MovementImproved()
    {

        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody>().AddForceAtPosition(this.transform.forward * -1,this.transform.position - new Vector3(0, 0.6f, 0), ForceMode.VelocityChange);
            this.GetComponent<Rigidbody>().maxAngularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody>().AddForceAtPosition(this.transform.forward, this.transform.position - new Vector3(0, 0.6f, 0), ForceMode.VelocityChange);
            this.GetComponent<Rigidbody>().maxAngularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Rigidbody>().AddForceAtPosition(this.transform.right, this.transform.position - new Vector3(0, 0.6f, 0), ForceMode.VelocityChange);
            this.GetComponent<Rigidbody>().maxAngularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Rigidbody>().AddForceAtPosition(this.transform.right * -1, this.transform.position - new Vector3(0, 0.6f, 0), ForceMode.VelocityChange);
            this.GetComponent<Rigidbody>().maxAngularVelocity = 0;
        }
    }

    private void MouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X");

        float mouseY = Input.GetAxis("Mouse Y");


        transform.Rotate(Vector3.up, 180 * Time.deltaTime * mouseX, Space.World);
        transform.Rotate(-transform.right, 180 * Time.deltaTime * mouseY, Space.World);
    }

    private void PokeBallLaunch()
    {
        if (Input.GetMouseButton(0))
        {
            chargingLaunch += Time.deltaTime;
        }

        if (Input.GetMouseButtonUp(0) && chargingLaunch > 0.2f)
        {
            PokeballSpawning();
            chargingLaunch = 0;
        }
    }

    private void PokeballSpawning()
    {
        GameObject pokeBall = Resources.Load<GameObject>("Pokeball_Obj");

        pokeBall = Instantiate(pokeBall);

        pokeBall.transform.localPosition = this.transform.localPosition + this.transform.forward * 2;

        pokeBall.GetComponent<Rigidbody>().AddForce(this.transform.forward * chargingLaunch * 20, ForceMode.Impulse);
    }

    private void weedleSpawning()
    {
        GameObject weedle = Resources.Load<GameObject>("weedle");


        for (int i = 0; i < 4; i++)
        {

            GameObject weedletemp = Instantiate(weedle);
            if (i == 0)
                weedletemp.transform.position = new Vector3(20, 0, 20);
            else if (i == 1)
                weedletemp.transform.position = new Vector3(20, 0, -20);
            else if (i == 2)
                weedletemp.transform.position = new Vector3(-20, 0, 20);
            else if (i == 3)
                weedletemp.transform.position = new Vector3(-20, 0, -20);
            weedletemp.transform.LookAt(GameObject.Find("Main Camera").transform);

        }
    }






}
