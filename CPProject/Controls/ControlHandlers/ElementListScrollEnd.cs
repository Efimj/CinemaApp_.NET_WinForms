namespace CPProject.Controls.ControlHandlers
{
    public class ElementListScrollEnd
    {
        private UserControl? currentUserControl = null;
        public ElementListScrollEnd(UserControl currentControl, Action? addMoreElements = null)
        {
            this.currentUserControl = currentControl;
            currentControl.MouseWheel += FilmPagePreview_Scroll;
            currentControl.Scroll += FilmPagePreview_Scroll;
            AddMoreElements = addMoreElements;
            scrollTimer.Tick += new EventHandler(OnScrollTimerTick);
        }
        private FlowLayoutPanel? currentFlowLayoutPanel = null;
        public ElementListScrollEnd(FlowLayoutPanel currentControl, Action? addMoreElements = null)
        {
            this.currentFlowLayoutPanel = currentControl;
            currentFlowLayoutPanel.MouseWheel += FilmPagePreview_Scroll;
            currentFlowLayoutPanel.Scroll += FilmPagePreview_Scroll;
            AddMoreElements = addMoreElements;
            scrollTimer.Tick += new EventHandler(OnScrollTimerTick);
        }

        private System.Windows.Forms.Timer scrollTimer = new System.Windows.Forms.Timer();
        private bool IsTimerChecking { get; set; } = false;
        public int TimerDelay { get; set; } = 200;

        public Action? AddMoreElements { get; set; }

        private void OnScrollTimerTick(object? sender, EventArgs e)
        {
            scrollTimer.Stop();
            IsTimerChecking = false;
            if (currentUserControl != null)
            {
                if (currentUserControl.VerticalScroll.Value >= currentUserControl.VerticalScroll.Maximum - currentUserControl.Height - 150)
                {
                    AddMoreElements?.Invoke();
                }
            }
            if (currentFlowLayoutPanel != null)
            {
                if (currentFlowLayoutPanel.VerticalScroll.Value >= currentFlowLayoutPanel.VerticalScroll.Maximum - currentFlowLayoutPanel.Height - 150)
                {
                    AddMoreElements?.Invoke();
                }
            }
        }

        private void FilmPagePreview_Scroll(object? sender, MouseEventArgs e)
        {
            checkAddMoreElements();
        }

        private void FilmPagePreview_Scroll(object? sender, ScrollEventArgs e)
        {
            checkAddMoreElements();
        }

        private void checkAddMoreElements()
        {
            if (!IsTimerChecking)
            {
                IsTimerChecking = true;
                scrollTimer.Interval = TimerDelay;
                scrollTimer.Start();
            }
        }

        public void Dispose()
        {
            AddMoreElements = null;
            if (currentUserControl != null)
            {
                currentUserControl.MouseWheel -= FilmPagePreview_Scroll;
                currentUserControl.Scroll -= FilmPagePreview_Scroll;
            }
            if (currentFlowLayoutPanel != null)
            {
                currentFlowLayoutPanel.MouseWheel -= FilmPagePreview_Scroll;
                currentFlowLayoutPanel.Scroll -= FilmPagePreview_Scroll;
            }
            scrollTimer.Stop();
            scrollTimer.Dispose();
        }
    }
}
