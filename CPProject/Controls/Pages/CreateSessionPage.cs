using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.helpers;
using CPProject.imageHandler;
using CPProject.User;
using CPProject.User.types;
using System.Diagnostics;

namespace CPProject.Controls.Pages
{
    public partial class CreateSessionPage : UserControl
    {
        private string searchValue = "";
        private static CinemaDataBase? DBInstance = null;
        private int? selectedRowIndex = null;
        private string location = "";
        private static CinemaDataBase DataBase
        {
            get
            {
                if (DBInstance == null)
                {
                    DBInstance = CinemaDataBase.Instance;
                }
                return DBInstance;
            }
        }

        public CreateSessionPage(Session? session = null)
        {
            InitializeComponent();
            Session = session;
            DataGridViewInitialize();
            MakeButtonCreateActive();
        }

        private Session? Session { get => session; set { session = value; OnSessionChange(); } }

        private int? SelectedRowIndex
        {
            get => selectedRowIndex;
            set
            {
                selectedRowIndex = value;
                ChangeSelectedRowIndex(value);
                MakeButtonCreateActive();
            }
        }

        private string SearchValue
        {
            get => searchValue;
            set
            {
                string oldValue = SearchValue;
                searchValue = value.Trim();
                onSearchValueChanged(value.Trim(), oldValue);
            }
        }

        private string Location
        {
            get => location;
            set
            {
                location = value;
                MakeButtonCreateActive();
            }
        }
        private int filmCountLoad = 7;
        private List<Film> FilmCollection = new List<Film>();

        private void OnSessionChange()
        {
            labelError.Text = string.Empty;
            if (Session == null)
            {
                dateTimePicker.MinDate = DateTime.Now.AddDays(3);
                roundedButtonCreate.Text = "Create";
            }
            else
            {
                roundedButtonCreate.Text = "Update";
                dateTimePicker.MinDate = DateTime.Now;
                textBoxLocation.Text = Session.Address;
                dateTimePicker.Value = Session.Date;
                numericUpDownTicketCount.Value = Session.TicketCount;
                numericUpDownTicketCount.Minimum = DataBase.TicketCollection.Count(item => item.SessionId == Session.Id);
                numericUpDownTicketPrice.Value = Convert.ToDecimal(Session.DefaultTicketPrice);
                Film? film = DataBase.FilmCollection.Find(item => item.Id == Session.FilmId);
                if (film != null)
                {
                    label5.Text = film.Title;
                    roundedSearchField1.Texts = film.Title;
                    SearchValue = film.Title;
                }
            }
        }

        Debouncer debouncerSearchUpdate = new Debouncer(300);
        private void onSearchValueChanged(string oldValue, string newValue)
        {
            if (!dataGridView1.IsHandleCreated)
                return;
            debouncerSearchUpdate.Debounce(() =>
            {
                if (oldValue == newValue)
                {
                    return;
                }

                dataGridView1.Invoke((MethodInvoker)delegate
                {
                    dataGridView1.Rows.Clear();
                    FilmCollection.Clear();
                    AddMoreFilms();
                    SelectedRowIndex = null;
                    ValidateSessionData();
                    GCCleanMemory();
                });
            });
        }

        private static double checkCurrentMemoryInMB()
        {
            Process currentProcess = Process.GetCurrentProcess();
            long memoryUsageBytes = currentProcess.PrivateMemorySize64;
            double memoryUsageInMegabytes = memoryUsageBytes / (1024.0 * 1024.0);
            return memoryUsageInMegabytes;
        }

        Debouncer debouncerUpdateFilmCard = new Debouncer(400);
        private void UpdateDGVCards()
        {
            if (checkCurrentMemoryInMB() > 650)
            {
                OnChangeRowVisible();
                GCCleanMemory();
            }
            else
            {
                debouncerUpdateFilmCard.Debounce(() =>
                {
                    OnChangeRowVisible();
                    GCCleanMemory();
                });
            }
        }

        private static void GCCleanMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void AddMoreFilms()
        {
            int currentCount = FilmCollection.Count;
            IEnumerable<Film>? nextFilmCollection;
            if (String.IsNullOrEmpty(SearchValue))
            {
                var sortedFilmCollection = DataBase.FilmCollection.OrderByDescending(item => item.ReleaseDate);
                nextFilmCollection = sortedFilmCollection.Skip(currentCount).Take(filmCountLoad);
            }
            else
            {
                var sortedFilmCollection = DataBase.FilmCollection.Where(item => item.Title.ToLower().Contains(SearchValue.ToLower()));
                nextFilmCollection = sortedFilmCollection.Skip(currentCount).Take(filmCountLoad);
            }

            foreach (Film film in nextFilmCollection)
            {
                FilmCollection.Add(film);
                dataGridView1.Rows.Add(
                    ImageHandler.LoadImage($"{image_path.Default.FilmPreviewFolder}{film.PhotoName}"),
                    film.Title
                    );
            }
        }

        private void DataGridViewInitialize()
        {
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.RowTemplate.Height = 65;
            dataGridView1.MouseWheel += dataGridViewWheelScroll;
            dataGridView1.Scroll += dataGridViewScroll;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private static Image loaderImage = Properties.Resources.google_loader;
        private Session? session;

        private async void dataGridViewScroll(object? sender, EventArgs e)
        {
            if (dataGridView1.DisplayedRowCount(false) + dataGridView1.FirstDisplayedScrollingRowIndex >= dataGridView1.RowCount)
            {
                AddMoreFilms();
            }
            UpdateDGVCards();
        }

        private async void dataGridViewWheelScroll(object? sender, MouseEventArgs e)
        {
            if (dataGridView1.DisplayedRowCount(false) + dataGridView1.FirstDisplayedScrollingRowIndex >= dataGridView1.RowCount)
            {
                AddMoreFilms();
            }
            UpdateDGVCards();
        }

        private void OnChangeRowVisible()
        {
            int number = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Displayed)
                {
                    row.Cells[0].Value = ImageHandler.LoadImage(
                        $"{image_path.Default.FilmPreviewFolder}{FilmCollection[number].PhotoName}");
                }
                else
                {
                    row.Cells[0].Value = loaderImage;
                }
                number++;
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

        private void roundedSearchField1__TextChanged(object sender, EventArgs e)
        {
            string text = roundedSearchField1.Texts;
            SearchValue = text;
        }

        private void ChangeSelectedRowIndex(int? value)
        {
            if (value != null)
                label5.Text = FilmCollection[(int)value].Title;
            else
                label5.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRowIndex = e.RowIndex;
                MakeButtonCreateActive();
            }
        }

        private void MakeButtonCreateActive()
        {
            if (ValidateSessionData())
                roundedButtonCreate.Enabled = true;
            else
                roundedButtonCreate.Enabled = false;
        }

        private bool ValidateSessionData()
        {
            if (Location.Length < 1)
                return false;
            if (SelectedRowIndex == null)
                return false;
            if (SelectedRowIndex > FilmCollection.Count - 1)
                return false;
            if (FilmCollection[SelectedRowIndex ?? 0].Id.Length < 1)
                return false;
            return true;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            Location = textBoxLocation.Text.Trim();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            Admin? admin = (Admin?)AccountHandler.Instance?.User;
            if (admin == null)
            {
                MessageBox.Show("You don't have access!");
                return;
            }
            if (DataBase.FilmCollection.Find(item => item.Id == FilmCollection[SelectedRowIndex ?? 0].Id) == null)
            {
                labelError.Text = "Can't find the film (";
                return;
            }
            bool result;
            if (Session == null)
            {
                result = admin.createSession(
                    FilmCollection[SelectedRowIndex ?? 0].Id,
                    Location,
                    dateTimePicker.Value,
                    Convert.ToInt32(numericUpDownTicketCount.Value),
                    Convert.ToDouble(numericUpDownTicketPrice.Value)
                    );
            }
            else
            {
                result = admin.updateSession(
                    Session.Id,
                FilmCollection[SelectedRowIndex ?? 0].Id,
                Location,
                dateTimePicker.Value,
                Convert.ToInt32(numericUpDownTicketCount.Value),
                Convert.ToDouble(numericUpDownTicketPrice.Value)
                );
            }

            if (result)
            {

                if (Session == null)
                {
                    SetDefaultFields();
                    MessageBox.Show("The session was created.");
                }
                else
                {
                    MessageBox.Show("The session was saved.");
                }
            }
            else
                labelError.Text = "Something wrong (";
        }
        private void SetDefaultFields()
        {
            numericUpDownTicketCount.Value = 1;
            numericUpDownTicketPrice.Value = 1;
            dateTimePicker.Value = DateTime.Now.AddDays(3);
            Location = "";
            textBoxLocation.Text = "";
            labelError.Text = "";
        }

        private void CreateSessionPage_Load(object sender, EventArgs e)
        {
            AddMoreFilms();
        }
    }
}
