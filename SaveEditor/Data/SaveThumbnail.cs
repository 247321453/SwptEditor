using SwptSaveLib;

namespace SaveEditor
{
    public class SaveThumbnail
    {
        public long ID;
        public string Path;
        public string Name = null;
        public SaveThumbnail(string path)
        {
            Path = path;
            var save = SaveFile.Load(path);
            if (save != null)
            {
                var tag_name = save.Get("playerName");
                if (tag_name != null)
                {
                    var tag_level = save.Get("playerLevel");
                    string title = tag_name.GetStringValue();
                    if (tag_level != null)
                    {
                        title += " [" + tag_level.GetInt32Value() + "]";
                    }
                    Name = title;
                }
            }
        }

        public bool IsVaild()
        {
            return Name != null;
        }

        public override string ToString()
        {
            return Name;
        }

        public static long GetSaveID(string name)
        {
            long id;
            if (long.TryParse(name, out id))
            {
                return id;
            }
            return 0;
        }
    }
}
