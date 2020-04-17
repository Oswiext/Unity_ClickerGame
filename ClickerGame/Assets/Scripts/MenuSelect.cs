using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour {

	public void SceneSelect () {
		switch (this.gameObject.name)
        {
            case "StartButton":
                SceneManager.LoadScene("Scene01");
                break;
        }
	}
}
