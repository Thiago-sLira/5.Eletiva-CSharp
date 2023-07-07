class Bakery
{
  public Bread fabricateBread(int weight)
  {
    return new Bread
    {
      Weight = weight,
      Type = "White"
    };
  }

  public Cake fabricateChocolateCake(string size)
  {
    return new Cake
    {
      Size = size,
      Flavour = "Chocolate"
    };
  }
}

// public static Bakery ConvertFromRestaurant(Restaurant restaurant, string name = "")
// {
//     return new Bakery(
//         string.IsNullOrEmpty(name) ? restaurant.Name : name,
//         restaurant.Owner
//     );
// }
