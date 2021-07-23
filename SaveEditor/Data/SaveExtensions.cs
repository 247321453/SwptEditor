using SwptSaveLib.ValueTypes;
using System;
using System.Collections.Generic;
using System.IO;

namespace SwptSaveLib
{
    public static class SaveExtensions
    {
        #region save
        public static void SetCharacterName(this SaveFile that, string name)
        {
            var tag = that.Get("characterName");
            if (tag != null && tag.IsStringType())
            {
                tag.SetStringValue(name);
            }
        }

        public static string GetCharacterName(this SaveFile that)
        {
            var tag = that.Get("characterName");
            if (tag != null && tag.IsStringType())
            {
                return tag.GetStringValue();
            }
            return null;
        }
        public static int GetLevel(this SaveFile that)
        {
            var tag = that.Get("level");
            if (tag != null && tag.IsIntType())
            {
                return tag.GetInt32Value();
            }
            return -1;
        }

        public static string[] GetCompanionList(this SaveFile that)
        {
            var val = that.Get("companionlist");
            if (val != null && val.IsStringArrayType())
            {
                return val.GetStringArray();
            }
            return new string[0];
        }
        public static void SetCompanionList(this SaveFile that, string[] arr)
        {
            var val = that.Get("companionlist");
            if (val != null && val.IsStringArrayType())
            {
                val.SetStringArray(arr);
            }
        }
        public static int ResetSkill(this SaveFile that)
        {
            int new_count = 0;
            var countVal = that.Get("skillPoints");
            if (countVal != null)
            {
                int level = that.GetLevel();
                var old_count = countVal.GetInt32Value();
                if (level > 0 && old_count == (level * 2))
                {
                    Console.WriteLine("不需要重置技能");
                    return 1;
                }
                if (old_count < 255 * 2)
                {
                    foreach (var name in GameConstants.SKILL_NAMES)
                    {
                        var value = that.Get(name);
                        if (value != null)
                        {
                            var val = value.GetInt32Value();
                            new_count += val;
                            value.SetInt32Value(0);
                        }
                    }
                    var merge_count = new_count + old_count;
                    if (merge_count < level * 2)
                    {
                        merge_count = level * 2;
                    }
                    Console.WriteLine("技能点:" + old_count + "->" + merge_count);
                    countVal.SetInt32Value(merge_count);
                    return 0;
                }
                else
                {
                    Console.WriteLine("无法识别技能点数据");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("无法识别技能点数据");
                return -1;
            }
        }

        public static int ResetAttr(this SaveFile that)
        {
            int new_count = 0;
            var countVal = that.Get("attributePoints");
            if (countVal != null)
            {
                var old_count = countVal.GetInt32Value();
                int level = that.GetLevel();
                if (level > 0 && old_count == level)
                {
                    Console.WriteLine("不需要重置属性");
                    return 1;
                }
                if (old_count < 255)
                {
                    foreach (var name in GameConstants.ATTR_NAMES)
                    {
                        var value = that.Get(name);
                        if (value != null)
                        {
                            var val = value.GetInt32Value();
                            new_count += val;
                            value.SetInt32Value(0);
                        }
                    }
                    var merge_count = new_count + old_count;
                    if (merge_count < level)
                    {
                        merge_count = level;
                    }
                    Console.WriteLine("属性点:" + old_count + "->" + merge_count);
                    countVal.SetInt32Value(merge_count);
                    return 0;
                }
                else
                {
                    Console.WriteLine("无法识别属性点数据");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("无法属性点数据");
                return -1;
            }
        }
        public static SaveProperty CreateStorage(this SaveFile that, string name)
        {
            SaveProperty property = new SaveProperty("idArray" + name + " Storage", new ArrayValue(SaveValueType.Int32));
            that.InsertProperty(0, property);
            return property;
        }

        public static SaveProperty GetStorage(this SaveFile that, string name)
        {
            return that.Get("idArray" + name + " Storage");
        }

        public static bool DeleteStorage(this SaveFile that, string name)
        {
            return that.Delete("idArray" + name + " Storage");
        }

        public static bool Delete(this SaveFile that, string key)
        {
            int index = that.IndexOfProperty(key);
            if (index >= 0)
            {
                that.RemoveProperty(index);
                return true;
            }
            return false;
        }

        public static List<int> GetEquipItems(this SaveFile that)
        {
            List<int> ids = new List<int>();
            foreach (var name in GameConstants.EQUIP_NAMES)
            {
                var gv = that.Get(name);
                if (gv != null)
                {
                    int id = gv.GetInt32Value();
                    if (id != 0)
                    {
                        ids.Add(id);
                    }
                }
            }
            return ids;
        }

        public static void ClearEquip(this SaveFile that)
        {
            foreach (var name in GameConstants.EQUIP_NAMES)
            {
                var gv = that.Get(name);
                if (gv != null)
                {
                    gv.SetInt32Value(0);
                }
            }
        }

        public static bool Save(this SaveFile that, bool backup)
        {
            string path = that.FilePath;
            string bak = null;
            if (backup)
            {
                string dir = Path.GetDirectoryName(path);
                string name = Path.GetFileNameWithoutExtension(path);
                Console.WriteLine(">备份存档:" + name);
                bak = Path.Combine(dir, name + ".bak");
                if (File.Exists(bak))
                {
                    File.Delete(bak);
                }
                Console.WriteLine("backup:"+path+"->"+bak);
                File.Move(path, bak);
                if (!File.Exists(bak))
                {
                    Console.WriteLine(">备份存档失败");
                    return false;
                }
            }
            try
            {
                that.Save();
                Console.WriteLine(">备份存档成功");
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                //还原备份
                if (bak != null && File.Exists(bak))
                {
                    File.Delete(path);
                    File.Move(bak, path);
                }
                return false;
            }
        }

        #endregion

        #region item
        public static bool IsItemMode(this SaveFile that)
        {
            return that.Name == "Items";
        }
        public static List<Item> MakeItems(this SaveFile that)
        {
            var Items = new List<Item>();
            if (that.IsItemMode())
            {
                int count = that.Properties.Count;
                for (int i = count - 1; i >= 0; i--)
                {
                    var gv = that.Properties[i];
                    if (gv.Name.StartsWith("xy"))
                    {
                        Item temp = new Item(that);
                        temp.SetPosition(gv);
                        temp.SetName(that.Get("name"+ temp.ID));
                        temp.SetPrefix(that.Get("prefix"+temp.ID));
                        temp.SetSurfix(that.Get("surfix" + temp.ID));
                        Items.Add(temp);
                    }
                }
            }
            return Items;
        }
        #endregion

        #region type
        public static bool IsIntType(this SaveProperty that)
        {
            return that.Value.Type == SaveValueType.Int32;
        }
        public static bool IsStringType(this SaveProperty that)
        {
            return that.Value.Type == SaveValueType.String;
        }
        public static bool IsVector3Type(this SaveProperty that)
        {
            return that.Value.Type == SaveValueType.Vector3;
        }
        public static bool IsVector2Type(this SaveProperty that)
        {
            return that.Value.Type == SaveValueType.Vector2;
        }

        public static bool IsIntArrayType(this SaveProperty that)
        {
            return that.Value.Type == SaveValueType.Array && ((ArrayValue)that.Value).ItemType == SaveValueType.Int32;
        }
        public static bool IsStringArrayType(this SaveProperty that)
        {
            return that.Value.Type == SaveValueType.Array && ((ArrayValue)that.Value).ItemType == SaveValueType.String;
        }
        public static bool IsBoolType(this SaveProperty that)
        {
            return that.Value.Type == SaveValueType.Bool;
        }
        public static bool IsFloatType(this SaveProperty that)
        {
            return that.Value.Type == SaveValueType.Single;
        }
        public static Vector2 GetVector2Value(this SaveProperty that)
        {

            if (that.IsVector2Type())
            {
                return ((Vector2Value)that.Value).TypedData;
            }
            return null;
        }
        public static void SetVector2Value(this SaveProperty that, Vector2 val)
        {
            if (that.IsVector2Type())
            {
                ((Vector2Value)that.Value).TypedData = val;
            }
        }
        public static Vector3 GetVector3Value(this SaveProperty that)
        {

            if (that.IsVector3Type())
            {
                return ((Vector3Value)that.Value).TypedData;
            }
            return null;
        }
        public static void SetVector3Value(this SaveProperty that, Vector3 val)
        {
            if (that.IsVector3Type())
            {
                ((Vector3Value)that.Value).TypedData = val;
            }
        }
        public static bool GetBoolValue(this SaveProperty that, bool def = false)
        {

            if (that.IsBoolType())
            {
                return ((BoolValue)that.Value).TypedData;
            }
            return def;
        }

        public static void SetBoolValue(this SaveProperty that, bool val)
        {
            if (that.IsBoolType())
            {
                ((BoolValue)that.Value).TypedData = val;
            }
        }

        public static int GetInt32Value(this SaveProperty that, int def = 0)
        {

            if (that.IsIntType())
            {
                return ((Int32Value)that.Value).TypedData;
            }
            return def;
        }

        public static void SetInt32Value(this SaveProperty that, int val)
        {
            if (that.IsIntType())
            {
                ((Int32Value)that.Value).TypedData = val;
            }
        }
        public static float GetSingleValue(this SaveProperty that, float def = 0)
        {

            if (that.IsFloatType())
            {
                return ((SingleValue)that.Value).TypedData;
            }
            return def;
        }

        public static void SetSingleValue(this SaveProperty that, float val)
        {
            if (that.IsFloatType())
            {
                ((SingleValue)that.Value).TypedData = val;
            }
        }
        public static string GetStringValue(this SaveProperty that, string def = null)
        {

            if (that.IsStringType())
            {
                return ((StringValue)that.Value).TypedData;
            }
            return def;
        }
        public static void SetStringValue(this SaveProperty that, string val)
        {
            if (that.IsStringType())
            {
                ((StringValue)that.Value).TypedData = val;
            }
        }
        public static int[] GetIntArray(this SaveProperty that)
        {

            if (that.IsIntArrayType())
            {
                var arr = (ArrayValue)that.Value;
                int N = arr.Count;
                int[] ret = new int[N];
                for (int i = 0; i < N; i++)
                {
                    ret[i] = ((Int32Value)arr[i]).TypedData;
                }
                return ret;
            }
            return null;
        }

        public static void SetIntArray(this SaveProperty that, int[] val)
        {

            if (that.IsIntArrayType())
            {
                var arr = (ArrayValue)that.Value;
                arr.ClearItems();
                if (val != null)
                {
                    int N = val.Length;
                    for (int i = 0; i < N; i++)
                    {
                        var v = (Int32Value)SaveValue.Create(SaveValueType.Int32);
                        v.TypedData = val[i];
                        arr.AddItem(v);
                    }
                }
            }
        }
        public static string[] GetStringArray(this SaveProperty that)
        {

            if (that.IsStringArrayType())
            {
                var arr = (ArrayValue)that.Value;
                int N = arr.Count;
                string[] ret = new string[N];
                for (int i = 0; i < N; i++)
                {
                    ret[i] = ((StringValue)arr[i]).TypedData;
                }
                return ret;
            }
            return null;
        }

        public static void SetStringArray(this SaveProperty that, string[] val)
        {

            if (that.IsStringArrayType())
            {
                var arr = (ArrayValue)that.Value;
                arr.ClearItems();
                if (val != null)
                {
                    int N = val.Length;
                    for (int i = 0; i < N; i++)
                    {
                        var v = (StringValue)SaveValue.Create(SaveValueType.String);
                        v.TypedData = val[i];
                        arr.AddItem(v);
                    }
                }
            }
        }
        #endregion
    }
}
