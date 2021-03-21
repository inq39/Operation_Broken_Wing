using System;
using System.Collections.Generic;
using UnityEngine;
using Operation_Broken_Wing.UI;

namespace Operation_Broken_Wing.Manager
{
    public class MenuManager : MonoSingleton<MenuManager>
    {
        [SerializeField]
        private Menu[] _menuPrefabs;

        private Transform _menuParent;
        private Stack<Menu> _menuStack = new Stack<Menu>();
        private static bool _menusInitialized;
        

        protected override void Awake()
        {
            base.Awake();
            DontDestroyOnLoad(gameObject);
            if (_menusInitialized == false)
                InitializeMenus();
        }
        
        private void InitializeMenus()
        {
            if (_menuParent == null)
            {
                _menuParent = new GameObject("---UI---").transform;
            }
            DontDestroyOnLoad(_menuParent);
            
            foreach (Menu prefab in _menuPrefabs)
            {
                if (prefab != null)
                {
                    Menu newMenu = Instantiate(prefab, _menuParent);
                    if (!prefab.CompareTag("MainMenu"))
                    {
                        newMenu.gameObject.SetActive(false);
                    }
                    else
                    {
                        OpenMenu(newMenu);
                    }
                }
            }
            _menusInitialized = true;
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
