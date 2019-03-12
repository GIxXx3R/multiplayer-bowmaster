﻿using System.Collections;
using System.Collections.Generic;
using Zenject;
using UnityEngine;
using InputSystem;

namespace PlayerSystem
{
    public class PlayerService : IPlayerService
    {
        readonly SignalBus signalBus;
        private PlayerController playerController;
        private ScriptableObjPlayer scriptableObjPlayer;

        public PlayerService(SignalBus signalBus, ScriptableObjPlayer scriptableObjPlayer)
        {
            this.signalBus = signalBus;
            this.scriptableObjPlayer = scriptableObjPlayer;
        }

        void SpawnPlayer()
        {
            playerController = new PlayerController(2, this); 
        }

        public void SetPlayerData(InputData inputData)
        {

        }

        public ScriptableObjPlayer ReturnPlayerScriptableObj()
        {
            return scriptableObjPlayer;
        }

        public int GetLocalPlayerID()
        {
            return playerController.ReturnPlayerID();
        }
    }
}