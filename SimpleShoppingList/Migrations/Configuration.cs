namespace SimpleShoppingList.Migrations
{
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<SimpleShoppingList.Models.SimpleShoppingListContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(SimpleShoppingList.Models.SimpleShoppingListContext context)
    {
      context.ShoppingLists.AddOrUpdate(
        new Models.ShoppingList
        {
          Name = "Groceries",
          Items = {
                    new Models.Item { Name = "Milk" },
                    new Models.Item { Name = "Bread" },
                    new Models.Item { Name = "Chocolate" },
                  }
        },
        new Models.ShoppingList
        {
          Name = "Hardware"
        });
    }
  }
}
