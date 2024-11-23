using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Stok_Uygulaması
{
    public partial class Form1 : Form
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<UserApp> _dbSet;

        public Form1(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<UserApp>();

            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }



        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deneme = _dbSet.Where(x => x.UserName.Equals(textBox1.Text)).FirstOrDefault();
            Console.WriteLine(deneme);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
