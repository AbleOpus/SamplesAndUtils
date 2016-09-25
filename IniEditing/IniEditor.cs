using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace IniEditing
{
    // The class does not currently support reading of identical key names.

    /// <summary>
    /// For modifying preexisting .ini (configuration/initialization) files.
    /// </summary>
    public class IniEditor
    {
        private List<string> content = new List<string>();
        private const string SECTION_PATTERN = @"^\[(?<Section>[^\]]+)\]";
        private const string PAIR_PATTERN = @"^\s*(?<Key>[^=;#\n]+)=(?<Value>.*)";
        private RegexOptions options = RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase;
        private StringComparison sc = StringComparison.InvariantCultureIgnoreCase;

        #region Properties
        /// <summary>
        /// The path of the .ini file loaded.
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// Gets or sets the character recognized as the comment start, by default this is a semicolon (;).
        /// </summary>
        public char CommentCharacter { get; set; } = ';';

        /// <summary>
        /// Gets the amount of comments. Only supports full-line comments and uses the comment character set.
        /// </summary>
        public int CommentCount
        {
            get
            {
                return content.Select(t => t.TrimStart(' ')).Count(line => line.Length > 0 && line[0].Equals(CommentCharacter));
            }
        }

        /// <summary>
        /// Gets the count of the key value pairs (does not include commented).
        /// </summary>
        public int KeyCount
        {
            get { return content.Count(t => Regex.IsMatch(t, PAIR_PATTERN, options)); }
        }

        /// <summary>
        /// Gets the section count (does not include commented).
        /// </summary>
        public int SectionCount
        {
            get { return content.Count(t => Regex.IsMatch(t, SECTION_PATTERN, options)); }
        }

        private bool caseSensitive;
        /// <summary>
        /// Gets or sets whether to use case sensitivity for finding values and keys.
        /// </summary>
        public bool CaseSensitive
        {
            get { return caseSensitive; }
            set
            {
                caseSensitive = value;

                if (caseSensitive)
                {
                    sc = StringComparison.InvariantCulture;
                    options = (RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture);
                }
                else
                {
                    sc = StringComparison.InvariantCultureIgnoreCase;
                    options = (RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
                }
            }
        }

        /// <summary>
        /// Gets whether content is loaded or not.
        /// </summary>
        public bool Loaded => content.Count > 0;
        #endregion

        /// <summary>
        /// Loads an .ini to be modified. This must be called before any other method is used
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="IOException"></exception>
        public void Load(string fileName)
        {
            FileName = fileName;
            content = new List<string>(File.ReadAllLines(fileName));
        }

        /// <summary>
        /// Checks to see if any content is loaded. if not, throw an exception.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        private void CheckLoaded()
        {
            if (!Loaded)
                throw new NoFileLoadedException("You must load an .ini file before using this method.");
        }

        /// <summary>
        /// Automatically sets the comment character according to what is present in the content.
        /// If no comments exist, then the semicolon is used.
        /// </summary>
        public void AutoSetCommentChar()
        {
            int colonCount = 0;
            int poundCount = 0;

            foreach (string line in content.Where(line => line.Length > 0))
            {
                if (line[0] == ';')
                    colonCount++;
                else if (line[0] == '#')
                    poundCount++;
            }

            CommentCharacter = (poundCount > colonCount) ? '#' : ';';
        }

        /// <summary>
        /// Gets all of the keys of the loaded file.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public IniKey[] GetKeys()
        {
            CheckLoaded();
            var pairs = new List<IniKey>();
            string currentSection = string.Empty;

            foreach (string line in content)
            {
                Match sectionMatch = Regex.Match(line, SECTION_PATTERN, options);

                if (sectionMatch.Success)
                {
                    currentSection = sectionMatch.Groups["Section"].Value;
                }
                else // Otherwise look for a key/property
                {
                    Match match = Regex.Match(line, PAIR_PATTERN, options);

                    if (match.Success)
                    {
                        string key = match.Groups["Key"].Value;
                        string value = match.Groups["Value"].Value;
                        pairs.Add(new IniKey(key, value, currentSection));
                    }
                }
            }

            return pairs.ToArray();
        }

        /// <summary>
        /// Finds and modifies a value under the given section with the specified key. If no section is specified
        /// then the method will operate at a global scope at the top of the document.
        /// </summary>
        /// <param name="sectionName">The name of the section (can include brackets or not).</param>
        /// <param name="keyName">The name of the key to modify.</param>
        /// <param name="newValue">The value to set the found or generated key to.</param>
        /// <param name="autoCreateSection">When set to true, if section is not found, the section will be 
        /// inserted at the bottom of the document along with the pair that was to be modified.</param>
        /// <param name="autoCreatePair">When set to true, if the section is found and the target pair is not,
        /// then the pair will be inserted at the top of the section.</param>
        /// <returns>Returns true, if pre-existing key was found.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public bool ModifyValue(string sectionName, string keyName, string newValue,
            bool autoCreateSection, bool autoCreatePair)
        {
            CheckLoaded();
            sectionName = sectionName.TrimStart('[');
            sectionName = sectionName.TrimEnd(']');
            bool sectionFound = false;
            bool pairFound = false;
            int sectionIndex = -1;

            if (sectionName.Trim().Length.Equals(0))
            {
                for (int i = 0; i < content.Count; i++)
                {
                    Match match = Regex.Match(content[i], PAIR_PATTERN, options);

                    if (match.Success && match.Groups["Key"].Value.Equals(keyName, sc))
                    {
                        int index = match.Groups["Value"].Index;
                        int length = match.Groups["Value"].Length;

                        content[i] = content[i].Remove(index, length);
                        content[i] = content[i].Insert(index, newValue);
                        return true;
                    }
                }

                content.Insert(0, keyName + "=" + newValue);
                return false;
            }

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], SECTION_PATTERN, options);

                if (match.Success && match.Groups["Section"].Value.Equals(sectionName, sc))
                {
                    sectionFound = true;
                    sectionIndex = i;

                    for (int i2 = i + 1; i2 < content.Count; i2++)
                    {
                        if (Regex.IsMatch(content[i2], SECTION_PATTERN, options))
                            break;

                        Match pairMatch = Regex.Match(content[i2], PAIR_PATTERN, options);

                        if (pairMatch.Success && pairMatch.Groups["Key"].Value.Equals(keyName, sc))
                        {
                            int index = pairMatch.Groups["Value"].Index;
                            int length = pairMatch.Groups["Value"].Length;

                            content[i2] = content[i2].Remove(index, length);
                            content[i2] = content[i2].Insert(index, newValue);
                            pairFound = true;
                        }
                    }

                    break;
                }
            }

            if (!sectionFound && autoCreateSection)
            {
                // Only add new line if needed
                if (content[content.Count - 1].Trim() != string.Empty)
                {
                    content.Add(string.Empty);
                }
                content.Add("[" + sectionName + "]");
                content.Add(keyName + "=" + newValue);
            }
            else if (sectionFound && !pairFound && autoCreatePair)
            {
                // Bounds check?
                content.Insert(sectionIndex + 1, keyName + "=" + newValue);
            }

            return pairFound;
        }

        /// <summary>
        /// Finds and modifies a value under the given section with the specified key and value. If no section is specified
        /// then the method will operate at a global scope at the top of the document.
        /// </summary>
        /// <param name="sectionName">The name of the section (can include brackets or not).</param>
        /// <param name="keyName">The name of the key to modify.</param>
        /// <param name="oldValue">The value that must be present for modification.</param>
        /// <param name="newValue">The value to set the found or generated key to.</param>
        /// <param name="autoCreateSection">When set to true, if section is not found, the section will be inserted 
        /// at the bottom of the document along with the pair that was to be modified.</param>
        /// <param name="autoCreatePair">When set to true, if the section is found and the target pair is not,
        /// then the pair will be inserted at the top of the section.</param>
        /// <returns>Returns true, if pre-existing key was found.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public bool ModifyValue(string sectionName, string keyName, string oldValue, string newValue,
            bool autoCreateSection, bool autoCreatePair)
        {
            CheckLoaded();
            sectionName = sectionName.TrimStart('[');
            sectionName = sectionName.TrimEnd(']');

            bool sectionFound = false;
            bool pairFound = false;
            int sectionIndex = -1;

            if (sectionName.Trim().Length.Equals(0))
            {
                for (int i = 0; i < content.Count; i++)
                {
                    Match match = Regex.Match(content[i], PAIR_PATTERN, options);

                    if (match.Success && match.Groups["Key"].Value.Equals(keyName, sc) &&
                        match.Groups["Value"].Value.Equals(oldValue, sc))
                    {
                        int index = match.Groups["Value"].Index;
                        int length = match.Groups["Value"].Length;

                        content[i] = content[i].Remove(index, length);
                        content[i] = content[i].Insert(index, newValue);
                        return true;
                    }
                }

                content.Insert(0, keyName + "=" + newValue);
                return false;
            }

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], SECTION_PATTERN, options);

                if (match.Success && match.Groups["Section"].Value.Equals(sectionName, sc))
                {
                    sectionFound = true;
                    sectionIndex = i;

                    for (int i2 = i + 1; i2 < content.Count; i2++)
                    {
                        if (Regex.IsMatch(content[i2], SECTION_PATTERN, options))
                        {
                            break;
                        }

                        Match pairMatch = Regex.Match(content[i2], PAIR_PATTERN, options);

                        if (pairMatch.Success && pairMatch.Groups["Key"].Value.Equals(keyName, sc) &&
                            pairMatch.Groups["Value"].Value.Equals(oldValue, sc))
                        {
                            int index = pairMatch.Groups["Value"].Index;
                            int length = pairMatch.Groups["Value"].Length;

                            content[i2] = content[i2].Remove(index, length);
                            content[i2] = content[i2].Insert(index, newValue);
                            pairFound = true;
                        }
                    }

                    break;
                }
            }

            if (!sectionFound && autoCreateSection)
            {
                // Only add new line if needed
                if (content[content.Count - 1].Trim() != string.Empty)
                {
                    content.Add(string.Empty);
                }

                content.Add("[" + sectionName + "]");
                content.Add(keyName + "=" + newValue);
            }
            else if (sectionFound && !pairFound && autoCreatePair)
            {
                content.Insert(sectionIndex + 1, keyName + "=" + newValue);
            }

            return pairFound;
        }


        /// <summary>
        /// Modifies the value of all occurrences of the key specified.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public void ModifyValueOfAll(string keyName, string newValue)
        {
            CheckLoaded();

            for (int i = 0; i < content.Count; i++)
            {
                Match pairMatch = Regex.Match(content[i], PAIR_PATTERN, options);

                if (pairMatch.Success && pairMatch.Groups["Key"].Value.Equals(keyName, sc))
                {
                    int index = pairMatch.Groups["Value"].Index;
                    int length = pairMatch.Groups["Value"].Length;
                    content[i] = content[i].Remove(index, length);
                    content[i] = content[i].Insert(index, newValue);
                }
            }
        }

        /// <summary>
        /// Modifies the value of all occurrences of the key specified and value.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public void ModifyValueOfAll(string keyName, string oldValue, string newValue)
        {
            CheckLoaded();

            for (int i = 0; i < content.Count; i++)
            {
                Match pairMatch = Regex.Match(content[i], PAIR_PATTERN, options);

                if (pairMatch.Success && pairMatch.Groups["Key"].Value.Equals(keyName, sc) &&
                    pairMatch.Groups["Value"].Value.Equals(oldValue, sc))
                {
                    int index = pairMatch.Groups["Value"].Index;
                    int length = pairMatch.Groups["Value"].Length;
                    content[i] = content[i].Remove(index, length);
                    content[i] = content[i].Insert(index, newValue);
                }
            }
        }

        /// <summary>
        /// Deletes an .ini key that matches the specified key name, regardless of where it is in the file.
        /// </summary>
        /// <returns>Returns false, if nothing has been deleted.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public bool RemoveAnyKey(string keyName)
        {
            CheckLoaded();
            bool hasDeleted = false;

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], PAIR_PATTERN, options);

                if (match.Success && match.Groups["Key"].Value.Equals(keyName, sc))
                {
                    content.RemoveAt(i);
                    i--;
                    hasDeleted = true;
                }
            }

            return hasDeleted;
        }

        /// <summary>
        /// Removes a key in the specified section with the specified value.
        /// </summary>
        /// <param name="sectionName">The name of the section the pairs has to reside in.</param>
        /// <param name="keyName">The name of the key.</param>
        /// <returns>Returns true, if a pair has been found and removed.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public bool RemoveKey(string sectionName, string keyName)
        {
            CheckLoaded();
            sectionName = sectionName.TrimStart('[');
            sectionName = sectionName.TrimEnd(']');

            for (int i = 0; i < content.Count; i++)
            {
                Match sectionMatch = Regex.Match(content[i], SECTION_PATTERN, options);

                if (sectionMatch.Success && sectionMatch.Groups["Section"].Value.Equals(sectionName, sc))
                {
                    if (i + 1 < content.Count)
                    {
                        i++;

                        for (int i2 = i; i2 < content.Count; i2++)
                        {
                            if (!Regex.IsMatch(content[i2], SECTION_PATTERN, options))
                            {
                                Match keyMatch = Regex.Match(content[i2], PAIR_PATTERN, options);

                                if (keyMatch.Success)
                                {
                                    string key = keyMatch.Groups["Key"].Value;

                                    if (keyName.Equals(key, sc))
                                    {
                                        content.RemoveAt(i2);
                                        return true;
                                    }
                                }
                            }
                            else
                            {
                                return false; // Encountered end of section before finding pair
                            }
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Removes a key in the specified section with the specified value and key name.
        /// </summary>
        /// <param name="sectionName">The name of the section the pairs has to reside in.</param>
        /// <param name="keyName">The name of the key.</param>
        /// <param name="value">The key must have this value to be removed.</param>
        /// <returns>Returns true, if a pair has been found and removed.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public bool RemoveKey(string sectionName, string keyName, string value)
        {
            CheckLoaded();
            sectionName = sectionName.TrimStart('[');
            sectionName = sectionName.TrimEnd(']');

            for (int i = 0; i < content.Count; i++)
            {
                Match sectionMatch = Regex.Match(content[i], SECTION_PATTERN, options);

                if (sectionMatch.Success && sectionMatch.Groups["Section"].Value.Equals(sectionName, sc))
                {
                    if (i + 1 < content.Count)
                    {
                        i++;

                        for (int i2 = i; i2 < content.Count; i2++)
                        {
                            if (!Regex.IsMatch(content[i2], SECTION_PATTERN, options))
                            {
                                Match keyMatch = Regex.Match(content[i2], PAIR_PATTERN, options);

                                if (keyMatch.Success && keyMatch.Groups["Key"].Value.Equals(keyName, sc) &&
                                    keyMatch.Groups["Value"].Value.Equals(value, sc))
                                {
                                    content.RemoveAt(i2);
                                    return true;
                                }
                            }
                            else
                            {
                                return false; // Encountered end of section before finding pair.
                            }
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Removes a key in the specified section with the specified value and key name.
        /// </summary>
        /// <returns>Returns true, if a pair has been found and removed.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public bool RemoveKey(IniKey key)
        {
            return RemoveKey(key.Section, key.Name, key.Value);
        }

        /// <summary>
        /// Removes all comments (starts with a semicolon).
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public void RemoveAllComments()
        {
            CheckLoaded();

            for (int i = 0; i < content.Count; i++)
            {
                if (content[i].Length > 0 && content[i][0].Equals(CommentCharacter))
                {
                    content.RemoveAt(i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Indents all pairs with a tab character.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public void IndentAllPairs()
        {
            CheckLoaded();

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], PAIR_PATTERN, options);

                if (match.Success)
                {
                    content[i] = content[i].Trim();
                    content[i] = '\t' + content[i];
                }
            }
        }

        /// <summary>
        /// Indents all pairs with the specified amount of spaces.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public void IndentAllPairs(int spaces)
        {
            CheckLoaded();
            StringBuilder SB = new StringBuilder();

            for (int i = 0; i < spaces; i++)
            {
                SB.Append(' ');
            }

            string strSpaces = SB.ToString();

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], PAIR_PATTERN, options);

                if (match.Success)
                {
                    content[i] = content[i].Trim();
                    content[i] = strSpaces + content[i];
                }
            }
        }

        /// <summary>
        /// De-indents all pairs with a tab character.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public void UnindentAllPairs()
        {
            CheckLoaded();

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], PAIR_PATTERN, options);

                if (match.Success)
                {
                    content[i] = content[i].Trim();
                }
            }
        }

        /// <summary>
        /// Deletes all keys that have no value set (values that have nothing or just whitespace).
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public void RemoveEmptyKeys()
        {
            CheckLoaded();

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], PAIR_PATTERN, options);

                if (match.Success && match.Groups["Value"].Value.Trim().Equals(string.Empty, sc))
                {
                    content.RemoveAt(i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Removes all blank lines and inserts blank lines above all
        /// the section headers unless the header is on line index 0.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public void FormatBlankLines()
        {
            CheckLoaded();
            if (content.Count.Equals(0)) return;

            // Remove all blank lines.
            for (int i = 0; i < content.Count; i++)
            {
                if (content[i].Trim().Equals(string.Empty, sc))
                {
                    content.RemoveAt(i);
                    i--;
                }
            }

            // Insert blank line above section header, if section header not the first line.
            for (int i = 1; i < content.Count; i++)
            {
                if (Regex.IsMatch(content[i], SECTION_PATTERN, options))
                {
                    content.Insert(i, string.Empty);
                    i++; // Iterate over section header or we will encounter it again.
                }
            }
        }

        /// <summary>
        /// Gets the value of the first occurrence of the specified key.
        /// </summary>
        /// <returns>Returns null if nothing found.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public string GetValueOfAnyKey(string keyName)
        {
            CheckLoaded();

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], PAIR_PATTERN, options);

                if (match.Success && match.Groups["Key"].Value.Equals(keyName, sc))
                {
                    return match.Groups["Value"].Value;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the value of the first occurrence of the specified key in the specified section.
        /// </summary>
        /// <returns>Returns null if nothing found.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public string GetValueOfKey(string keyName, string sectionName)
        {
            CheckLoaded();
            sectionName = sectionName.TrimStart('[');
            sectionName = sectionName.TrimEnd(']');

            int sectionIndex = -1;

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], SECTION_PATTERN, options);

                if (match.Success && match.Groups["Section"].Value.Equals(sectionName, sc))
                {
                    sectionIndex = i;
                }
            }

            if (sectionIndex == -1) return null;

            for (int i = sectionIndex + 1; i < content.Count; i++)
            {
                if (Regex.IsMatch(content[i], SECTION_PATTERN, options))
                    break;

                Match match = Regex.Match(content[i], PAIR_PATTERN, options);

                if (match.Success && match.Groups["Key"].Value.Equals(keyName, sc))
                    return match.Groups["Value"].Value;
            }

            return null;
        }

        /// <summary>
        /// Gets an array of values of multiple same keys.
        /// </summary>
        /// <returns>Returns null if nothing found.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public string[] GetValueOfAllKeys(string keyName, string sectionName)
        {
            CheckLoaded();
            var valueList = new List<string>();
            sectionName = sectionName.TrimStart('[');
            sectionName = sectionName.TrimEnd(']');

            int sectionIndex = -1;

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], SECTION_PATTERN, options);

                if (match.Success && match.Groups["Section"].Value.Equals(sectionName, sc))
                    sectionIndex = i;
            }

            if (sectionIndex == -1)
                return valueList.ToArray();

            for (int i = sectionIndex + 1; i < content.Count; i++)
            {
                if (Regex.IsMatch(content[i], SECTION_PATTERN, options))
                    break;

                Match match = Regex.Match(content[i], PAIR_PATTERN, options);

                if (match.Success && match.Groups["Key"].Value.Equals(keyName, sc))
                    valueList.Add(match.Groups["Value"].Value);
            }

            return valueList.ToArray();
        }

        /// <summary>
        /// Removes the section header and all values under it until another section header appears.
        /// </summary>
        /// <returns>returns true, if section has successfully been removed.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public bool RemoveSection(string sectionName)
        {
            CheckLoaded();
            sectionName = sectionName.TrimStart('[');
            sectionName = sectionName.TrimEnd(']');
            int removeStart = -1;

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], SECTION_PATTERN, options);

                if (match.Success && match.Groups["Section"].Value.Equals(sectionName, sc))
                {
                    removeStart = i;
                    break; // Our section has been found, break
                }
            }

            // could not find section, return false to indicate failure.
            if (removeStart == -1) return false;

            for (int i = removeStart + 1; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], SECTION_PATTERN, options);

                if (match.Success)
                {
                    int length = i - removeStart - 1;
                    content.RemoveRange(removeStart, length);

                    if (content[removeStart].Trim().Equals(string.Empty, sc))
                        content.RemoveAt(removeStart);

                    return true;
                }

                if (i.Equals(content.Count - 1))
                {
                    // Remove end minus start gets the length
                    int length = (content.Count - 1) - removeStart;
                    content.RemoveRange(removeStart, length);

                    if (content[removeStart].Trim().Equals(string.Empty, sc))
                        content.RemoveAt(removeStart);

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Removes a specified line from the content.
        /// </summary>
        /// <returns>returns true, if line has successfully been removed.</returns>
        /// <exception cref="NoFileLoadedException"></exception>
        public bool RemoveLine(string line)
        {
            CheckLoaded();

            for (int i = 0; i < content.Count; i++)
            {
                if (content[i].Trim().Equals(line, sc))
                {
                    content.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Saves the changes to file.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public void Save()
        {
            CheckLoaded();
            File.WriteAllLines(FileName, content);
        }

        /// <summary>
        /// Gets the best suited type of the value of the specified key and the specified section.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public GeneralType GetGeneralType(string keyName, string sectionName)
        {
            CheckLoaded();
            string value = GetValueOfKey(keyName, sectionName).Trim();
            int num;
            float f;

            if (value.Length.Equals(0))
                return GeneralType.Unknown;

            if (value.ToLower().Equals("true") || value.ToLower().Equals("false"))
                return GeneralType.Boolean;

            if (int.TryParse(value, out num))
                return GeneralType.WholeNumber;

            if (float.TryParse(value, out f))
                return GeneralType.PreciseNumber;

            return GeneralType.Text;
        }

        /// <summary>
        /// Gets the best suited type of the value of the specified key.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public GeneralType GetGeneralTypeOfAny(string keyName)
        {
            CheckLoaded();
            string value = GetValueOfAnyKey(keyName).Trim();
            int num;
            float f;

            if (value.Length.Equals(0))
                return GeneralType.Unknown;

            if (value.ToLower().Equals("true") || value.ToLower().Equals("false"))
                return GeneralType.Boolean;

            if (int.TryParse(value, out num))
                return GeneralType.WholeNumber;

            if (float.TryParse(value, out f))
                return GeneralType.PreciseNumber;

            return GeneralType.Text;
        }

        /// <summary>
        /// Gets a list of all section names.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public string[] GetAllSectionNames()
        {
            CheckLoaded();
            var sectionList = new List<string>();

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], SECTION_PATTERN, options);

                if (match.Success)
                    sectionList.Add(match.Groups["Section"].Value);
            }

            return sectionList.ToArray();
        }

        /// <summary>
        /// Gets a list of all section names but exclude names that contain the specified text (case insensitive).
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public string[] GetAllSectionNames(string exclude)
        {
            CheckLoaded();
            exclude = exclude.ToLower();
            var sectionList = new List<string>();

            for (int i = 0; i < content.Count; i++)
            {
                Match match = Regex.Match(content[i], SECTION_PATTERN, options);

                if (match.Success && !match.Value.ToLower().Contains(exclude))
                    sectionList.Add(match.Groups["Section"].Value);
            }

            return sectionList.ToArray();
        }

        /// <summary>
        /// Gets the text content of the loaded .ini as a single string.
        /// </summary>
        /// <exception cref="NoFileLoadedException"></exception>
        public string GetContent()
        {
            CheckLoaded();
            var SB = new StringBuilder();

            foreach (string line in content)
                SB.AppendLine(line);

            return SB.ToString();
        }
    }
}
