using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-pairs/
    /// </summary>
    public class PalindromePairs : Runable
    {
        protected override string ActionName => nameof(ShortestPalindrome);

        protected override void Display(object value)
        {
            foreach (var item in (List<string>) value)
            {
                Console.WriteLine(item);
            }
        }

        protected override object DoAction()
        {
            var inputs = new List<string[]>
            {
                new string[] { "hfjd", "jfhajaadieahg", "fdjddhfdcfdcehi", "gfejeacaeacig", "efadjahgbjffi", "ehfffii", "dhgccjcghjdhjhjdai", "dccfcdiagjbideh", "ifbajfifdea", "cdhbjhhh", "bjcjidhfg", "jjaaihiegcaibhgg", "dhghiiegceghgdabia", "hihiadajddiiegc", "agcicaecieaciaaigd", "g", "bdhfiheajbgf", "degdddbfeejdcbfiif", "adifdgjcade", "chfjdgdgfdcbfihbfe", "bfcahadcbebdjieigdhc", "jfgegjhibecjjj", "hciiggehjbghfgjhj", "cc", "ffjgeji", "ibejefbjhf", "ehj", "jacg", "feagcjbgefjbefaf", "caeijg", "ihbhcddh", "hdhbhfacccecciffj", "cjjebfeefdiddahha", "gcdcgjbeieee", "digghjdcfja", "bagafhf", "c", "addgifjif", "ieehbe", "aiefibeececa", "fjhafhcehdehj", "iffdbegbbjggcghadhh", "jja", "igeejifibagfbhaghhaf", "d", "giaijchiaa", "iefdiicjafhebahcd", "chc", "hebff", "ifegfd", "geaficbdhgicdicbj", "ehigeifabgfhjgbi", "eije", "jdefbdggjbgefjehbge", "aeibjeaaj", "ejjhcdeddhabaacahi", "cfgabfeghchegdjj", "deadgbccebahd", "efccbehbfdddei", "ifi", "agb", "dacjedcchdjid", "gdeji", "bfijdhebbdcai", "ecdhjhfafbb", "cchejjgfhbf", "diieggbfgjfefdbaifi", "jggjdejbcgdicjgfj", "egi", "ih", "jjchdiebja", "feijafjiahhabcefficd", "fgbbibgaffffcbjgccjj", "bedghiidach", "ecehfejeegadjdibdfac", "ijgcbhiaeec", "bfieifa", "bhaaeag", "cgaaideef", "abhhbg", "dcggabdbgebhgacffeee", "eabhfbbbegjhhef", "bib", "ghgdbbbeegjcc", "bheegi", "i", "gcafhfibafdd", "hbdidcdbjibcceee", "hdcgic", "jc", "ide", "gjfbfiiggjfgfeiib", "hcbgeibgbfdjecdhcfci", "hdbjfefgjiafbacgife", "ecfcigeiiaad", "ebfh", "ahecfgacfffdabj", "hgidgdghj", "aiiciccheiebfi", "hjachjbiiaahdgi", "jcdib", "giceadhg", "jaedhaegjejeh", "headgicfcfgafahdi", "bjfbaihhc", "ecjfhfcdfih", "jibcjhajfajibhcj", "ffdagjcefihjidc", "hbcdhecfecdhcbgaacbh", "jid", "cjibig", "cahhijeafiibgadaihe", "fieedidgcjej", "fcea", "becagjgehf", "ba", "jggijbbdcfeecejiicgh", "abjfdfaebcbiefhb", "dhdbbgjegdegfiagb", "ebgafjjeibegjg", "igfcjjehbhga", "ehciihj", "cjgadbfhaaibihcacjid", "ghchcfchegibc", "ddjbheajfcgcca", "cji", "cbhhjceijfigaibjchhe", "ihbccggjggeb", "ecdcicfhjbbbc", "dibbbfha", "jhcdjibibagdeedjcchi", "ecejijcddjbgfjjaji", "hjfjhj", "edeacfdhjd", "af", "eghihebeg", "ifaedbdibifigfeje", "ghjfejeghebi", "ahcd", "ehh", "iihfhbjcij", "ghaccchhbgabaacg", "diihgbhcbbfgagidb", "iafbid", "aehhdbcja", "aagcggbjfdchahihab", "ijhahgfce", "iahhiigcaddhf", "jhejjeghabi", "ebfbeaifehdache", "ca", "haigedibehbjhja", "ejgfbb", "efgihgidh", "edede", "hjaii", "dicdddjafedaa", "abjcghdhgaaabaaccbic", "acbjchabadajcheddbh", "hgcjchhjdfi", "fhfidbajiaceeific", "eddghiahfijjb", "hbaejbh", "ghcdijacbcfichbjedh", "gefcbgaefafgadigfij", "jjaib", "dcdhgejedcg", "hfebhjeabehbhaaijhi", "ghd", "cagheihiaigc", "bd", "dccgbebbbai", "f", "bdbhedigci", "gdciehiifefibeigfgh", "icejeajchfgbiccehi", "eahgb", "jjfebhjhgghe", "eaajbihccag", "ijhjhfabccdfaghd", "jcffihgdfd", "hefh", "ahbgfcecagiahfa", "cigffhgeijh", "ghcdhdgfgdhfbijgb", "bdgdbeefiajehcf", "a", "gcjidfd", "jbbeiicahdc", "gdffi", "gdcbagjfice", "bfiigabciijcgaiih", "hafeedebdif", "efeaeigdaiihja", "edjcgae", "gcehf", "aebjcfcdiagee", "jddci", "gejhe", "bdahiicijibahfgbid", "afccgaihideghi", "eedfd", "abafh", "fgdgjddibjcejdejg", "fjedhfcbeffegcbhaadj", "jhicdbdiehddechf", "jjgbbfdbgeegcaia", "bcah", "ghhgecaajbbcjge", "ajagbhajgbadhhibg", "hbeggafgbai", "cbjhgcgaffbdhb", "jib", "jcjjfiebd", "fgbhffaig", "e", "iefgbcadafbbbgjci", "ihdhbjgcca", "gefifbgcajcabef", "ijbeicahfafagabiedg", "iaceiabjd", "chcejbai", "edjjajiccgabghdgbei", "ghgdbcdccbgfefd", "iie", "cdgejcabbcbhgjcjec", "jbgcfbfbbeagajh", "dccbb", "ihcjhfjcfghgg", "cahhdaeheaejfic", "bgahebhbgbhdagj", "gag", "aeihfjadea", "bbaigaj", "gicic", "fiecehabaajhid", "cjghjdbdegbaiageifce", "gdgcf", "dddbjbi", "bgjhdjeefbc", "difgffciafjbbfiagf", "icahdfedabffhacg", "hjhae", "hhgbabc", "abbggaeibacibjafbg", "gjdgfcj", "cffchjjeeachefcjjh", "bhcbg", "hjfjfaehjdj", "gjcdgjjhaji", "ihfajdc", "jichbjiaddadgibj", "dgjefhjij", "dhaed", "gghgcjje", "jefajijciffigceaj", "jccjijc", "hijbgddhccheaeaadjif", "jhghabejdhcbdbfjg", "jbjicjgagbejhbf", "cbdb", "hcgeghfeai", "iecigchdgdhhii", "deaihbejgbe", "ejcgggebahibhiheai", "jfdghjdihafgheeidchc", "agibbfigaejfia", "ifegddacdcjej", "cjhafiebhai", "dbh", "bbdifjbe", "cbegh", "jbffbjeffhdbdib", "fcbbgdjdg", "hhidcjjc", "bgidbagebbjcgfdccdcc", "gaidc", "jdfeajcafcdhec", "fda", "ihfaa", "babhbahbicdiefea", "fceiafjfchcj", "afijgeeccghdiaa", "hhjcdefjbfcgjcf", "ciaeji", "jhdedfj", "bcfdjhfdhdafgfjc", "ibbiaicafai", "dgcicgafc", "affjbchhicdacejjgde", "ej", "cicahbhac", "ddjdcddiab", "aaj", "igfedigjgdgd", "cbecjgeeag", "fjhfdfbb", "hcdghhcjfjg", "ccbefai", "chibjd", "baghechiiieiighifi", "egahgebhihcdghjaffah", "gchgbeghabehheeigid", "dcdejidcb", "gfgjafii", "agabjgehaadf", "achegfgihhij", "aibcifjjeahhb", "hc", "hebiaa", "hahcfadgg", "cdgcaghidgfifgibfba", "jjbjijecichjjccje", "jcjeiejga", "b", "bb", "gj", "cbgceh", "befde", "cidegbgagf", "dafbb", "geeafdbjjebfeiieeb", "hhjdcafeaebbach", "cffggdeeih", "jfddjejhehe", "biibchbcigcee", "ibjjaah", "igjjafgffded", "hgbj", "fbhfaajhgicgeiajibdf", "gfibhaccjfh", "bhhhaejhf", "bebf", "gfcbjfadfehegiibjha", "jbihhcfgjbggi", "ecbfhicbfijf", "djdjehgifei", "j", "bdfaicdjhgdihcdi", "djaaddigeeifbciehd", "cchafje", "ibhdeade", "fggicjcaiee", "afebjfbe", "fchfcjfeaafej", "dcegjia", "hjjbaggb", "hcebbchdechfj", "cbi", "ejgdfgfbgbgahaeihb", "fiiibcfjajhdafhha", "fgjab", "cidc", "gecd", "bijgffgfjbfdecjii", "eigghcbb", "fefcbffeihijehc", "dfahab", "gffagff", "fgebcghiajcdafha", "hdi", "fghfjia", "eejcfhhcdjcdajeji", "jgca", "aj", "ei", "ejcdh", "chdfdfahehdgii", "eihgjaeagcjbjdbiib", "ahjghheecifc", "hggeeacfhceidgifbag", "giebhgebeafigbgbigc", "gbcif", "cebcbeefbica", "ggghca", "gceaicb", "fgjdjih", "eehcdajadh", "fchgdjhibjjchcccci", "bdcdbbefbabjj", "deeabgdibccige", "dadhdifjccig", "dgja", "ghcahfdccbbbegdgi", "bc", "df", "jhaebbeeagf", "dajjjcdfiaifcaachhj", "jhefbhgbgchbiiea", "aagdjhdibabfbbebe", "bggiaaeje", "jhgejdg", "dgjbdgbdchgf", "hea", "bacicfcjiifceabecfe", "afaahjde", "deebachgigahbac", "edideehfgjbbgehgi", "id", "cgcffjejhdacfcccbijj", "ahghcghfchfbdegdb", "bhcdaijiihff", "jddhg", "eeaffdibdeefgfd", "dgdbfhaigagbbdbjd", "ib", "cdfa", "jfbhbiibiebffc", "jigdbjcbjgedjajadb", "chdaddfgifbi", "da", "dfjedajghfbbfgebb", "cfjihhccdibegeccgjhg", "aheegacijjgdgaicehfi", "ahhijdgf", "bgadfbaaagija", "hibhebbcgfg", "cefhbcahadijhgacidaa", "acaegibddceicjafbbcj", "bhda", "gjgahdjgihbfedhiadch", "fbd", "ihcagdigiibggd", "cdjdbdebciehifccbdf", "heedhhchbhgabjafib", "cjf", "chdgjcgcejjid", "bf", "hffihgahhhbgehjdg", "igbjehacfhagicd", "bjefhgfcighfc", "jhabf", "ebacbcfchgigjbbged", "hihbhgigjj", "ebieeichifeicjce", "gijbhebddefcgbcg", "ggj", "igfddeffiadgejh", "gdfiidfgadbaifcihai", "echghadhjaiejda", "jebjbagagjjhcdfb", "igifdccbii", "agbjiajhbcbfachbd", "bfcidhabefjjj", "afeeghcicbcfbgj", "fff", "fcccjbjhhhbabiafdfj", "hbcgcehibcdefagcf", "gghdeea", "ecjfffege", "ihifdbe", "cfiicegii", "ighddeiheacjddgd", "hicjfaebcjaeecddhch", "jdcdjfjbhaefehahhh", "cjagdcibf", "jhddjdh", "aaefbaggcdigehfhifii", "idaiah", "edbf", "ciaddfcccgae", "fcebgaajahbfeffcidd", "dfijdgeghh", "dfjfdf", "eaggbeeidiiacb", "fc", "bjibjccdfbdf", "jii", "jijgfbg", "fi", "fedjchdcghifjife", "egjfibhgahi", "jcf", "aeciia", "edhb", "eai", "ficcdffe", "hiedjedadiahhcbd", "jdjihcfahciheaciaahd", "bjcabjcgjhfbbhbagc", "ajghc", "iaaeajfbbadeeejfh", "hfciaeacjc", "igaefcdda", "ccad", "djhji", "jagai", "hdheidi", "aeecab", "aidjfh" },
                new string[] { "aabaa", "" },
                new string[] { "a", "abc", "aba", "" },
                new string[] { "a", "" },
                new string[] { "abcd", "dcba", "lls", "s", "sssll" },
                new string[] { "bat", "tab", "cat" }
            };

            var output = new List<string>();

            foreach (var words in inputs)
            {
                var value = DoPalindromePairs(words);

                foreach (var item in value)
                {
                    output.Add($"[{string.Join(',', item)}] => '{words[item[0]]}{words[item[1]]}'");
                }
            }

            return output;
        }

        private IList<IList<int>> DoPalindromePairs(string[] words)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<string, string> cache = new Dictionary<string, string>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (CanPair(words[i], words[j], cache))
                    {
                        result.Add(new List<int>() { i, j });
                    }
                }
            }

            return result;
        }

        private bool CanPair(string a, string b, Dictionary<string, string> cache)
        {
            var @long = a + b;

            if (@long.Length == 1)
            {
                return true;
            }

            var mid = @long.Length / 2;
            string partA;
            string partB;

            if (@long.Length % 2 == 0)
            {
                partA = @long.Substring(0, mid);
                partB = @long.Substring(mid, mid);
            }
            else
            {
                partA = @long.Substring(0, mid);
                partB = @long.Substring(mid + 1, mid);
            }

            string resvert;
            if (!cache.ContainsKey(partB))
            {
                var chars = partB.ToCharArray();
                Array.Reverse(chars);
                resvert = new string(chars);
                cache[partB] = resvert;
            }
            else
            {
                resvert = cache[partB];
            }

            var result = string.Equals(partA, resvert);

            return result;
        }
    }
}