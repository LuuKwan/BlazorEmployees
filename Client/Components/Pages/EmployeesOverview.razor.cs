using BethanysPieShopHRM.Shared.Domain;
using BlazorEmployees.Components.Services;

namespace BlazorEmployees.Components.Pages;

public partial class EmployeesOverview
{
  public List<Employee> Employees { get; set; } = default!;
  private Employee? _SelectedEmployeeForQuickView { get; set; } = null;
  protected async override Task OnInitializedAsync()
  {
    await Task.Delay(2000);
    Employees = MockDataService.Employees;
  }

  private void SetEmployeeForQuickView(Employee employee)
  {
    _SelectedEmployeeForQuickView = employee;
  }
}
