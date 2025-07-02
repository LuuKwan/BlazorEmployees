using System;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BlazorEmployees.Components;

public partial class QuickViewPopup
{
  [Parameter]
  public Employee? Employee { get; set; } = null;

  private Employee? _employee;
  protected override void OnParametersSet()
  {
    _employee = Employee;
  }

  private void CloseMe()
  {
    _employee = null;
  }

}
