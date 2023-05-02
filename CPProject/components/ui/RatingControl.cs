namespace CPProject.components.ui
{
    public partial class RatingControl : UserControl
    {
        static Image StarFilled = Properties.Resources.star_filled;
        static Image StarOutfilled = Properties.Resources.star_outfilled;
        public RatingControl()
        {
            InitializeComponent();
            onChangeRating += handleVisualChangeRating;
        }
        private int? currentReting;
        public int? CurrentReting
        {
            get => currentReting;
            set
            {
                currentReting = value;
                onChangeRating?.Invoke(value);
            }
        }

        private bool editable;
        public bool Editable
        {
            get => editable;
            set
            {
                editable = value;
                editableCursorHandle(editable);
            }
        }

        private void editableCursorHandle(bool isEdit)
        {
            if (isEdit)
            {
                pictureBox1.Cursor = Cursors.Hand;
                pictureBox2.Cursor = Cursors.Hand;
                pictureBox3.Cursor = Cursors.Hand;
                pictureBox4.Cursor = Cursors.Hand;
                pictureBox5.Cursor = Cursors.Hand;
            }
            else
            {
                pictureBox1.Cursor = Cursors.Default;
                pictureBox2.Cursor = Cursors.Default;
                pictureBox3.Cursor = Cursors.Default;
                pictureBox4.Cursor = Cursors.Default;
                pictureBox5.Cursor = Cursors.Default;
            }
        }

        public event Action<int?> onChangeRating;
        private void RatingControl_Load(object sender, EventArgs e)
        {
            handleVisualChangeRating(CurrentReting);
        }

        private void handleVisualChangeRating(int? rating)
        {
            if (rating == null)
            {
                handleNullRating();
            }
            if (rating == 1)
            {
                handleOneRating();
            }
            if (rating == 2)
            {
                handleTwoRating();
            }
            if (rating == 3)
            {
                handleThreeRating();
            }
            if (rating == 4)
            {
                handleFourRating();
            }
            if (rating == 5)
            {
                handleFiveRating();
            }
        }

        private void handleFiveRating()
        {
            pictureBox1.Image = StarFilled;
            pictureBox2.Image = StarFilled;
            pictureBox3.Image = StarFilled;
            pictureBox4.Image = StarFilled;
            pictureBox5.Image = StarFilled;
        }

        private void handleFourRating()
        {
            pictureBox1.Image = StarFilled;
            pictureBox2.Image = StarFilled;
            pictureBox3.Image = StarFilled;
            pictureBox4.Image = StarFilled;
            pictureBox5.Image = StarOutfilled;
        }

        private void handleThreeRating()
        {
            pictureBox1.Image = StarFilled;
            pictureBox2.Image = StarFilled;
            pictureBox3.Image = StarFilled;
            pictureBox4.Image = StarOutfilled;
            pictureBox5.Image = StarOutfilled;
        }

        private void handleTwoRating()
        {
            pictureBox1.Image = StarFilled;
            pictureBox2.Image = StarFilled;
            pictureBox3.Image = StarOutfilled;
            pictureBox4.Image = StarOutfilled;
            pictureBox5.Image = StarOutfilled;
        }

        private void handleOneRating()
        {
            pictureBox1.Image = StarFilled;
            pictureBox2.Image = StarOutfilled;
            pictureBox3.Image = StarOutfilled;
            pictureBox4.Image = StarOutfilled;
            pictureBox5.Image = StarOutfilled;
        }

        private void handleNullRating()
        {
            pictureBox1.Image = StarOutfilled;
            pictureBox2.Image = StarOutfilled;
            pictureBox3.Image = StarOutfilled;
            pictureBox4.Image = StarOutfilled;
            pictureBox5.Image = StarOutfilled;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (Editable)
            {
                handleVisualChangeRating(1);
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            if (Editable)
            {
                handleVisualChangeRating(2);
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            if (Editable)
            {
                handleVisualChangeRating(3);
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            if (Editable)
            {
                handleVisualChangeRating(4);
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            if (Editable)
            {
                handleVisualChangeRating(5);
            }
        }

        private void RatingControl_MouseLeave(object sender, EventArgs e)
        {
            if (Editable)
            {
                handleVisualChangeRating(CurrentReting);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Editable)
            {
                CurrentReting = 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Editable)
            {
                CurrentReting = 2;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Editable)
            {
                CurrentReting = 3;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Editable)
            {
                CurrentReting = 4;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Editable)
            {
                CurrentReting = 5;
            }
            //PictureBox pictureBox = (PictureBox)sender;
            //pictureBox.BackColor = Color.Green;
        }

        private void tableLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            if (Editable)
            {
                handleVisualChangeRating(CurrentReting);
            }
        }
    }
}
