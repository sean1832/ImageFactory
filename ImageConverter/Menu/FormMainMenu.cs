
using System.Reflection;
using ImageMagick;

namespace ImageConverter
{
    public partial class FormMainMenu : Form
    {
        // field
        private Button _currentButton;
        private Form _activeForm;

        public FormMainMenu()
        {
            InitializeComponent();

            Version();
        }

        // =========================== custom function ===========================
        private void Version()
        {
            string version = @"1.0.0.6";

            labelVersion.Text = $"ver {version}";
        }

        private Color TranslateColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                // if current button is not highlighted yet
                if (_currentButton != (Button)btnSender)
                {
                    DisableButton();
                    // highlight current button
                    Color color = TranslateColor("#537180");
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = color;
                    _currentButton.ForeColor = Color.White;

                }
            }
        }

        private void DisableButton()
        {
            // for each button controls in panelMenu
            foreach (Control previousBtn in panelMenu.Controls)
            {
                // if control type is button
                if (previousBtn.GetType() == typeof(Button))
                {
                    // return default color
                    previousBtn.ForeColor = Color.FromArgb(236, 240, 241);
                    previousBtn.BackColor = Color.FromArgb(65, 64, 66);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelWorkspace.Controls.Add(childForm);
            this.panelWorkspace.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // =========================== custom function ===========================
        private void buttonFolder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFolder(), sender);
        }

    }
}