using BethanysPieShopHRM.Shared.Domain;
using BlazorEmployees.Components.Services;

namespace BlazorEmployees.Components.Pages;

public partial class EmployeesOverview
{
  public List<Employee> Employees { get; set; } = default!;

  protected async override Task  OnInitializedAsync()
  {
    await Task.Delay(2000);
    Employees = MockDataService.Employees;
  }
}
