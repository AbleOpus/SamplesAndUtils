using System;

namespace IniEditing
{
    /// <summary>
    /// Represents a key/property of an .ini file.
    /// </summary>
    public class IniKey
    {
        /// <summary>
        /// Gets the name of the key.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the value of this key as a string.
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Gets the containing section of this key.
        /// </summary>
        public string Section { get; }

        /// <summary>
        /// Creates an instance of this key.
        /// </summary>
        /// <param name="name">The name or ID of the key.</param>
        /// <param name="value">The current value of the key.</param>
        /// <param name="section">The keys containing section.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public IniKey(string name, string value, string section)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            Name = name;
            Value = value;
            Section = section;
        }

        protected bool Equals(IniKey other)
        {
            return string.Equals(Name, other.Name) && string.Equals(Value, other.Value) && 
                string.Equals(Section, other.Section);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((IniKey) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Value != null ? Value.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Section != null ? Section.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(IniKey left, IniKey right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IniKey left, IniKey right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return $"[{Section}]\n{Name}={Value}";
        }
    }
}
