using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.handlers;
using CPProject.DataBaseModel.types;
using CPProject.imageHandler;
using CPProject.User;
using CPProject.User.types;
using MongoDB.Bson;
using System.Drawing.Imaging;

namespace CPProject.Controls.Pages
{
    public partial class CreateFilmPage : UserControl
    {
        private Film? film;
        private string filmImagePath = "";

        private Film? Film { get => film; set => film = value; }
        private string FilmImagePath { get => filmImagePath; set => filmImagePath = value; }
        private Action<Film>? OnFilmUpdated { get; set; }
        public CreateFilmPage(Film? fiml = null, Action<Film>? onFilmCreated = null)
        {
            InitializeComponent();
            loadData(fiml, onFilmCreated);
        }

        private void loadData(Film? fiml, Action<Film>? onFilmUpdated = null)
        {
            OnFilmUpdated = onFilmUpdated;
            customComboBoxGenre.DataSource = Enum.GetValues(typeof(FilmGenre));
            customComboBoxAge.DataSource = Enum.GetValues(typeof(AgeRating));
            Film = fiml;
            if (Film != null)
            {
                roundedButtonSave.Text = "Save";
                customComboBoxGenre.SelectedIndex = (int)fiml.Genre;
                customComboBoxAge.SelectedIndex = (int)fiml.AgeRating;
                textBoxTitle.Text = fiml.Title;
                dateTimePickerRelease.Value = fiml.ReleaseDate;
                textBoxDescription.Text = fiml.Description;
                FilmImagePath = $"{image_path.Default.FilmPreviewFolder}{Film.PhotoName}";
                ImageHandler.LoadImageToPictureBox(
                    FilmImagePath,
                    pictureBox,
                    Properties.Resources.image_error
                    );
            }
        }

        private void goBack()
        {
            this.Hide();
            Panel? parentPanel = (Panel?)this.Parent;
            if (parentPanel != null)
            {
                parentPanel.Controls.Remove(this);
                parentPanel.Controls[parentPanel.Controls.Count - 1].Show();
            }
            this.DestroyHandle();
        }

        private void customRoundedButtonGoBack_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void ResizeDescriptionTextbox()
        {
            // amount of padding to add
            const int padding = 3;
            // get number of lines (first line is 0, so add 1)
            int numLines = this.textBoxDescription.GetLineFromCharIndex(this.textBoxDescription.TextLength) + 1;
            // get border thickness
            int border = this.textBoxDescription.Height - this.textBoxDescription.ClientSize.Height;
            // set height (height of one line * number of lines + spacing)
            int newHeight = (this.textBoxDescription.Font.Height * numLines) + padding + border;
            if (newHeight > 140)
            {
                this.textBoxDescription.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                this.textBoxDescription.ScrollBars = ScrollBars.None;
                this.textBoxDescription.Height = newHeight;
                this.roundedPanel4.Invalidate();
                this.roundedPanel6.Invalidate();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ResizeDescriptionTextbox();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            selectNewImage();
        }

        private void selectNewImage()
        {
            // Создание объекта диалогового окна выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Установка фильтра для выбора только изображений
            openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg";

            // Отображение диалогового окна выбора файла
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получение пути к выбранному файлу
                FilmImagePath = openFileDialog.FileName;

                // Выгрузка из памяти старого изображения
                if (pictureBox.Image != null)
                    pictureBox.Image.Dispose();

                // Загрузка выбранного изображения в переменную selectedImage
                ImageHandler.LoadImageToPictureBox(FilmImagePath, pictureBox, Properties.Resources.image_error);
            }
        }

        private void roundedButtonSave_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (textBoxTitle.Text.Length < 1)
            {
                panelTitleIndicator.BackColor = Color.IndianRed;
                label4.ForeColor = Color.IndianRed;
                isValid = false;
            }
            else
            {
                label4.ForeColor = Color.Black;
                panelTitleIndicator.BackColor = Color.FromArgb(224, 224, 224);
            }
            if (textBoxDescription.Text.Length < 1)
            {
                roundedPanel4.BorderColor = Color.IndianRed;
                isValid = false;
            }
            else
            {
                roundedPanel4.BorderColor = Color.FromArgb(224, 224, 224);
            }
            if (pictureBox.Image == null)
            {
                roundedPanelImageIndicator.BorderColor = Color.IndianRed;
                isValid = false;
            }
            else
            {
                roundedPanelImageIndicator.BorderColor = Color.White;
            }
            if (isValid)
            {
                SaveFilm(isValid);
            }
        }

        private void SaveFilm(bool isValid)
        {
            try
            {
                Admin? admin = (Admin?)AccountHandler.Instance?.User;
                if (admin == null)
                {
                    MessageBox.Show("You don't have access!");
                    return;
                }
                if (Film != null)
                {
                    SaveCreatedFilm(admin);
                }
                else
                {
                    CreateNewFilm(admin);
                    SetDefaultFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SetDefaultFields()
        {
            textBoxDescription.Text = string.Empty;
            textBoxTitle.Text = string.Empty;
            customComboBoxAge.SelectedIndex = 0;
            customComboBoxGenre.SelectedIndex = 0;
            pictureBox.Image = null;
            dateTimePickerRelease.Value = DateTime.Now;
        }

        private void CreateNewFilm(Admin? admin)
        {
            string imageName = $"{textBoxTitle.Text}_{ObjectId.GenerateNewId()}.png";
            string imagePath = $"{image_path.Default.FilmPreviewFolder}{imageName}";
            Helpers.CreateDirectories(image_path.Default.FilmPreviewFolder);
            ImageHandler.SaveImageToFile(pictureBox.Image, imagePath, ImageFormat.Png);
            Film? film = admin.createFilm(
                textBoxTitle.Text.Trim(),
                textBoxDescription.Text.Trim(),
                imageName,
                (FilmGenre)customComboBoxGenre.SelectedItem,
                dateTimePickerRelease.Value,
                (AgeRating)customComboBoxAge.SelectedItem
            );
            if (film != null)
            {
                OnFilmUpdated?.Invoke(film);
                MessageBox.Show("The film was created.");
            }
        }

        private void SaveCreatedFilm(Admin? admin)
        {
            string pathToFile = $"{image_path.Default.FilmPreviewFolder}{Film.PhotoName}";
            if (FilmImagePath != pathToFile)
            {
                Helpers.CreateDirectories(image_path.Default.FilmPreviewFolder);
                ImageHandler.SaveImageToFile(pictureBox.Image, pathToFile, ImageFormat.Png);
            }
            Film? film = admin.updateFilm(
                Film.Id,
                textBoxTitle.Text.Trim(),
                textBoxDescription.Text.Trim(),
                Film.PhotoName,
                (FilmGenre)customComboBoxGenre.SelectedItem,
                dateTimePickerRelease.Value,
                (AgeRating)customComboBoxAge.SelectedItem
                );
            if (film != null)
            {
                OnFilmUpdated?.Invoke(film);
                MessageBox.Show("The film was save.");
            }
        }
    }
}
