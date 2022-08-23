namespace TryingDapper
{
  public class Pizza
  {
    public string Type { get; set; } = String.Empty;
    public string Size { get; set; } = String.Empty;
    public double Price { get; set; }
  }
  public class PizzaGrouped
  {
    public string Grouping { get; set; } = String.Empty;

    public double Total { get; set; }
  }
}