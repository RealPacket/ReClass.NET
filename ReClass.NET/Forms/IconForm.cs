using System.Windows.Forms;

namespace ReClassNET.Forms
{
	public class IconForm : Form
	{
		public IconForm()
		{
			Icon = Properties.Resources.ReClassNet;
		}

		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // IconForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "IconForm";
            this.ResumeLayout(false);

		}
	}
}
