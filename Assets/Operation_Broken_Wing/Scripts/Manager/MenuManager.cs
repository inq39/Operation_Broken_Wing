using System;
using System.Collections.Generic;
using UnityEngine;
using Operation_Broken_Wing.UI;

namespace Operation_Broken_Wing.Manager
{
    public class MenuManager : MonoSingleton<MenuManager>
    {
        [SerializeField]
        private Menu mainMenu;
        [SerializeField]
        private Menu settingsMenu;
        [SerializeField]
        public Transform _menuParent;
        private Stack<Menu> _menuStack = new Stack<Menu>();
        

        protected override void Awake()
        {
            base.Awake();
            InitializeMenus();
        }
        
        private void InitializeMenus()
        {
            if (_menuParent == null)
                Debug.Log("Menu Folder not set.");

            Menu[] menuPrefabs = new[]{mainMenu, settingsMenu};
            foreach (Menu prefab in menuPrefabs)
            {
                if (prefab != null)
                {
                    Menu newMenu = Instantiate(prefab, _menuParent);
                    if (prefab != mainMenu)
                    {
                        newMenu.gameObject.SetActive(false);
                    }
                    else
                    {
                        OpenMenu(newMenu);
                    }
                }
            }
        }

        public void OpenMenu(Menu menuInstance)
        {
            if (menuInstance == null)
            {
                Debug.LogError("NO MenuInstance!");
                return;
            }

            if (_menuStack.Count > 0)
            {
                foreach (Menu menu in _menuStack)
                {
                    menu.gameObject.SetActive(false);
                }
            }
            menuInstance.gameObject.SetActive(true);
            _menuStack.Push(menuInstance);

        }

        public void CloseMenu()
        {
            if (_menuStack.Count == 0)
            {
                Debug.LogError("MenuManager: No Menu in stack!");
                return;
            }
            var topMenu = _menuStack.Pop();
            topMenu.gameObject.SetActive(false);

            if (_menuStack.Count > 0)
            {
                var nextMenu = _menuStack.Peek();
                nextMenu.gameObject.SetActive(true);
            }
        }
    }
}
