using System.Windows.Forms;


namespace WindowsFormsSample1
{
    /// <summary>
    /// AdvancedButton
    /// </summary>
    public class AdvancedButton : Button
    {
        public AdvancedButton()
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.Opaque, false);

            InitializeComponent();
        }

        private Label m_labelDescription;

        private void InitializeComponent()
        {
            this.m_labelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_labelDescription
            // 
            this.m_labelDescription.Location = new System.Drawing.Point(0, 0);
            this.m_labelDescription.Name = "m_labelDescription";
            this.m_labelDescription.Size = new System.Drawing.Size(0, 0);
            this.m_labelDescription.TabIndex = 0;
            this.m_labelDescription.Visible = false;
            // 
            // AdvancedButton
            // 
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(this.m_labelDescription);
            this.Size = new System.Drawing.Size(112, 32);
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Unique id
        /// </summary>
        public string Id
        {
            get
            {
                return m_buttonId;
            }
            set
            {
                m_buttonId = value;
            }
        }

        private string m_buttonId;

        /// <summary>
        /// Description for ToolTip
        /// </summary>
        public string Description
        {
            get
            {
                return m_labelDescription.Text;
            }
            set
            {
                m_labelDescription.Text = value;
            }
        }

    }
}
