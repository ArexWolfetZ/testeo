using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Movement : MonoBehaviour
{
    private OldInput oldInput;
    public CarSo car;
    [SerializeField] private WheelCollider[] _wheelCollider;
    [SerializeField] private Transform[] _wheelTransforms;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        oldInput = GetComponent<OldInput>();
        speed = car.speed;
    }

    // Update is called once per frame
    void Update()
    {
        WheelBrake();
        WheelsUptade();
    }
    void FixedUpdate()
    {
        Motorspeed();
        WheelAngle();
    }
    //velocidad
    public void Motorspeed()
    {
        foreach (var wheel in _wheelCollider)
        {
            wheel.motorTorque = oldInput.vertical * speed;
        }
    }
    //frenos
    public void WheelBrake()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var wheel in _wheelCollider)
            {
                wheel.brakeTorque = car.brake;
            }
        } else if (Input.GetKeyUp(KeyCode.Space))
        {
            foreach (var wheel in _wheelCollider)
            {
                wheel.brakeTorque = 0;
            }

        }
    }
        //Angulo
        public void WheelAngle()
        {
        _wheelCollider[2].steerAngle = oldInput.horizontal * car.angle;
        _wheelCollider[3].steerAngle = oldInput.horizontal * car.angle;
        }
        
        //actualizar las llantas
        public void WheelsUptade()
        {
            for(int i = 0; i<_wheelCollider.Length; i++)
            {
                UptadeWheel(_wheelCollider[i], _wheelTransforms[i]);
            }
        }
        
        //Constructor de metodo
        public void UptadeWheel(WheelCollider collider, Transform transform)
        {
            Vector3 pos;
            Quaternion rot;

        //obtener pos y rot de los colliders
            collider.GetWorldPose(out pos, out rot);

            transform.position = pos;
            transform.rotation = rot;
        }
    
    }