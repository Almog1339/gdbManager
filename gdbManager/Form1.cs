using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace gdbManager
{
    public partial class Form1 : Form
    {
        readonly string _connStr = ConfigurationManager.ConnectionStrings["gdbManager.Properties.Settings.Setting"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            lbl_error.Text = "";
            OnloadUsersList();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            if (((Button)sender).Name == "btn_points")
            {
                path = OpenGdbDialog();
                if (CheckIfAFolderIsAGdb(path))
                {
                    lbl_error.Text = string.Empty;
                    btn_points.Text = path;
                    btn_lines.Enabled = true;
                    combo_PointsLyr.Enabled = true;
                    Read.pointsChildDatasets.Clear();
                    combo_PointsLyr.Items.Clear();
                    if (Read.ReadOnlyTheLyrs(path, 1))
                        for (int i = 0; i < Read.pointsChildDatasets.Count; i++)
                            combo_PointsLyr.Items.Add(Read.pointsChildDatasets[i]);
                    else
                        lbl_error.Text = "error while trying to open the gdb please try again later";
                }
            }
            else if (((Button)sender).Name == "btn_lines")
            {
                path = OpenGdbDialog();
                if (CheckIfAFolderIsAGdb(path))
                {
                    lbl_error.Text = string.Empty;
                    btn_lines.Text = path;
                    btn_polygons.Enabled = true;
                    combo_LinesLyr.Enabled = true;
                    Read.linesChildDatasets.Clear();
                    combo_LinesLyr.Items.Clear();
                    if (Read.ReadOnlyTheLyrs(path, 2))
                        for (int i = 0; i < Read.linesChildDatasets.Count; i++)
                            combo_LinesLyr.Items.Add(Read.linesChildDatasets[i]);
                    else
                        lbl_error.Text = "error while trying to open the gdb please try again later";
                }
            }
            else if (((Button)sender).Name == "btn_polygons")
            {
                path = OpenGdbDialog();
                if (CheckIfAFolderIsAGdb(path))
                {
                    lbl_error.Text = string.Empty;
                    btn_polygons.Text = path;
                    Read.PolygonsChildDatasets.Clear();
                    combo_PolygonsLyr.Items.Clear();
                    combo_PolygonsLyr.Enabled = true;
                    if (Read.ReadOnlyTheLyrs(path, 3))
                        for (int i = 0; i < Read.PolygonsChildDatasets.Count; i++)
                            combo_PolygonsLyr.Items.Add(Read.PolygonsChildDatasets[i]);
                    else
                        lbl_error.Text = "error while trying to open the gdb please try again later";
                    btn_Save.Enabled = true;
                }
            }
        }

        private bool CheckIfAFolderIsAGdb(string path)
        {
            if (!path.Contains(".gdb"))
            {
                lbl_error.Text = "Please select a gdb file";
                MessageBox.Show("Please select a gdb file");
                return false;
            }
            else
                return true;
        }

        private string OpenGdbDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.ShowDialog();
            return folderBrowserDialog.SelectedPath;
        }

        private void OnloadUsersList()
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT UserID FROM T_UserRef", connection))
                {
                    connection.Open();
                    using (SqlDataReader dr = sqlCommand.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            btn_Save.Enabled = true;
                            combo_users.Items.Add(dr.GetString(0));
                        }
                        if (combo_users.Items.Count >= 1)
                            return;
                        else
                        {
                            lbl_error.Text = "Error while loading the users list.";
                            return;
                        }
                    }
                }
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (HasRows())
            {
                if (UpdateRows())
                    lbl_error.Text = "Info saved successfully";
                else
                    lbl_error.Text = "Could'nt save...Please try again later";
            }
            else
            {
                InsertDataToSql();
                lbl_error.Text = "Info saved successfully";
            }

        }

        private bool HasRows()
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                using (SqlCommand command = new SqlCommand("SELECT UserID FROM T_GdbsManager WHERE UserID = @UserID", connection))
                {
                    command.Parameters.AddWithValue("@UserID", combo_users.SelectedItem);
                    connection.Open();
                    using (SqlDataReader dr = command.ExecuteReader())
                        if (dr.Read())
                            return true;
                }
                return false;
            }
        }

        private bool UpdateRows()
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                string[] vs = new string[1];
                for (int i = 0; i < 3; i++)
                {
                    vs = GetGdbPath(i);
                    using (SqlCommand command = new SqlCommand("UPDATE T_GdbsManager SET GdbPath = @GdbPath, LyrName = @LyrName WHERE UserID = @UserName AND num = @num", connection))
                    {
                        command.Parameters.AddWithValue("@num", i);
                        command.Parameters.AddWithValue("@UserName", combo_users.SelectedItem);
                        command.Parameters.AddWithValue("@GdbPath", vs[0]);
                        command.Parameters.AddWithValue("@LyrName", vs[1]);
                        if (i == 0)
                            connection.Open();
                        using (SqlDataReader dr = command.ExecuteReader())
                            while (dr.Read())
                                return false;
                    }
                }
                return true;
            }
        }
        private bool InsertDataToSql()
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                int userId = GetUserId();
                string[] vs = new string[1];
                for (int i = 0; i < 3; i++)
                {
                    vs = GetGdbPath(i);
                    using (SqlCommand sqlCommand = new SqlCommand(" INSERT INTO T_GdbsManager (ID,UserID,GdbPath,LyrName,num) values (@Id,@UserName,@GdbPath,@LyrName,@num)", connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", userId);
                        sqlCommand.Parameters.AddWithValue("@UserName", combo_users.SelectedItem);
                        sqlCommand.Parameters.AddWithValue("@GdbPath", vs[0]);
                        sqlCommand.Parameters.AddWithValue("@LyrName", vs[1]);
                        sqlCommand.Parameters.AddWithValue("@num", i);
                        if (i == 0)
                            connection.Open();
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                            if (dr.Read())
                                return false;
                    }
                }

            }
            return true;
        }
        public string[] GetGdbPath(int z)
        {
            string[] arr = new string[2];
            if (z == 0)
            {
                arr[0] = btn_points.Text;
                arr[1] = combo_PointsLyr.SelectedItem.ToString();
            }
            else if (z == 1)
            {
                arr[0] = btn_lines.Text;
                arr[1] = combo_LinesLyr.SelectedItem.ToString();
            }
            else if (z == 2)
            {
                arr[0] = btn_polygons.Text;
                arr[1] = combo_PolygonsLyr.SelectedItem.ToString();
            }
            return arr;
        }
        private void Combo_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckUserData())
                GetUserData();
        }
        private int GetUserId()
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                using (SqlCommand command = new SqlCommand("SELECT ID from T_UserRef WHERE UserID = @UserName", connection))
                {
                    command.Parameters.AddWithValue("@UserName", combo_users.SelectedItem);
                    connection.Open();
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                            return dr.GetInt32(0);
                    }
                }
            }
            lbl_error.Text = "Could not get the user Please try again later...";
            return -1;
        }
        private bool CheckUserData()
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                using (SqlCommand command = new SqlCommand("SELECT UserID FROM T_GdbsManager WHERE UserID = @UserID", connection))
                {
                    command.Parameters.AddWithValue("@UserID", combo_users.SelectedItem);
                    connection.Open();
                    using (SqlDataReader dr = command.ExecuteReader())
                        while (dr.Read())
                            return true;
                }
                return false;
            }
        }
        private void GetUserData()
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                using (SqlCommand command = new SqlCommand("SELECT GdbPath,LyrName FROM T_GdbsManager WHERE UserID = @UserID", connection))
                {
                    command.Parameters.AddWithValue("@UserID", combo_users.SelectedItem);
                    connection.Open();
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        Button[] buttons = { btn_points, btn_lines, btn_polygons };
                        ComboBox[] comboBoxes = { combo_PointsLyr, combo_LinesLyr, combo_PolygonsLyr };
                        int i = 0;
                        while (dr.Read())
                        {
                            buttons[i].Text = dr.GetString(0);
                            comboBoxes[i].Text = dr.GetString(1);
                            i++;
                        }
                    }
                }
            }
        }
    }
}
