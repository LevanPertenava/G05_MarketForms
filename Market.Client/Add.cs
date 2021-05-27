using Market.Models;
using Market.Repository;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Market.Repository.Extensions;
using Market.Client.ExtensionMethodForms;


namespace Market.Client
{
    public partial class Add<T> : Form where T : class, new()
    {
        private IListForm _listForm;
        private T _model;
        private static Button _upload;
        private static PictureBox _pictureBox;
        public Add(IListForm form)
        {
            InitializeComponent();
            _listForm = form;
            _model = new();
        }
        private void Add_Load(object sender, EventArgs e)
        {
            if (_model.HasProperty("Photo"))
            {
                this.Controls.Add(new Label() { Location = new Point(360, 41), Text = "Photo", Font = new Font("Malgun Gothic", 12), Size = new Size(70, 28) });
                this.Controls.Add(_pictureBox = new PictureBox() { Location = new Point(469, 43), SizeMode = PictureBoxSizeMode.StretchImage, Visible = true, BorderStyle = BorderStyle.FixedSingle, Size = new Size(169, 181) });
                this.Controls.Add(_upload = new Button() { Location = new Point(469, 232), Name = "btnUpload", Text = "Upload", Size = new Size(130, 31), BackColor = SystemColors.ActiveCaption });
                _upload.Click += btnUpload_Click;
            }
            ExtensionMethodsForms.CreateForm(_model.GetType().GetProperties(), this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var repository = _model.GetType().Name.GetRepositoryType().CreateRepositoryInstance(@"server = DESKTOP-V7759FH\SQLEXPRESS;database=Market;integrated security=true");
            var properties = _model.GetType().GetProperties();
            T[] parameters = new T[1] { _model };

            properties.InsertTextBoxesIntoProperties(this, _model);
            repository.GetType().GetMethod("Insert").Invoke(repository, parameters);
            _listForm.Reload();
            Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                _pictureBox.Image = new Bitmap(opnfd.FileName);
                var byteArray = _pictureBox.Image.ImageToByteArray();
                var photoProperty = _model.GetType().GetProperty("Photo");
                photoProperty.SetValue(_model, byteArray);
            }
        }


    }
}
