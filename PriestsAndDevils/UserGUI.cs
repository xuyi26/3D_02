using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using mygame;
public class UserGUI : MonoBehaviour {
    private IUserAction ac
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
public interface UserAction
{
    void moveBoat();
    void restart();
}
public class ClickGUI : MonoBehaviour
{
    UserAction action;
    MyCharacterController characterController;
    public void setController(MyCharacterController characterCtrl)
    {
        chara
    }
}
