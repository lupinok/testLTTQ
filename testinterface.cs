using System;
public interface IEmployeeBUS
{
    void AddEmployee(EmployeeDTO employee);
    void UpdateEmployee(EmployeeDTO employee);
    DataTable GetAllEmployees();
}
public class EmployeeBUS : IEmployeeBUS
{
    private IEmployeeDAO employeeDAO;

    public EmployeeBUS(IEmployeeDAO employeeDAO)
    {
        this.employeeDAO = employeeDAO;
    }

    public void AddEmployee(EmployeeDTO employee)
    {
        // Thêm nhân viên vào cơ sở dữ liệu
        employeeDAO.InsertEmployee(employee);
    }

    public void UpdateEmployee(EmployeeDTO employee)
    {
        employeeDAO.UpdateEmployee(employee);
    }

    public DataTable GetAllEmployees()
    {
        return employeeDAO.GetAllEmployees();
    }
}




