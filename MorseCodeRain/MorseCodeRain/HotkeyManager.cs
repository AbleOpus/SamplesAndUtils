using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MorseCodeRain
{
    [Serializable]
    class HotkeyManager
    {
        private readonly List<Hotkey> hotkeyList = new List<Hotkey>();

        /// <summary>
        /// Processes KeyEventArgs and fires the first hotkey action that matches it.
        /// </summary>
        /// <returns>Returns true if a hotkey has been pressed, otherwise false.</returns>
        public bool ProcessKeyArgs(KeyEventArgs args)
        {
            foreach (Hotkey key in hotkeyList)
            {
                if (key.Key == args.KeyData)
                {
                    key.PerformAction();
                    return true;
                }
            }

            return false;
        }

        public void AddHotkey(string id, Keys keys, Action action)
        {
            Hotkey hk = new Hotkey(id, keys, action);
            AddHotkey(hk);
        }

        /// <summary>
        /// Adds a hotkey to the hotkey list.
        /// </summary>
        /// <exception cref="ArgumentException">Is thrown when the hotkeys ID is not unique.</exception>
        public void AddHotkey(Hotkey hotkey)
        {
            foreach (Hotkey HK in hotkeyList)
            {
                if (HK == hotkey)
                {
                    throw new ArgumentException(
                        $@"The hotkey ""{ hotkey.Id}"" already exists.\r\n");
                }
            }

            // Add hotkeys with modifiers, at the top of the list so they are processed
            // before less elaborate HK (as only one HK can be fired at one time).
            if ((hotkey.Key & Keys.Modifiers) != Keys.None)
            {
                hotkeyList.Insert(0, hotkey);
            }
            else
            {
                hotkeyList.Add(hotkey);
            }
        }

        /// <summary>
        /// Removes a hotkey from the hotkey list.
        /// </summary>
        public void RemoveHotkey(Hotkey hotkey)
        {
            hotkeyList.Remove(hotkey);
        }

        /// <summary>
        /// Finds the hotkey with the identifier specified and applies the 
        /// new key sequence.
        /// </summary>
        /// <returns>Returns true, when an HK has been changed, otherwise false.</returns>
        public bool ChangeHotkey(string id, Keys keys, Keys mods)
        {
            foreach (Hotkey HK in hotkeyList)
            {
                if (HK.Id == id)
                {
                    HK.Key = keys;
                    return true;
                }
            }

            return false;
        }
    }
}
