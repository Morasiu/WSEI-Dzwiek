using UnityEngine;
using UnityEngine.Audio;

public class MenuController : MonoBehaviour {
	public GameObject Menu;

	public AudioMixerSnapshot MenuOn;
	public AudioMixerSnapshot MenuOff;

	// Start is called before the first frame update
    void Start()
    {
        MenuOn.TransitionTo(0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) {
	        if (Menu.activeSelf)
		        DeactivateMenu();
            else
				ActivateMenu();
        }
    }

    private void ActivateMenu() {
	    Menu.SetActive(true);
        MenuOff.TransitionTo(0.01f);
        Time.timeScale = 0f;
    }

    private void DeactivateMenu() {
	    Menu.SetActive(false);
	    MenuOn.TransitionTo(0.01f);
        Time.timeScale = 1f;
    }
}
