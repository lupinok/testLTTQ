using System;

public class testkethua : Form
{
    protected void ShowMessage(string message)
    {
        MessageBox.Show(message);
    }

    // Các phương thức chung khác cho các form có thể được định nghĩa ở đây.
}
public class EmployeeForm : testkethua
{
    private DataGridView dataGridView;
    private IEmployeeBUS employeeBUS;

    public EmployeeForm(IEmployeeBUS employeeBUS)
    {
        this.employeeBUS = employeeBUS;

        InitializeComponent();
        LoadEmployeeData();
    }

    private void InitializeComponent()
    {
        dataGridView = new DataGridView();
        this.Controls.Add(dataGridView);
        dataGridView.Dock = DockStyle.Fill;
        this.Text = "Danh Sách Nhân Viên";
    }

    private void LoadEmployeeData()
    {
        try
        {
            DataTable employees = employeeBUS.GetAllEmployees();
            dataGridView.DataSource = employees;
        }
        catch (Exception ex)
        {
            ShowMessage("Lỗi khi tải dữ liệu: " + ex.Message);
        }
    }
}
