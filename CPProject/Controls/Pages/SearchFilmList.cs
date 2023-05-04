using CPProject.components;
using CPProject.Controls.ControlHandlers;
using CPProject.Controls.Pages;
using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.helpers;
using CPProject.User;

namespace CPProject.Controls
{
    public partial class SearchFilmList : UserControl, IDisposable
    {
        private static CinemaDataBase? DBInstance = null;
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
        private const int CountFilmLoad = 7;
        private List<Film> filmCollection;
        private string searchValue = "";
        private System.Windows.Forms.Label labelEndFilmList;
        private int FilterSelectedIndex
        {
            get => filterSelectedIndex;
            set
            {
                if (FilterSelectedIndex != value)
                {
                    filterSelectedIndex = value;
                    OnFilterIndexChange(FilterSelectedIndex);
                }
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

        private ElementListScrollEnd elementListScrollEnd;
        public SearchFilmList()
        {
            InitializeComponent();
            InitializeComboBoxGenre();
            Dock = DockStyle.Fill;
            filmCollection = new List<Film>();
            initializeLabelEndFilmList();
            elementListScrollEnd = new ElementListScrollEnd(flowLayoutPanelFilms, addMoreFilms);
        }

        private void InitializeComboBoxGenre()
        {
            FilterSelectedIndex = 0;
            customComboBoxFilmGenre.Items.Add("All genres");
            customComboBoxFilmGenre.Items.AddRange(Enum.GetValues(typeof(FilmGenre)).Cast<object>().ToArray());
            customComboBoxFilmGenre.SelectedIndex = 0;
        }

        private void OnFilterIndexChange(int filterIndex)
        {
            CleanFilmList();
        }

        private static void GCCleanMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void initializeLabelEndFilmList()
        {
            labelEndFilmList = new System.Windows.Forms.Label();
            labelEndFilmList.AutoSize = false;
            labelEndFilmList.Text = "There is nothing more :(";
            labelEndFilmList.TextAlign = ContentAlignment.MiddleCenter;
            labelEndFilmList.Width = flowLayoutPanelFilms.Width;
            labelEndFilmList.Font = new Font("Segoe UI", 14);
            labelEndFilmList.ForeColor = Color.Gray;
            labelEndFilmList.Margin = new Padding(0, 20, 0, 40);
            flowLayoutPanelFilms.Resize += OnResizeFlowLayoutPanel;
        }

        private void OnResizeFlowLayoutPanel(object? sender, EventArgs e)
        {
            flowLayoutPanelFilms.Controls.Remove(labelEndFilmList);
            labelEndFilmList.Width = flowLayoutPanelFilms.ClientSize.Width;
        }

        Debouncer debouncerSearchUpdate = new Debouncer(300);
        private int filterSelectedIndex;

        private void onSearchValueChanged(string oldValue, string newValue)
        {
            debouncerSearchUpdate.Debounce(() =>
            {
                if (oldValue == newValue)
                {
                    return;
                }

                flowLayoutPanelFilms.Invoke((MethodInvoker)delegate
                {
                    CleanFilmList();
                });
            });
        }

        private void CleanFilmList()
        {
            flowLayoutPanelFilms.Controls.Clear();
            filmCollection.Clear();
            addMoreFilms();
            GCCleanMemory();
        }

        private void SearchFilmList_Load(object sender, EventArgs e)
        {
            addMoreFilms();
            createFilmButtonShower(AccountHandler.Instance.UserType);
        }

        private void addMoreFilms()
        {
            var nextFilmCollection = String.IsNullOrEmpty(SearchValue)
                ? customComboBoxFilmGenre.SelectedIndex == 0
                    ? DataBase.FilmCollection.OrderByDescending(item => item.ReleaseDate)
                        .Skip(filmCollection.Count)
                        .Take(CountFilmLoad)
                    : DataBase.FilmCollection.Where(item => item.Genre == (FilmGenre)customComboBoxFilmGenre.SelectedItem)
                        .OrderByDescending(item => item.ReleaseDate)
                        .Skip(filmCollection.Count)
                        .Take(CountFilmLoad)
                : customComboBoxFilmGenre.SelectedIndex == 0
                    ? DataBase.FilmCollection.Where(item => item.Title.IndexOf(SearchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                        .Skip(filmCollection.Count)
                        .Take(CountFilmLoad)
                    : DataBase.FilmCollection.Where(item => item.Title.IndexOf(SearchValue, StringComparison.OrdinalIgnoreCase) >= 0 && item.Genre == (FilmGenre)customComboBoxFilmGenre.SelectedItem)
                        .OrderByDescending(item => item.ReleaseDate)
                        .Skip(filmCollection.Count)
                        .Take(CountFilmLoad);

            if (!nextFilmCollection.Any())
            {
                flowLayoutPanelFilms.Controls.Add(labelEndFilmList);
                return;
            }

            flowLayoutPanelFilms.Controls.Remove(labelEndFilmList);
            addFilmsToFlowLayoutPanel(nextFilmCollection);
        }

        private void addFilmsToFlowLayoutPanel(IEnumerable<Film> nextFilmCollection)
        {
            foreach (Film film in nextFilmCollection)
            {
                FilmPreviewCard card = new FilmPreviewCard(() =>
                {
                    FilmPage fp = new FilmPage(film, updateFilm); setNewPage(fp);
                }, film);
                card.Margin = new Padding(5, 5, 5, 5);
                filmCollection.Add(film);
                flowLayoutPanelFilms.Controls.Add(card);
            }
        }

        private void insertFilm(Film film)
        {
            FilmPage filmPage;
            FilmPreviewCard card = new FilmPreviewCard(() =>
            {
                filmPage = new FilmPage(film, updateFilm); setNewPage(filmPage);
            }, film);
            card.Margin = new Padding(5, 5, 5, 5);
            filmCollection.Add(film);
            flowLayoutPanelFilms.Controls.Add(card);
        }

        private void OnFilmUpdated(Film film, FilmPreviewCard card)
        {
            card.Film = film;
            card.OnClick = () =>
            {
                FilmPage fp = new FilmPage(film, updateFilm); setNewPage(fp);
            };
        }

        private void updateFilm(Film film)
        {
            foreach (Control control in flowLayoutPanelFilms.Controls)
            {
                FilmPreviewCard? card = control as FilmPreviewCard;
                if (card == null)
                {
                    continue;
                }
                if (card?.Film?.Id == film.Id)
                {
                    OnFilmUpdated(film, card);
                }
            }
        }

        private void createFilmButtonShower(UserType? s)
        {
            if (s == UserType.Admin)
            {
                roundedButtonCreateFilm.Visible = true;
            }
            else
            {
                roundedButtonCreateFilm.Visible = false;
            }
        }

        private void setNewPage(UserControl page)
        {
            this.Hide();

            page.Dock = DockStyle.Fill;
            Panel? parentPanel = (Panel?)this.Parent;
            if (parentPanel != null)
            {
                parentPanel.Controls.Add(page);
            }
            GCCleanMemory();
        }

        private void OnFilmUpdated(Film film)
        {
            insertFilm(film);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            CreateFilmPage createFilmPage = new CreateFilmPage(onFilmCreated: OnFilmUpdated);
            setNewPage(createFilmPage);
        }

        private void roundedSearchField2__TextChanged(object sender, EventArgs e)
        {
            string text = roundedSearchField2.Texts;
            SearchValue = text;
        }

        private void customComboBoxFilmGenre_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSelectedIndex = customComboBoxFilmGenre.SelectedIndex;
        }
    }
}
