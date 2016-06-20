using System;
using System.Windows.Forms;

namespace MorseCodeRain
{
    [Serializable]
    class Hotkey
    {
        private readonly Action action;

        public Keys Key { get; set; }

        /// <summary>
        /// Gets a case sensitive name identifier for this instance.
        /// </summary>
        public string Id { get; }

        public Hotkey(string id, Keys shortcutKey, Action action)
        {
            Id = id;
            Key = shortcutKey;
            this.action = action;
        }

        /// <summary>
        /// Invokes the action associated with this instance
        /// </summary>
        public void PerformAction()
        {
            action.Invoke();
        }

        #region Equality
        protected bool Equals(Hotkey other)
        {
            return string.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Hotkey)obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }

        public static bool operator ==(Hotkey left, Hotkey right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Hotkey left, Hotkey right)
        {
            return !Equals(left, right);
        }
        #endregion
    }
}
