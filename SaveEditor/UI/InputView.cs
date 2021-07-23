using SwptSaveLib;
using System.Windows.Forms;

namespace SaveEditor.UI
{
    public partial class InputView : UserControl, IInputView
    {
        private SaveProperty Value;
        public InputView()
        {
            InitializeComponent();
        }
        public virtual Control GetControl()
        {
            return this;
        }
        public virtual void Init(SaveProperty value = null, Item item = null)
        {
            if (value != null)
            {
                this.Value = value;
            }
        }

        public virtual void UpdateUI()
        {
            var gv = this.Value;
            if (gv != null)
            {
                lb_display_name.Text = gv.GetDisplayName();
                if (lb_display_name.Text != gv.Name)
                {
                    lb_name.Text = gv.Name;
                }
                else
                {
                    lb_name.Text = "";
                }
                if (gv.Name.StartsWith("xy"))
                {
                    tb_input.ReadOnly = true;
                }
                if (gv.IsIntType())
                {
                    tb_input.Text = "" + gv.GetInt32Value();
                }
                else if (gv.IsStringType())
                {
                    tb_input.Text = gv.GetStringValue();
                }
                else if (gv.IsFloatType())
                {
                    tb_input.Text = "" + gv.GetSingleValue();
                }
                else if (gv.IsStringArrayType())
                {
                    tb_input.Text = string.Join("|", gv.GetStringArray());
                }
                else if (gv.IsIntArrayType())
                {
                    tb_input.Text = string.Join(", ", gv.GetIntArray());
                }
                else if (gv.IsBoolType())
                {
                    tb_input.Text = gv.GetBoolValue() ? "1" : "0";
                }
                else if (gv.IsVector2Type())
                {
                    var size = gv.GetVector2Value();
                    tb_input.Text = (int)size.X + ", " + (int)size.Y;
                    tb_input.ReadOnly = true;
                }
                else if (gv.IsVector3Type())
                {
                    var size = gv.GetVector3Value();
                    tb_input.Text = (int)size.X + ", " + (int)size.Y + ", " + (int)size.Z;
                    tb_input.ReadOnly = true;
                }
                else
                {
                    tb_input.Text = gv.ToString();
                    tb_input.ReadOnly = true;
                }
            }
        }

        public virtual void SaveValues()
        {
            try
            {
                var gv = this.Value;
                if (gv != null)
                {
                    if (gv.IsIntType())
                    {

                        gv.SetInt32Value(int.Parse(tb_input.Text.Trim()));
                    }
                    else if (gv.IsStringType())
                    {
                        gv.SetStringValue(tb_input.Text);
                    }
                    else if (gv.IsFloatType())
                    {
                        gv.SetSingleValue(float.Parse(tb_input.Text.Trim()));
                    }
                    else if (gv.IsStringArrayType())
                    {
                        string[] arr = tb_input.Text.Split('|');
                        if (string.IsNullOrEmpty(tb_input.Text.Trim()))
                        {
                            gv.SetStringArray(null);
                        }
                        else
                        {
                            gv.SetStringArray(arr);
                        }
                    }
                    else if (gv.IsIntArrayType())
                    {
                        if (string.IsNullOrEmpty(tb_input.Text.Trim()))
                        {
                            gv.SetIntArray(null);
                        }
                        else
                        {
                            string[] arr = tb_input.Text.Split(',');
                            int[] i_arr = new int[arr.Length];
                            for (int i = 0; i < arr.Length; i++)
                            {
                                i_arr[i] = int.Parse(arr[i].Trim());
                            }
                            gv.SetIntArray(i_arr);
                        }
                    }
                    else if (gv.IsVector2Type())
                    {
                        string[] arr = tb_input.Text.Split(',');
                        float[] i_arr = new float[2];
                        for (int i = 0; i < i_arr.Length; i++)
                        {
                            i_arr[i] = float.Parse(arr[i]);
                        }
                        gv.SetVector2Value(new Vector2(i_arr[0], i_arr[1]));
                    }
                    else if (gv.IsVector3Type())
                    {
                        string[] arr = tb_input.Text.Split(',');
                        float[] i_arr = new float[3];
                        for (int i = 0; i < i_arr.Length; i++)
                        {
                            i_arr[i] = float.Parse(arr[i]);
                        }
                        gv.SetVector3Value(new Vector3(i_arr[0], i_arr[1], i_arr[2]));
                    }
                    else if (gv.IsBoolType())
                    {
                        gv.SetBoolValue(tb_input.Text.Trim() == "1");
                    }
                    else
                    {
                        //nothing
                    }
                }
            }
            catch { }
        }
    }
}
