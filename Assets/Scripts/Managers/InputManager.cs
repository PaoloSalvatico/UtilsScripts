using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : Singleton<InputManager>
    {
        private GameInput _inputClass;

        protected override void Awake()
        {
            base.Awake();
            _inputClass = new GameInput();
        }
    /*
        private void OnEnable()
        {
            _inputClass.Enable();

            #region PlayerCharacterMap
            _inputClass.PlayerCharacter.Dash.performed += PerformDash;
            _inputClass.PlayerCharacter.Jump.performed += PerformJump;
            #endregion

            #region PlayerInteractionsMap
            _inputClass.PlayerInteractions.Interact.started += StartPlayerInteraction;
            _inputClass.PlayerInteractions.Interact.canceled += StopPlayerInteraction;
            _inputClass.PlayerInteractions.DropItem.started += StartDropItem;
            _inputClass.PlayerInteractions.EquipItemFromInventory.started += StartEquipItem;
            _inputClass.PlayerInteractions.UseHealthItem.started += StartUseHealthItem;
            _inputClass.PlayerInteractions.UseHealthItem.canceled += StopUseHealthItem;
            _inputClass.PlayerInteractions.UseTacticItem.started += StartUseTacticItem;
            _inputClass.PlayerInteractions.UseTacticItem.canceled += StopUseTacticItem;
            _inputClass.PlayerInteractions.OpenHealthRadial.started += StartOpenHealthRadial;
            _inputClass.PlayerInteractions.OpenHealthRadial.canceled += StartCloseHealthRadial;
            _inputClass.PlayerInteractions.OpenTacticRadial.started += StartOpenTacticRadial;
            _inputClass.PlayerInteractions.OpenTacticRadial.canceled += StartCloseTacticRadial;
            _inputClass.PlayerInteractions.OpenInventory.started += StartOpenInventory;
            _inputClass.PlayerInteractions.WheelInteraction.started += StartWheelInteraction;
            _inputClass.PlayerInteractions.WheelInteraction.canceled += EndWheelInteraction;

            #endregion

            #region PlayerCombatMap
            _inputClass.PlayerCombat.LightAttack.started += StartLightAttack;
            _inputClass.PlayerCombat.HeavyAttack.started += StartHeavyAttack;
            _inputClass.PlayerCombat.UppercutAttack.started += StartUppercutAttack;
            _inputClass.PlayerCombat.EvadeChase.started += StartEvadeChase;
            _inputClass.PlayerCombat.Defense.started += StartDefense;
            _inputClass.PlayerCombat.Defense.canceled += StopDefense;
            //_inputClass.PlayerCombat.StopDefenseTemp.started += StopDefense;
            #endregion

            #region PlayerAbilitiesMap
            _inputClass.PlayerAbilities.FirstAbility.started += StartFirstAbility;
            _inputClass.PlayerAbilities.SecondAbility.started += StartSecondAbility;
            _inputClass.PlayerAbilities.ThirdAbility.started += StartThirdAbility;
            #endregion

            #region PlayerUI
            _inputClass.PlayerUI.ESC.started += OpenPause;

            #endregion
        }

        private void OnDisable()
        {
            _inputClass.Disable();

            #region PlayerCharacterMap
            _inputClass.PlayerCharacter.Dash.performed -= PerformDash;
            _inputClass.PlayerCharacter.Jump.performed -= PerformJump;
            #endregion

            #region PlayerInteractionsMap
            _inputClass.PlayerInteractions.Interact.started -= StartPlayerInteraction;
            _inputClass.PlayerInteractions.Interact.canceled -= StopPlayerInteraction;
            _inputClass.PlayerInteractions.DropItem.started -= StartDropItem;
            _inputClass.PlayerInteractions.UseHealthItem.started -= StartUseHealthItem;
            _inputClass.PlayerInteractions.UseHealthItem.canceled -= StopUseHealthItem;
            _inputClass.PlayerInteractions.UseTacticItem.started -= StartUseTacticItem;
            _inputClass.PlayerInteractions.UseTacticItem.canceled -= StopUseTacticItem;
            _inputClass.PlayerInteractions.OpenHealthRadial.started -= StartOpenHealthRadial;
            _inputClass.PlayerInteractions.OpenHealthRadial.canceled -= StartCloseHealthRadial;
            _inputClass.PlayerInteractions.OpenTacticRadial.started -= StartOpenTacticRadial;
            _inputClass.PlayerInteractions.OpenTacticRadial.canceled -= StartCloseTacticRadial;
            _inputClass.PlayerInteractions.OpenInventory.started -= StartOpenInventory;
            _inputClass.PlayerInteractions.WheelInteraction.started -= StartWheelInteraction;
            _inputClass.PlayerInteractions.WheelInteraction.canceled -= EndWheelInteraction;
            #endregion

            #region PlayerCombatMap
            _inputClass.PlayerCombat.LightAttack.started -= StartLightAttack;
            _inputClass.PlayerCombat.HeavyAttack.started -= StartHeavyAttack;
            _inputClass.PlayerCombat.UppercutAttack.started -= StartUppercutAttack;
            _inputClass.PlayerCombat.EvadeChase.started -= StartEvadeChase;
            _inputClass.PlayerCombat.Defense.started -= StartDefense;
            #endregion

            #region PlayerAbilitiesMap
            _inputClass.PlayerAbilities.FirstAbility.started -= StartFirstAbility;
            _inputClass.PlayerAbilities.SecondAbility.started -= StartSecondAbility;
            _inputClass.PlayerAbilities.ThirdAbility.started -= StartThirdAbility;
            #endregion

            #region PlayerUI
            _inputClass.PlayerUI.ESC.canceled += ClosePause;
            #endregion
        }
    
        #region MapEnabling
        public void EnablePlayerControllerMaps()
        {
            EnableMovementMaps();
            EnableInteractionMaps();
            EnableCombatMaps();
        }
        public void EnableMovementMaps()
        {
            _inputClass.PlayerCharacter.Enable();
        }
        public void EnableInteractionMaps()
        {
            _inputClass.PlayerInteractions.Enable();
        }
        public void EnableCombatMaps()
        {
            _inputClass.PlayerCombat.Enable();
            _inputClass.PlayerAbilities.Enable();
        }
        public void EnableUIMaps()
        {
            _inputClass.PlayerUI.Enable();
        }
        public void EnableCameraMaps()
        {
            _inputClass.Camera.Enable();
        }
        #endregion

        #region MapDisabling
        public void DisablePlayerControllerMaps()
        {
            DisableMovementMaps();
            DisableInteractionMaps();
            DisableCombatMaps();
        }
        public void DisableMovementMaps()
        {
            _inputClass.PlayerCharacter.Disable();
        }

        public void DisableInteractionMaps()
        {
            _inputClass.PlayerInteractions.Disable();
        }

        public void DisableCombatMaps()
        {
            _inputClass.PlayerCombat.Disable();
            _inputClass.PlayerAbilities.Disable();
        }
        public void DisableUIMaps()
        {
            _inputClass.PlayerUI.Disable();
        }

        public void DisableCameraMaps()
        {
            _inputClass.Camera.Disable();
        }
        #endregion

        public void EnableRotationInput()
        {
            _inputClass.PlayerCharacter.Look.Enable();
        }
        public void DisableRotationInput()
        {
            _inputClass.PlayerCharacter.Look.Disable();
        }
        public void EnableMovementInput()
        {
            _inputClass.PlayerCharacter.Move.Enable();
        }
        public void DisableMovementInput()
        {
            _inputClass.PlayerCharacter.Move.Disable();
        }
    */
        #region CursorManagement
        /// <summary>
        /// Lock cursor to the center of the game window
        /// </summary>
        public void EnableCursorLock()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        /// <summary>
        /// Confine cursor to the game window
        /// </summary>
        public void EnableCursorConfine()
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        /// <summary>
        /// Cursor behaviour unmodified
        /// </summary>
        public void DisableCursorLock()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        /// <summary>
        /// Set cursor visibility
        /// </summary>
        /// <param name="visible">visible</param>
        public void CursorVisibility(bool visible)
        {
            Cursor.visible = visible;
        }
        #endregion

        #region InputMaps
    /*
        #region PlanetCamera
        public bool IsCameraDragPressed => _inputClass.Camera.CameraDrag.IsPressed();
        public bool IsCameraSpawnClick => _inputClass.Camera.SpawnClick.IsPressed();
        public Vector2 CameraMousePosition => _inputClass.Camera.MousePosition.ReadValue<Vector2>();
        public Vector2 CameraMouseDelta => _inputClass.Camera.MouseDelta.ReadValue<Vector2>();

        #endregion
    */
        #region PlayerCharacterMap
        #region Dash
        public delegate void DashPerformed();
        public DashPerformed OnDashPerformed;

        private void PerformDash(InputAction.CallbackContext context)
        {
            if (OnDashPerformed == null) return;
            OnDashPerformed();
        }
        #endregion

        #region Jump
        public delegate void JumpPerformed();
        public JumpPerformed OnJumpPerformed;

        private void PerformJump(InputAction.CallbackContext context)
        {
            if (OnJumpPerformed == null) return;
            OnJumpPerformed();
        }
        #endregion
    /*
        #region Move
        public Vector2 MoveValue => _inputClass.PlayerCharacter.Move.ReadValue<Vector2>();

        #endregion

        #region Look
        public Vector2 LookValue => _inputClass.PlayerCharacter.Look.ReadValue<Vector2>();
        #endregion
    */
        #endregion

        #region PlayerInteractionsMap
        #region Interaction
        public delegate void InteractionStarted();
        public InteractionStarted OnInteractionStarted;

        private void StartPlayerInteraction(InputAction.CallbackContext context)
        {
            if (OnInteractionStarted == null) return;
            OnInteractionStarted();
        }

        public delegate void InteractionStop();
        public InteractionStop OnInteractionStop;

        private void StopPlayerInteraction(InputAction.CallbackContext context)
        {
            if (OnInteractionStop == null) return;
            OnInteractionStop();
        }
        #endregion

        #region DropItem

        public delegate void DropItemStarted();
        public DropItemStarted OnDropItemStarted;

        private void StartDropItem(InputAction.CallbackContext context)
        {
            if (OnDropItemStarted == null) return;
            OnDropItemStarted();
        }
        #endregion

        #region EqipItem
        public delegate void EquipItemStarted();
        public EquipItemStarted OnEquipItemStarted;

        private void StartEquipItem(InputAction.CallbackContext context)
        {
            if (OnEquipItemStarted == null) return;
            OnEquipItemStarted();
        }
        #endregion

        #region UseItem

        public delegate void UseHealthItemStarted();
        public UseHealthItemStarted OnUseHealthItemStarted;
        public delegate void UseHealthItemStop();
        public UseHealthItemStop OnUseHealthItemStop;
        public delegate void UseTacticItemStarted();
        public UseTacticItemStarted OnTacticItemStarted;
        public delegate void UseTacticItemStopped();
        public UseTacticItemStopped OnTacticItemStopped;

        private void StartUseHealthItem(InputAction.CallbackContext context)
        {
            if (OnUseHealthItemStarted == null) return;
            OnUseHealthItemStarted();
        }
        private void StopUseHealthItem(InputAction.CallbackContext context)
        {
            if (OnUseHealthItemStop == null) return;
            OnUseHealthItemStop();
        }

        private void StartUseTacticItem(InputAction.CallbackContext context)
        {
            if (OnTacticItemStarted == null) return;
            OnTacticItemStarted();
        }
        private void StopUseTacticItem(InputAction.CallbackContext context)
        {
            if (OnTacticItemStopped == null) return;
            OnTacticItemStopped();
        }
        #endregion

        #region OpenRadial

        public delegate void OpenHealthRadialStarted();
        public OpenHealthRadialStarted OnOpenRadialHealthStarted;
        public delegate void CloseHealthRadialStarted();
        public CloseHealthRadialStarted OnCloseRadialHealthStarted;

        public delegate void OpenTacticRadialStarted();
        public OpenTacticRadialStarted OnOpenRadialTacticStarted;
        public delegate void CloseTacticRadialStarted();
        public CloseTacticRadialStarted OnCloseRadialTacticStarted;

        private void StartOpenHealthRadial(InputAction.CallbackContext context)
        {
            if (OnOpenRadialHealthStarted == null) return;
            OnOpenRadialHealthStarted();
        }
        private void StartCloseHealthRadial(InputAction.CallbackContext context)
        {
            if (OnCloseRadialHealthStarted == null) return;
            OnCloseRadialHealthStarted();
        }
        private void StartOpenTacticRadial(InputAction.CallbackContext context)
        {
            if (OnOpenRadialTacticStarted == null) return;
            OnOpenRadialTacticStarted();
        }
        private void StartCloseTacticRadial(InputAction.CallbackContext context)
        {
            if (OnCloseRadialTacticStarted == null) return;
            OnCloseRadialTacticStarted();
        }
        #endregion

        #region PauseMenu

        public delegate void StartOpenPause();
        public StartOpenPause OnOpenPause;
        public StartOpenPause OnClosePause;

        private void OpenPause(InputAction.CallbackContext context)
        {
            if (OnOpenPause == null) return;
            OnOpenPause();
        }
        private void ClosePause(InputAction.CallbackContext context)
        {
            if (OnClosePause == null) return;
            OnClosePause();
        }


        #endregion

        #region OpenInventory

        public delegate void OpenInventoryStarted();
        public OpenInventoryStarted OnOpenInventory;

        private void StartOpenInventory(InputAction.CallbackContext context)
        {
            if (OnOpenInventory == null) return;
            OnOpenInventory();
        }
        #endregion

        #region WheelInteraction

        public delegate void WheelInteractionStart();
        public WheelInteractionStart OnWheelInteractionStart;
        public delegate void WheelInteractionEnd();
        public WheelInteractionEnd OnWheelInteractionEnd;

        private void StartWheelInteraction(InputAction.CallbackContext context)
        {
            if (OnWheelInteractionStart == null) return;
            OnWheelInteractionStart();
        }

        private void EndWheelInteraction(InputAction.CallbackContext context)
        {
            if (OnWheelInteractionEnd == null) return;
            OnWheelInteractionEnd();
        }
        #endregion

        #endregion

        #region PlayerCombatMap
        #region LightAttack
        public delegate void LightAttackStarted();
        public LightAttackStarted OnLightAttackStarted;

        private void StartLightAttack(InputAction.CallbackContext context)
        {
            if (OnLightAttackStarted == null) return;
            OnLightAttackStarted();
        }
        #endregion

        #region HeavyAttack
        public delegate void HeavyAttackStarted();
        public HeavyAttackStarted OnHeavyAttackStarted;

        private void StartHeavyAttack(InputAction.CallbackContext context)
        {
            if (OnHeavyAttackStarted == null) return;
            OnHeavyAttackStarted();
        }
        #endregion

        #region UppercutAttack
        public delegate void UppercutAttackStarted();
        public UppercutAttackStarted OnUppercutAttackStarted;

        private void StartUppercutAttack(InputAction.CallbackContext context)
        {
            if (OnUppercutAttackStarted == null) return;
            OnUppercutAttackStarted();
        }
        #endregion

        #region EvadeAttack
        public delegate void EvadeStarted();
        public EvadeStarted OnEvadeStarted;

        private void StartEvade(InputAction.CallbackContext context)
        {
            if (OnEvadeStarted == null) return;
            OnEvadeStarted();
        }
        #endregion

        #region EvadeChaseAttack
        public delegate void EvadeChaseStarted();
        public EvadeChaseStarted OnEvadeChaseStarted;

        private void StartEvadeChase(InputAction.CallbackContext context)
        {
            if (OnEvadeChaseStarted == null) return;
            OnEvadeChaseStarted();
        }
        #endregion#

        #region Defense
        public delegate void DefenseStarted();
        public DefenseStarted OnDefenseStarted;

        public delegate void DefenseStopped();
        public DefenseStopped OnDefenseStopped;

        private void StartDefense(InputAction.CallbackContext context)
        {
            if (OnDefenseStarted == null) return;
            OnDefenseStarted();
        }

        private void StopDefense(InputAction.CallbackContext context)
        {
            if (OnDefenseStopped == null) return;
            OnDefenseStopped();
        }
        #endregion

        #endregion

        #region PlayerAbilitiesMap
        #region FirstAbility
        public delegate void FirstAbilityStarted();
        public FirstAbilityStarted OnFirstAbilityStarted;

        private void StartFirstAbility(InputAction.CallbackContext context)
        {
            if (OnFirstAbilityStarted == null) return;
            OnFirstAbilityStarted();
        }
        #endregion

        #region SecondAbility
        public delegate void SecondAbilityStarted();
        public SecondAbilityStarted OnSecondAbilityStarted;

        private void StartSecondAbility(InputAction.CallbackContext context)
        {
            if (OnSecondAbilityStarted == null) return;
            OnSecondAbilityStarted();
        }
        #endregion

        #region ThirdAbility
        public delegate void ThirdAbilityStarted();
        public ThirdAbilityStarted OnThirdAbilityStarted;

        private void StartThirdAbility(InputAction.CallbackContext context)
        {
            if (OnThirdAbilityStarted == null) return;
            OnThirdAbilityStarted();
        }
        #endregion
        #endregion

        #endregion

    }
