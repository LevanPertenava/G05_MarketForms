using Market.Models;
using Market.Repository;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using Market.Repository.Extensions;
using Market.Client.ExtensionMethodForms;

namespace Market.Client
{
    public partial class Edit<T> : Form where T : class, new()
    {
        private object _repository;
        private IListForm _iListForm;
        private T _model;
        private readonly int _Id;
        private static Button _upload;
        private static PictureBox _pictureBox;

        public Edit(IListForm form, int Id)
        {
            InitializeComponent();
            _Id = Id;
            _iListForm = form;
            _model = new();
            _repository = _model.GetType().Name.GetRepositoryType().CreateRepositoryInstance(@"server = DESKTOP-V7759FH\SQLEXPRESS;database=Market;integrated security=true");
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            var getModel = _repository.GetType().GetMethod("Get").Invoke(_repository, new object[1] { _Id });
            _model = getModel as T;

            if (_model.HasProperty("Photo"))
            {
                this.Controls.Add(new Label() { Location = new Point(360, 41), Text = "Photo", Font = new Font("Malgun Gothic", 12), Size = new Size(70, 28) });
                this.Controls.Add(_pictureBox = new PictureBox() { Location = new Point(469, 43), SizeMode = PictureBoxSizeMode.StretchImage, Visible = true, BorderStyle = BorderStyle.FixedSingle, Size = new Size(169, 181) });
                this.Controls.Add(_upload = new Button() { Location = new Point(469, 232), Name = "btnUpload", Text = "Upload", Size = new Size(130, 31), BackColor = SystemColors.ActiveCaption });
                _upload.Click += btnUpload_Click;

                var photoProperty = _model.GetType().GetProperty("Photo");
                byte[] content = photoProperty.GetValue(_model) as byte[];
                if (content is not null)
                    _pictureBox.Image = content.ConvertByteArrayToImage();
            }
            ExtensionMethodsForms.CreateForm(_model.GetType().GetProperties(), this);

            var properties = _model.GetType().GetProperties();
            properties.InsertPropertiesIntoTextBoxes(this, _model);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var properties = _model.GetType().GetProperties();
            T[] parameters = new T[1] { _model };

            properties.InsertTextBoxesIntoProperties(this, _model);
            _repository.GetType().GetMethod("Update").Invoke(_repository, parameters);
            _iListForm.Reload();
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
