using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;
using System.IO;
using Market.Client;
using static System.Windows.Forms.Form;

namespace Market.Client.ExtensionMethodForms
{
    internal static class ExtensionMethodsForms
    {
        //komentari
        internal static void InsertTextBoxesIntoProperties<T>(this PropertyInfo[] properties, Form form, T model) where T : class, new()
        {
            foreach (var property in properties)
            {
                foreach (var control in form.Controls)
                {
                    if (control is TextBox && (control as TextBox).Name.Remove(0, 3) == property.Name)
                    {
                        string text = (control as TextBox).Text;
                        if (property.PropertyType != typeof(string))
                        {
                            property.SetValue(model, Convert.ChangeType(text, property.PropertyType));
                        }
                        else
                        {
                            property.SetValue(model, text);
                        }
                    }
                }
            }
        }

        internal static void InsertPropertiesIntoTextBoxes<T>(this PropertyInfo[] properties, Form form, T model) where T : class, new()
        {
            foreach (var property in properties)
            {
                foreach (var control in form.Controls)
                {
                    if (control is TextBox && (control as TextBox).Name.Remove(0, 3) == property.Name)
                    {
                        var propertyInfo = property.GetValue(model);
                        (control as TextBox).Text = propertyInfo.ToString();
                    }
                }
            }
        }

        internal static Image ConvertByteArrayToImage(this byte[] image)
        {
            using (MemoryStream memoryStream = new(image))
            {
                return Image.FromStream(memoryStream);
            }
        }

        internal static byte[] ImageToByteArray(this Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        internal static void CreateForm(this PropertyInfo[] properties, Form form)
        {
            int textY = 0;
            int labelY = 0;
            string[] propertyArray = { "ID", "Photo", "IsActive", "IsAllowed" };
            foreach (var property in properties)
            {
                if (!propertyArray.Contains(property.Name))
                {
                    form.Controls.Add(new TextBox() { Location = new Point(180, textY += 40), Name = $"txt{property.Name}" });
                    form.Controls.Add(new Label() { Location = new Point(14, labelY += 40), Text = property.Name, Name = $"lbl{property.Name}", Font = new Font("Malgun Gothic", 12), Size = new Size(115, 28) });
                }
            }
        }
    }
}
