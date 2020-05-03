using System;
using System.Linq;
using System.Windows.Forms;

namespace bin_char_test_tree
{
    public partial class formBinCharTreeTest : Form
    {
        classLeaf cRoot;
        char chrNull = '\0';
        int index = 1;
        int irl = 0;
        int prov = 0;
        public formBinCharTreeTest()
        {
            InitializeComponent();
            cRoot = new classLeaf(chrNull);
        }

        /// <summary>
        /// parses words from text in txtInput textbox into a string array then inserts each word int the data-tree
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            char[] cSplitChar = { '\r', '\n', ' ', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '=', '+', ']', '[', '{', '}', ';', ':', '\'', '\"', '|', '\\', '?', '/', '>', '.', '<', ',', '`', '~', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] strWords = txtInput.Text.Split(cSplitChar, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in strWords)
                insertWord(ref cRoot, s + chrNull);

        }

        /// <summary>
        /// searches for a word in the database then prints a user-output result in lblSearchResult label
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int irl = wordInTree(ref cRoot, txtSearch.Text);
            if (irl > 0)
            {
                lblSearchResult.Text = "Found" + Convert.ToString(irl);
            }
            else
            {
                lblSearchResult.Text = "not found";
            }

        }

        private void btnTraverseTree_Click(object sender, EventArgs e)
        {
            string[] strWords = new string[0];
            traverseTree(ref cRoot, ref strWords, "");
            /* for (int i = 1; i < strWords.Length; i++)
             {
                 strWords[i] = Convert.ToString(i) + " " + strWords[i];
             }
             */
            cmbWords.DataSource = strWords;
        }

        /// <summary>
        /// searches for a word in the database by interating through each char of the input word from left to right
        /// </summary>
        /// <param name="cLeaf">reference tree-leaf from which search is begun</param>
        /// <param name="strWord">word to be searched is left-chopped by one char for each iteration until null string or end of search</param>
        /// <returns>true if word is found, otherwise false</returns>
        private int wordInTree(ref classLeaf cLeaf, string strWord)
        {
            irl = 0;
            // test first char of word against input Leaf's char field
            if (strWord[0] > cLeaf.chr)
            { // first char belongs below this leaf
                if (cLeaf.down != null)
                    return wordInTree(ref cLeaf.down, strWord);
                else
                    return irl;
            }
            else if (strWord[0] < cLeaf.chr)
            { // first char belongs aleaf, stop, help.bove this leaf
                if (cLeaf.up != null)
                    return wordInTree(ref cLeaf.up, strWord);
                else
                    return irl;
            }
            else if (strWord[0] == cLeaf.chr)
            { // first char matches this leaf
                if ((strWord.Length == 1) && (cLeaf.index > 0)) // last char in input word
                {
                    irl = cLeaf.index;
                    return irl;
                }
                else if ((strWord.Length == 1) && (cLeaf.index == 0))
                    return irl;
                else // iterate along 'next' leaf for second char
                    return wordInTree(ref cLeaf.next, strWord.Substring(1));

            }

            MessageBox.Show("this should not happen");
            return irl;
        }




        /// <summary>
        /// inserts word into database by iterating along tree proceeding one char at a time from left to right of input word
        /// </summary>
        /// <param name="cLeaf">reference to leaf from which insertino is to begin</param>
        /// <param name="strWord">word to be inserted</param>
        private void insertWord(ref classLeaf cLeaf, string strWord)
        {
            // test first char of word against this leaf
            if (strWord[0] > cLeaf.chr)
            { // first char belongs below this one

                if (cLeaf.down != null)
                {
                    if (strWord.Length == 2)
                    {
                        classLeaf cIndex = new classLeaf(index);
                        cLeaf.index = index;
                        index++;
                    }
                    insertWord(ref cLeaf.down, strWord); // iterate through tree with current word
                }
                else
                { // there is no leaf going down -> create new leaf 
                    classLeaf cDown = new classLeaf(strWord[0]);
                    // set this leaf's down field to new leaf
                    cLeaf.down = cDown;
                    // if there are more letters in word, iterate through tree with current word
                    if (strWord.Length > 1)
                        insertWord(ref cDown, strWord);
                }
            }
            else if (strWord[0] < cLeaf.chr)
            { // first char belongs above this leaf
                if (cLeaf.up != null)
                    insertWord(ref cLeaf.up, strWord); // iterate through tree with current word
                else
                { // there is no leaf going up -> create new leaf
                    classLeaf cUp = new classLeaf(strWord[0]);
                    // set this leaf's up field to new leaf
                    cLeaf.up = cUp;
                    // if there are more letters in word, iterate through tree with current word
                    if (strWord.Length > 1)
                        insertWord(ref cUp, strWord);
                    /*   if (strWord.Length == 1)
                       {
                           classLeaf cIndex = new classLeaf(index);
                           cLeaf.index = index;
                           index++;
                       } */
                }

            }
            else if (strWord[0] == cLeaf.chr)
            { // first char is identical to this leaf's chr field
                if (strWord.Length > 1)
                { // the word insertion is not complete
                    if (cLeaf.next != null)
                    {

                        if (strWord.Length == 2)
                        {
                            classLeaf cIndex = new classLeaf(index);
                            cLeaf.index = index;
                            index++;
                        }
                        insertWord(ref cLeaf.next, strWord.Substring(1)); // iterate through tree with chopped word
                    }
                    else
                    { // there is no leaf going next -> create new leaf
                        classLeaf cNext = new classLeaf(strWord[1]);
                        // set this leaf's next field to new leaf
                        cLeaf.next = cNext;
                        /*if ((prov == 1) && (strWord.Length == 2))
                        {
                            classLeaf cIndex = new classLeaf(index);
                            cLeaf.index = index;
                            index++;
                        }
                        */
                        if ((strWord.Length == 2) && (prov == 0))
                        {
                            classLeaf cIndex = new classLeaf(index);
                            cLeaf.index = index;
                            index++;
                        }
                        // iterate through tree with current word
                        insertWord(ref cNext, strWord.Substring(1)); // iterate through tree with chopped word


                    }
                }
            }
            //дво, дворник, двор, дворовой
        }

        void traverseTree(ref classLeaf cLeaf, ref string[] strWords, string strThisWord)
        {
            if (cLeaf.up != null)
                traverseTree(ref cLeaf.up, ref strWords, strThisWord);

            string strExtendedWord = strThisWord + cLeaf.chr.ToString();
            if (cLeaf.chr == chrNull)
            {
                Array.Resize<string>(ref strWords, strWords.Length + 1);
                strWords[strWords.Length - 1] = strExtendedWord;
            }
            else
                if (cLeaf.next != null)
                traverseTree(ref cLeaf.next, ref strWords, strExtendedWord);

            if (cLeaf.down != null)
                traverseTree(ref cLeaf.down, ref strWords, strThisWord);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            index = 1;
            string[] strWords = new string[0];
            traverseTree(ref cRoot, ref strWords, "");
            var list = strWords.Cast<string>().ToList();
            string rro = txtInput.Text + "\0";
            string userRem = list.FirstOrDefault(us => us == rro);
            foreach (string s in strWords)
                deleteWord(ref cRoot, s);
            if (userRem != null)
                list.Remove(userRem);
            cmbWords.DataSource = list;
            strWords = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                strWords[i] = list[i];
            }
            prov = 1;
            
            foreach (string s in strWords)
            {
                
                //    char[] MyChar = { ', '0' };
                //    string str = s.Trim(MyChar) ;
                insertWord(ref cRoot, s);
            }
            prov = 0;
        }

        int scc = 0;
        private void deleteWord(ref classLeaf cLeaf, string strWord)
        {
            if (scc != 0)
            {

                if ((cLeaf.down != null) || (cLeaf.next != null)) 
                {
                    if ((cLeaf.down != null) && (cLeaf.index == 0) && (strWord.Length != 0))
                    {
                        deleteWord(ref cLeaf.down, strWord.Substring(1));
                    }
                    if ((cLeaf.next != null)&&(cLeaf.index == 0) && (strWord.Length != 0))
                    {

                        deleteWord(ref cLeaf.next, strWord.Substring(1));
                    }
                    cLeaf.down = null;
                    cLeaf.up = null;
                    cLeaf.next = null;
                    cLeaf.index = 0;
                }

            }
            scc++;
        }
    }

    public class classLeaf
    {
        public classLeaf down;
        public classLeaf up;
        public classLeaf next;
        public int index;
        public char chr;

        public classLeaf(char c)
        {
            chr = c;
        }
        public classLeaf(int i)
        {
            index = i;
        }
    }
}
