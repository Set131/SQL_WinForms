using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        DataClasses_booksDataContext dc;
        public Form1()
        {
            InitializeComponent();

            dc = new DataClasses_booksDataContext();

            LoadData();
        }
        private void LoadData()
        {
            var query = from c in dc.books_new
                        select new
                        {
                            c.N,
                            c.Code,
                            c.New,
                            c.Name,
                            c.Price,
                            c.Pages,
                            c.Date,
                            c.Pressrun,
                            c.Spr_format.Format,
                            c.Spr_izd.Izd,
                            c.Spr_kategory.Category,
                            c.Spr_themes.Themes
                        };

            dataGridView1.DataSource = query.ToList();
        }
        private void btnFilter_Click(object sender, System.EventArgs e)
        {
            string category = txtCategory.Text.Trim();
            string theme = txtTheme.Text.Trim();
            string format = txtFormat.Text.Trim();
            string publisher = txtPublisher.Text.Trim();

            var query = from c in dc.books_new
                        select new
                        {
                            c.N,
                            c.Code,
                            c.New,
                            c.Name,
                            c.Price,
                            c.Pages,
                            c.Date,
                            c.Pressrun,
                            c.Spr_format.Format,
                            c.Spr_izd.Izd,
                            c.Spr_kategory.Category,
                            c.Spr_themes.Themes
                        };

            if (!string.IsNullOrEmpty(category))
                query = query.Where(c => c.Category.Contains(category));

            if (!string.IsNullOrEmpty(theme))
                query = query.Where(c => c.Themes.Contains(theme));

            if (!string.IsNullOrEmpty(format))
                query = query.Where(c => c.Format.Contains(format));

            if (!string.IsNullOrEmpty(publisher))
                query = query.Where(c => c.Izd.Contains(publisher));

            dataGridView1.DataSource = query.ToList();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }
    }
}