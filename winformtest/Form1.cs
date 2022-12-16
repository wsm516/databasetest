using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformtest
{
    public partial class Form1 : Form
    {

        public Form1()
        {

           InitializeComponent();

            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=health_program;Uid=root;Pwd=50797890"))
            {
                string insertQuery = "INSERT INTO new_table(id,name,number) VALUES(145,'name1',2)";
                try//예외 처리
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("인서트 성공");
                    }
                    else
                    {
                        Console.WriteLine("인서트 실패");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }

            }

        }
    }
    
}
