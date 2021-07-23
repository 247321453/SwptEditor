using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SwptSaveLib
{

    public static class GameConstants
    {
        public static string[] Companions = new string[] { "Kira", "Arisha", "Kerila", "Lanora", "Diliana", "Mirena", "Rowena" };
        public static string SAVE_PATH = @"C:\Users\" + System.Environment.UserName + @"\AppData\LocalLow\L2 Games\She Will Punish Them\";
        public static string[] SKILL_NAMES = {
            "fastlearner",
            "summoner",
            "commanding",
            "trading",
            "crystalhunter",
            "scavenger",
            "goldenhand",
            "elementalresistence",
            "alchemist",
            "painfulscream",
            "frostbite",
            "fireball",
            "healaura",
            "recreation",
            "dodging",
            "atheletic",
            "ignorpain",
            "hardenedskin",
            "ironbody",
            "focus",
            "phatomslashes",
            "blocking",
            "bowproficiency",
            "maceproficiency",
            "axeproficiency",
            "swordproficiency",
            "daggerproficiency"
        };
        public static string[] ATTR_NAMES = { "power", "agility", "strength", "vitality" };

        public static string[] EQUIP_NAMES = {
             "armor",// = 胸甲
            "gloves",// = 手套
            "leggings",// = 绑腿
            "shoes",// = 鞋子
            "helmet",// = 头盔
            "weapon",// = 武器
            "weapon2",// = 武器2
            "shield",// = 盾牌
        };
        private static bool ITEM_PREFIX_SURFIX_ONE = true;
        private static Dictionary<string, string> VALUE_NAMES = new Dictionary<string, string>();
        private static Dictionary<string, string> FILE_NAMES = new Dictionary<string, string>();
        public static Dictionary<string, string> ITEM_NAMES = new Dictionary<string, string>();
        public static Dictionary<string, string> PREFIX_NAMES = new Dictionary<string, string>();
        public static Dictionary<string, string> SURFIX_NAMES = new Dictionary<string, string>();
        public static Dictionary<string, string> MAP_NAMES = new Dictionary<string, string>();

        public static KeyValue[] ITEMS = new KeyValue[0];
        public static KeyValue[] PREFIXS = new KeyValue[0];
        public static KeyValue[] SURFIXS = new KeyValue[0];

        static GameConstants()
        {
            VALUE_NAMES.Add("health", "当前血量");
            VALUE_NAMES.Add("maxHealth", "最大血量");
            VALUE_NAMES.Add("mana", "当前魔力");
            VALUE_NAMES.Add("maxMana", "最大魔力");

            VALUE_NAMES.Add("curExp", "当前经验");
            VALUE_NAMES.Add("nextExp", "下一级经验");
            VALUE_NAMES.Add("position", "位置");


            VALUE_NAMES.Add("level", "等级");
            VALUE_NAMES.Add("companionlist", "随从列表");
            VALUE_NAMES.Add("characterName", "角色名");
            VALUE_NAMES.Add("power", "属性:魔力");
            VALUE_NAMES.Add("agility", "属性:敏捷");
            VALUE_NAMES.Add("strength", "属性:力量");
            VALUE_NAMES.Add("vitality", "属性:活力");
            VALUE_NAMES.Add("skillPoints", "角色:技能点");
            VALUE_NAMES.Add("attributePoints", "角色:属性点");

            VALUE_NAMES.Add("daggerproficiency", "技能:匕首专精");
            VALUE_NAMES.Add("swordproficiency", "技能:剑类专精");
            VALUE_NAMES.Add("axeproficiency", "技能:斧类专精");
            VALUE_NAMES.Add("maceproficiency", "技能:钝器专精");
            VALUE_NAMES.Add("bowproficiency", "技能:弓箭专精");
            VALUE_NAMES.Add("blocking", "技能:格挡");
            VALUE_NAMES.Add("phatomslashes", "技能:幻影攻击");
            VALUE_NAMES.Add("focus", "技能:专注");

            VALUE_NAMES.Add("ignorpain", "技能:无视痛苦");
            VALUE_NAMES.Add("recreation", "技能:自愈");
            VALUE_NAMES.Add("ironbody", "技能:钢铁之躯");
            VALUE_NAMES.Add("hardenedskin", "技能:硬化皮肤");
            VALUE_NAMES.Add("atheletic", "技能:矫健");
            VALUE_NAMES.Add("dodging", "技能:闪避");

            VALUE_NAMES.Add("healaura", "技能:治愈之光");
            VALUE_NAMES.Add("fireball", "技能:火球术");
            VALUE_NAMES.Add("frostbite", "技能:冰霜术");
            VALUE_NAMES.Add("painfulscream", "技能:痛苦尖叫(未实现)");
            VALUE_NAMES.Add("alchemist", "技能:炼金术");
            VALUE_NAMES.Add("elementalresistence", "技能:元素抵抗");

            VALUE_NAMES.Add("goldenhand", "技能:金手指");
            VALUE_NAMES.Add("scavenger", "技能:掠夺者");
            VALUE_NAMES.Add("trading", "技能:交易");
            VALUE_NAMES.Add("crystalhunter", "技能:水晶猎手");
            VALUE_NAMES.Add("commanding", "技能:团队作战");
            VALUE_NAMES.Add("summoner", "技能:召唤师");
            VALUE_NAMES.Add("fastlearner", "技能:快速学习者");
        }

        public static void Init(string path, byte[] def = null)
        {
            Dictionary<string, string> dic = null;
            string[] lines;
            if (!File.Exists(path))
            {
                if (def == null)
                {
                    return;
                }
                string str = Encoding.UTF8.GetString(def).Replace("\r\n", "\n");
                lines = str.Split('\n');
                File.WriteAllText(path, str, new UTF8Encoding(false));
            }
            else
            {
                lines = File.ReadAllLines(path);
            }
            foreach (var line in lines)
            {
                if (line.StartsWith("#save name"))
                {
                    dic = VALUE_NAMES;
                }
                else if (line.StartsWith("#file"))
                {
                    dic = FILE_NAMES;
                }
                else if (line.StartsWith("#item"))
                {
                    dic = ITEM_NAMES;
                }
                else if (line.StartsWith("#prefix"))
                {
                    dic = PREFIX_NAMES;
                }
                else if (line.StartsWith("#surfix"))
                {
                    if (ITEM_PREFIX_SURFIX_ONE)
                    {
                        dic = PREFIX_NAMES;
                    }
                    else {
                        dic = SURFIX_NAMES;
                    }
                }
                else if (line.StartsWith("#map"))
                {
                    dic = MAP_NAMES;
                }
                else
                {
                    if (line.StartsWith("#"))
                    {
                        continue;
                    }
                    int i = line.IndexOf('=');
                    if (i > 0)
                    {
                        string k = line.Substring(0, i);//.Trim();
                        if (dic == FILE_NAMES)
                        {
                            k = k.ToLower();
                        }
                        string v = line.Substring(i + 1).Trim();
                        if (dic != null)
                        {
                            dic.AddOrUpdate(k, v);
                        }
                    }
                }
            }
            ITEMS = ToKeyValue(ITEM_NAMES);
            PREFIXS = ToKeyValue(PREFIX_NAMES);
            if (ITEM_PREFIX_SURFIX_ONE)
            {
                SURFIXS = ToKeyValue(PREFIX_NAMES);
            }
            else
            {
                SURFIXS = ToKeyValue(SURFIX_NAMES);
            }
        }

        private static KeyValue[] ToKeyValue(Dictionary<string, string> dic)
        {
            List<KeyValue> list = new List<KeyValue>();
            foreach (string k in dic.Keys)
            {
                list.Add(new KeyValue(k, dic[k]));
            }
            return list.ToArray();
        }

        private static void AddOrUpdate(this Dictionary<string, string> dic, string k, string v)
        {
            if (dic.ContainsKey(k))
            {
                dic[k] = v;
            }
            else
            {
                dic.Add(k, v);
            }
        }
        public static string GetMapText(string text, string def)
        {
            string val;
            if (MAP_NAMES.TryGetValue(text, out val))
            {
                return val;
            }
            return def;
        }
        public static string GetSurfixText(string text, string def)
        {
            string val;
            if (ITEM_PREFIX_SURFIX_ONE)
            {
                return GetPrefixText(text, def);
            }
            if (SURFIX_NAMES.TryGetValue(text, out val))
            {
                return val;
            }
            return def;
        }

        public static string GetPrefixText(string text, string def)
        {
            string val;
            if (PREFIX_NAMES.TryGetValue(text, out val))
            {
                return val;
            }
            return def;
        }
        public static string GetItemText(string text, string def)
        {
            string val;
            if (ITEM_NAMES.TryGetValue(text, out val))
            {
                return val;
            }
            return def;
        }
        public static string GetFileDisplayName(this SaveFile that)
        {
            string name = that.Name;
            string val;
            if (FILE_NAMES.TryGetValue(name.ToLower(), out val))
            {
                return val;
            }
            return name;
        }

        private static string GetDisplayName(string key, string def)
        {
            string val;
            if (VALUE_NAMES.TryGetValue(key, out val))
            {
                return val;
            }
            return def;
        }

        public static string GetDisplayName(this SaveProperty that)
        {
            string Name = that.Name;
            string val = GetDisplayName(Name, Name);
            if (val == Name)
            {
                if (Name.StartsWith("xy"))
                {
                    return Name.Substring(2) + GetDisplayName("item xy", "的位置");
                }
                else if (Name.StartsWith("name"))
                {
                    return Name.Substring(4) + GetDisplayName("item name", "的物品名");
                }
                else if (Name.StartsWith("pos"))
                {
                    return Name.Substring(3) + GetDisplayName("item pos", "的位置");
                }
                else if (Name.StartsWith("prefix"))
                {
                    return Name.Substring(6) + GetDisplayName("item prefix", "的词条1");
                }
                else if (Name.StartsWith("surfix"))
                {
                    return Name.Substring(6) + GetDisplayName("item surfix", "的词条2");
                }
                else if (Name.EndsWith("prisoner"))
                {
                    string key = Name.Substring(0, Name.Length - 8);
                    string name = GetMapText(key, key);
                    if (name == key)
                    {
                        return name;
                    }
                    return name + GetDisplayName("map prisoner", ":救援目标");
                }
                else if (Name.EndsWith("locked"))
                {
                    string key = Name.Substring(0, Name.Length - 6);
                    string name = GetMapText(key, key);
                    if (name == key)
                    {
                        return name;
                    }
                    return name + GetDisplayName("map locked", ":锁定");
                }
                else if (Name.EndsWith("level"))
                {
                    string key = Name.Substring(0, Name.Length - 5);
                    string name = GetMapText(key, key);
                    if (name == key)
                    {
                        return name;
                    }
                    return name + GetDisplayName("map level", ":等级");
                }
                else if (Name.EndsWith("activeSelf"))
                {
                    string key = Name.Substring(0, Name.Length - 10);
                    string name = GetMapText(key, key);
                    if (name == key)
                    {
                        return name;
                    }
                    return name + GetDisplayName("map activeSelf", ":显示");
                }
                else if (Name.EndsWith("isCleared"))
                {
                    string key = Name.Substring(0, Name.Length - 9);
                    string name = GetMapText(key, key);
                    if (name == key)
                    {
                        return name;
                    }
                    return name + GetDisplayName("map isCleared", ":清理");
                }
            }
            return val;
        }

        public static bool IsSkill(this SaveProperty that)
        {
            foreach (var name in SKILL_NAMES)
            {
                if (that.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsAttr(this SaveProperty that)
        {
            foreach (var name in ATTR_NAMES)
            {
                if (that.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public static string GetHexString(this byte[] data, int start = 0, int end = -1, string sep = " ")
        {
            StringBuilder builder = new StringBuilder();
            bool first = true;
            if (end < 0)
            {
                end = data.Length;
            }
            else if (end > data.Length)
            {
                end = data.Length;
            }
            for (int i = start; i < end; i++)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    builder.Append(sep);
                }
                builder.Append(data[i].ToString("X"));
            }
            return builder.ToString();
        }

        private static string[] CONSUMEABLE_NAMES = {
            "Health Potion",
            "Mana Potion",
            "Minor Health Potion",
            "Arrow",
            "Draugr Warrior Scroll",//僵尸战士卷轴
            "Orc War Maiden Scroll",//兽人女战士卷轴
            "Reaper Scroll",//收割者卷轴
            "Skeleton Champion Archer Scroll",//骷髅冠军弓箭手卷轴
            "Skeleton Great Axeman Scroll",//巨斧骷髅卷轴
            "Skeleton Warlord Scroll",//骷髅王卷轴
            "Skeleton Warrior Scroll",//骷髅兵卷轴
            "Wraith Scroll",//幽灵卷轴
            "Experience Book",//经验之术
            "Experience Scroll",//经验卷轴
            "Golden Key",//金宝箱钥匙
            "Key",//钥匙
            "Master Experience Book",//大师经验卷轴
            "Minor Health Potion",//小瓶生命药剂
            "Emerald Ring",//翡翠指环
            "Goden Ruby Ring",//红宝石指环
            "Golden Ring",//金戒指
            "Golden Snake Ring",//金蛇指环
            "Luxury Ring",//蓝宝石银戒指
            "Platinum Serpant Ring",//银蛇指环
            "Ruby Ring",//小红宝石戒指
            "Silver Ring",//银戒指
            "Crystal Horn",//水晶角
            "Delicate Horn Cup",//精致牛角杯
            "Golden Bracelet",//金手镯
            "Golden Goblet",//金制圣杯
            "Golden Jug",//金罐子
            "Golden Snake Bracelet",//金蛇手镯
            "Golden Wine Pot",//金酒壶
            "Ruby",//红宝石
            "Silver Crystal Ring",//蓝宝石戒指
            "Silver Cup",//银酒杯
            "Small Snake Statue",//小蛇雕像
        };
        public static bool IsConsumeables(this string name)
        {
            foreach (var n in CONSUMEABLE_NAMES)
            {
                if (n == name)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
