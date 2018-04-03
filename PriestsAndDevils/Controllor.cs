using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myGame;

public class Controllor : MonoBehaviour ,IScenceController,IUserAction{
    
}

public class Director : System.Object
{
    private static Director _instance;
    public ISceneController currentSceneController { get; set; }
    public static Director getInstance()
    {
        if (_instance == null)
        {
            _instance = new Director();
        }
        return _instance;
    }
}
public interface ISceneController
{
    void loadResources();
}
public class MyCharacterController {

}
public class ShoreController{
}
public class BoatController{
    
}
