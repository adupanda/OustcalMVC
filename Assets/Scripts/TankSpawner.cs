using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }

    public List<Tank> tankList;


    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateTank(TankTypes tankType)
    {

        switch (tankType)
        {
            case TankTypes.GreenTank:
                TankModel greenTankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
                TankController greenTankController = new TankController(greenTankModel, tankView);
                break;
            case TankTypes.BlueTank:
                TankModel blueTankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
                TankController blueTankController = new TankController(blueTankModel, tankView);
                break;
            case TankTypes.RedTank:
                TankModel redTankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
                TankController redTankController = new TankController(redTankModel, tankView);
                break;


        }

        
    }
    
}
