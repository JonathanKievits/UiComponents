using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

    public void SceneToChangeTo(int sceneChange)
    {
        Application.LoadLevel(sceneChange);
    }
}
