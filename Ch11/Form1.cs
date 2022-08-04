using MySql.Data.MySqlClient;
using Project2;

namespace Ch11
{
    public partial class User : Form
    {
        private object dataRow;

        public User()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
              
                

                // 데이터그리드뷰 데이터 공급
                dataGrid.DataSource = DBAccess.Instance.SelectUsers();


            }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 입력 데이터 저장
            string uid = txtUid.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string Age = nAge.Text;

            DBAccess.Instance.InsertUser(uid, name, hp, Age);
            MessageBox.Show("데이터가 추가 되었습니다.");
            ClearText();

        }

        private void bntSelect_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();
        }

        public void ClearText()
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";


        }

        private void dataGrid_CellClick(object sender, EventArgs e)
        {


            txtUid.Text = dataRow.Cells[0].Value.Tostring();
            txtName.Text = dataRow.Cells[1].
                
            Console.WriteLine();
        }
    }
}