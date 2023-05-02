using CPProject.components.EditableReview;
using CPProject.components.EditableReviewCollection;
using CPProject.DataBaseModel.entities;

namespace CPProject.components.ReviewCollection
{
    public partial class CustomerReview : UserControl
    {
        private EditableReviewState editableReviewState;
        private Review? review;
        private string userName = "UserName";
        public EditableReviewState EditableReviewState
        {
            get => editableReviewState;
            set { editableReviewState = value; onStateChange(EditableReviewState); }
        }
        public Func<int, string, Review?>? SaveReview { get; set; }
        public Func<bool>? DeleteReview { get; set; }
        public string UserName { get => userName; set { userName = value; OnChangeUserName(); } }
        public Review? Review
        {
            get => review;
            set { review = value; onSetReview(Review); }
        }

        public CustomerReview()
        {
            InitializeComponent();
            EditableReviewState = EditableReviewState.Default;
        }

        private void onSetReview(Review? currentReview)
        {
            if (currentReview != null)
            {
                EditableReviewState = EditableReviewState.Previewing;
            }
            else
            {
                EditableReviewState = EditableReviewState.Default;
            }
        }

        private Review? onReviewSave(int score, string description)
        {
            Review? result = SaveReview?.Invoke(score, description) ?? null;
            Review = result;
            return result;
        }

        private void onReviewEdit()
        {
            onStateChange(EditableReviewState.Editing);
        }

        private void onReviewDelete()
        {
            if (DeleteReview?.Invoke() ?? false)
            {
                onStateChange(EditableReviewState.Default);
            }
        }

        private void onEditCancel()
        {
            EditableReviewState = EditableReviewState.Previewing;
        }

        private void onStateChange(EditableReviewState currentEditableReviewState)
        {
            this.Controls.Clear();
            if (currentEditableReviewState == EditableReviewState.Default)
            {
                DefaultEditableReview defaultEditableReview = new DefaultEditableReview(onReviewSave, UserName);
                setContent(defaultEditableReview);
            }
            if (currentEditableReviewState == EditableReviewState.Previewing)
            {
                PreviewEditableReview editableReviewPreview = new PreviewEditableReview(onReviewEdit, onReviewDelete, Review, UserName);
                setContent(editableReviewPreview);
            }
            if (currentEditableReviewState == EditableReviewState.Editing)
            {
                EditEditableReview editEditableReview = new EditEditableReview(onReviewSave, onEditCancel, UserName, Review);
                setContent(editEditableReview);
            }
        }

        private void setContent(UserControl userControl)
        {
            userControl.Dock = DockStyle.Top;
            this.Controls.Add(userControl);
        }

        private void OnChangeUserName()
        {
            switch (this.Controls[0])
            {
                case DefaultEditableReview:
                    ((DefaultEditableReview)this.Controls[0]).UserName = UserName;
                    break;
                case PreviewEditableReview:
                    ((PreviewEditableReview)this.Controls[0]).UserName = UserName;
                    break;
                case EditEditableReview:
                    ((EditEditableReview)this.Controls[0]).UserName = UserName;
                    break;
            }
        }
    }
}
