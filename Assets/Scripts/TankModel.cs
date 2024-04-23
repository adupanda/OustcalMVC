using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;
    public TankTypes tankType;
    public Material color;
    public TankModel(float _movement,float _rotation, TankTypes tankType, Material color)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
        this.tankType = tankType;
        this.color = color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
