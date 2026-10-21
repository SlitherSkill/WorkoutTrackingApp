using System.Drawing.Drawing2D;


namespace WorkoutTrackingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RoundButton(buttonDashboard, 10);
            RoundButton(buttonWorkoutPlan, 10);
            RoundButton(buttonExercises, 10);
            RoundButton(buttonProgress, 10);
            RoundButton(buttonSettings, 10);

            buttonDashboard.Click += (s, e) => SelectButton(buttonDashboard);
            buttonWorkoutPlan.Click += (s, e) => SelectButton(buttonWorkoutPlan);
            buttonExercises.Click += (s, e) => SelectButton(buttonExercises);
            buttonProgress.Click += (s, e) => SelectButton(buttonProgress);
            buttonSettings.Click += (s, e) => SelectButton(buttonSettings);
        }
        private void RoundButton(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            path.AddArc(0, 0, diameter, diameter, 180, 90);
            path.AddArc(button.Width - diameter, 0, diameter, diameter, 270, 90);
            path.AddArc(button.Width - diameter,
                        button.Height - diameter,
                        diameter, diameter, 0, 90);
            path.AddArc(0, button.Height - diameter,
                        diameter, diameter, 90, 90);

            path.CloseFigure();

            button.Region = new Region(path);
        }

        private void SelectButton(Button selectedButton)
        {
            Button[] buttons =
            {
                buttonDashboard,
                buttonWorkoutPlan,
                buttonExercises,
                buttonProgress,
                buttonSettings
            };

            foreach(Button button in buttons)
                button.BackColor = Color.FromArgb(23, 24, 29);
            
            selectedButton.BackColor = Color.FromArgb(52, 54, 64);
        }
    }
}
