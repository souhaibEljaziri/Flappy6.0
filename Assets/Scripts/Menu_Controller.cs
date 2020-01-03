using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Controller : MonoBehaviour {


	[Tooltip("_sceneToLoadOnPlay is the name of the scene that will be loaded when users click play")]
	public string _sceneToLoadOnStandalone = "Standalone";
	public string _sceneToLoadOnMenuStage1 = "MenuStage1";
	public string _sceneToLoadOnMenuStage2 = "MenuStage2";
	public string _sceneToLoadOnMenuStage3 = "MenuStage3";
	public string _sceneToLoadOnMenuStage4 = "MenuStage4";
	public string _sceneToLoadOnPlay = "Level";
	public string _sceneToLoadOnPlay2 = "MenuStage1";
	public string _sceneToLoadOnPlay3 = "Level3";
	public string _sceneToLoadOnPlay4 = "Level4";
	public string _sceneToLoadOnPlay5 = "Level5";
	public string _sceneToLoadOnPlay6 = "Level6";
	public string _sceneToLoadOnPlay7 = "Level7";
	public string _sceneToLoadOnPlay8 = "Level8";
	public string _sceneToLoadOnPlay9 = "Level9";
	public string _sceneToLoadOnPlay10 = "Level10";
	public string _sceneToLoadOnPlay11 = "Level11";
	public string _sceneToLoadOnPlay12= "Level112";
	public string _sceneToLoadOnPlay13 = "Level13";
	public string _sceneToLoadOnPlay14 = "Level14";
	public string _sceneToLoadOnPlay15 = "Level15";
	public string _sceneToLoadOnPlay16 = "Level16";
	public string _sceneToLoadOnPlay17 = "Level17";
	public string _sceneToLoadOnPlay18 = "Level18";
	public string _sceneToLoadOnPlay19 = "Level19";
	public string _sceneToLoadOnPlay20 = "Level20";
	public string _sceneToLoadOnPlay21 = "Level21";
	public string _sceneToLoadOnPlay22 = "Level22";
	public string _sceneToLoadOnPlay23 = "Level23";
	public string _sceneToLoadOnPlay24 = "Level24";
	public string _sceneToLoadOnPlay25 = "Level25";
	public string _sceneToLoadOnPlay26 = "Level26";
	public string _sceneToLoadOnPlay27 = "Level27";
	public string _sceneToLoadOnPlay28 = "Level28";
	public string _sceneToLoadOnPlay29 = "Level29";
	public string _sceneToLoadOnPlay30 = "Level30";
	public string _sceneToLoadOnPlay31 = "Level31";
	public string _sceneToLoadOnPlay32 = "Level32";
	public string _sceneToLoadOnPlay33 = "Level33";
	public string _sceneToLoadOnPlay34 = "Level34";
	public string _sceneToLoadOnPlay35 = "Level35";
	public string _sceneToLoadOnPlay36 = "Level36";
	public string _sceneToLoadOnPlay37 = "Level37";
	public string _sceneToLoadOnPlay38 = "Level38";
	public string _sceneToLoadOnPlay39 = "Level39";
	public string _sceneToLoadOnPlay40 = "Level40";
	public string _sceneToLoadOnPlay41 = "Level41";
	public string _sceneToLoadOnPlay42 = "Level42";
	public string _sceneToLoadOnPlay43 = "Level43";
	public string _sceneToLoadOnPlay44 = "Level44";
	public string _sceneToLoadOnPlay45 = "Level45";
	public string _sceneToLoadOnPlay46 = "Level46";
	public string _sceneToLoadOnPlay47 = "Level47";
	public string _sceneToLoadOnPlay48 = "Level48";
	public string _sceneToLoadOnPlay49 = "Level49";
	public string _sceneToLoadOnPlay50 = "Level50";
	public string _sceneToLoadOnPlay51 = "Level51";
	[Tooltip("_webpageURL defines the URL that will be opened when users click on your branding icon")]
	public string _webpageURL = "http://www.alpaca.studio";
	[Tooltip("_soundButtons define the SoundOn[0] and SoundOff[1] Button objects.")]
	public Button[] _soundButtons;
	[Tooltip("_audioClip defines the audio to be played on button click.")]
	public AudioClip _audioClip;
	[Tooltip("_audioSource defines the Audio Source component in this scene.")]
	public AudioSource _audioSource;
	
	//The private variable 'scene' defined below is used for example/development purposes.
	//It is used in correlation with the Escape_Menu script to return to last scene on key press.
	UnityEngine.SceneManagement.Scene scene;

	void Awake () {
		if(!PlayerPrefs.HasKey("_Mute")){
			PlayerPrefs.SetInt("_Mute", 0);
		}
		
		scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
		PlayerPrefs.SetString("_LastScene", scene.name.ToString()); 
		//Debug.Log(scene.name);
	}
	public void PlayMenuStandalone() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnStandalone);
	}
	public void PlayMenuStage2 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnMenuStage2);
	}
	public void PlayMenuStage3 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnMenuStage3);
	}
	public void PlayMenuStage4 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnMenuStage4);
	}

	public void PlayGame () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay);
	}
	public void PlayMenuStage1 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnMenuStage1);
	}
	public void PlayGame3 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay3);
	}
	public void PlayGame4 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay4);
	}
	public void PlayGame5 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay5);
	}
	public void PlayGame6 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay6);
	}
	public void PlayGame7 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene (_sceneToLoadOnPlay7);
	}
	public void PlayGame8 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay8);
	}
	public void PlayGame9 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay9);
	}
	public void PlayGame10 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay10);
	}
	public void PlayGame11 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay11);
	}
	public void PlayGame12 () {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay12);
	}
	public void PlayGame13() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay13);
	}
	public void PlayGame14() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay14);
	}
	public void PlayGame15() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay15);
	}
	public void PlayGame16() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay16);
	}
	public void PlayGame17() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay17);
	}
	public void PlayGame18() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay18);
	}
	public void PlayGame19() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay19);
	}
	public void PlayGame20() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay20);
	}
	public void PlayGame21() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay21);
	}
	public void PlayGame22() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay22);
	}
	public void PlayGame23() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay23);
	}
	public void PlayGame24() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay24);
	}
	public void PlayGame25() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay25);
	}
	public void PlayGame26() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay26);
	}
	public void PlayGame27() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay27);
	}
	public void PlayGame28() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay28);
	}
	public void PlayGame29() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay29);
	}
	public void PlayGame30() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay30);
	}
	public void PlayGame31() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay31);
	}
	public void PlayGame32() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay32);
	}
	public void PlayGame33() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay33);
	}
	public void PlayGame34() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay34);
	}
	public void PlayGame35() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay35);
	}
	public void PlayGame36() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay36);
	}
	public void PlayGame37() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay37);
	}
	public void PlayGame38() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay38);
	}
	public void PlayGame39() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay39);
	}
	public void PlayGame40() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay40);
	}
	public void PlayGame41() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay41);
	}
	public void PlayGame42() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay42);
	}
	public void PlayGame43() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay43);
	}
	public void PlayGame44() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay44);
	}
	public void PlayGame45() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay45);
	}
	public void PlayGame46() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay46);
	}
	public void PlayGame47() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay47);
	}
	public void PlayGame48() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay48);
	}
	public void PlayGame49() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay49);
	}
	public void PlayGame50() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay50);
	}
	public void PlayGame51() {
		_audioSource.PlayOneShot(_audioClip);
		PlayerPrefs.SetString("_LastScene", scene.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay51);
	}
	public void Mute () {
		_audioSource.PlayOneShot(_audioClip);
		_soundButtons[0].interactable = true;
		_soundButtons[1].interactable = false;
		PlayerPrefs.SetInt("_Mute", 1);
	}
	
	public void Unmute () {
		_audioSource.PlayOneShot(_audioClip);
		_soundButtons[0].interactable = false;
		_soundButtons[1].interactable = true;
		PlayerPrefs.SetInt("_Mute", 0);
	}
	
	public void QuitGame () {
		_audioSource.PlayOneShot(_audioClip);
		#if !UNITY_EDITOR
			Application.Quit();
		#endif
		
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#endif
	}
}
