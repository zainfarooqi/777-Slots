﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace BE {
	
	public class SceneLobby : MonoBehaviour {

		public	GameObject 		prefabSceneItem; // selectstage item prefab
		public 	RectTransform	rtScrollContent; // scrollview that contain stageselect items
		public	Text			textGold;		// user gold info

		void Awake () {
			
		}
		
		void Start () {
			Time.timeScale = 1;
			print("PlayerPrefs.GetInt = " + PlayerPrefs.GetInt("mk_slot_coins"));
			print("PlayerPrefs.GetInt = " + PlayerPrefs.GetInt("mk_slot_coins"));
				BESetting.Gold.ChangeDelta(PlayerPrefs.GetInt("mk_slot_coins"));

			// set range of numbers and type
			BESetting.Gold.AddUIText(textGold);
		}

		public void lllll()
		{

		}

		// Update is called once per frame
		void Update () {
		
			// if user press 'escape' key, show quit message window
			if (Input.GetKeyDown(KeyCode.Escape)) { 
				UISGMessage.Show("Quit", "Do you want to quit this program ?", MsgType.OkCancel, MessageQuitResult);
			}
			
		}

		// when user pressed 'ok' button on quit message.
		public void MessageQuitResult(int value) {
			//Debug.Log ("MessageQuitResult value:"+value.ToString ());
			if(value == 0) {
				Application.Quit ();
			}
		}
		
		public void OnButtonUser() {
			BEAudioManager.SoundPlay(0);
		}
		
		public void OnButtonShop() {
			BEAudioManager.SoundPlay(0);
			BESetting.Gold.ChangeDelta(100);
			BESetting.Save();
			//UISGShop.Show();
		}
		
		public void OnButtonOption() {
			BEAudioManager.SoundPlay(0);
			UISGOption.Show();
		}
		
		public void OnButtonPlay() {
			BEAudioManager.SoundPlay(0);
		}
		
		public void OnButtonGet() {
			BEAudioManager.SoundPlay(0);
		}

		public void OnButtonSelected(int value) {
			
			BEAudioManager.SoundPlay(0);
			if(value==3)
				Application.LoadLevel("scene");

			else
				Application.LoadLevel("SlotGame");
		}
	}
}