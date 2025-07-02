using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
namespace BlazorEmployees.Components;

public partial class EmployeeCard
{
  [Parameter]
  public Employee Employee { get; set; } = default!;

  [Parameter]
  public EventCallback<Employee> ShowQuickView { get; set;}
}
