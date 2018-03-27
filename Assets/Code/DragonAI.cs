using UnityEngine;

public class DragonAI : MonoBehaviour {
    GameObject player;
    DragonAnimator dragonAnimator;

	void Start () {
	    player = GameObject.FindGameObjectWithTag("Player");
	    dragonAnimator = GetComponent<DragonAnimator>();
	}
	
	void Update () {
	    if (Vector3.Distance(transform.position, player.transform.position) < 10f) {
	        dragonAnimator.PlayAttackAnimation();
            EndGameUi.ShowTextAndQuit("YOU DIED");
        }
	}


    void RestartLevel() {
        Application.LoadLevel(Application.loadedLevel);
    }
}
