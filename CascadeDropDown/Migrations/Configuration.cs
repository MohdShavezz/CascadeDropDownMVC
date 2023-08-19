namespace CascadeDropDown.Migrations
{
    using CascadeDropDown.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CascadeDropDown.Models.Context12>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CascadeDropDown.Models.Context12 context)
        {
            if (!context.Countries.Any())
            {
                var list = new List<Country>
               {
                    new Country { Name = "Country 1" },
                    new Country { Name = "Country 2" },
               };
                context.Countries.AddRange(list);
                context.SaveChanges();
            }

            if (!context.States.Any())
            {
                var country1 = context.Countries.FirstOrDefault(c => c.Name == "Country 1");

                var state = new List<State>
               {
                   new State { Name = "State 1 - Country 1", CountryId = country1.Id },
                    new State { Name = "State 2 - Country 1", CountryId = country1.Id },
               };
            context.States.AddRange(state);
                context.SaveChanges();
        }

            if (!context.Cities.Any())
            {
                var state1 = context.States.FirstOrDefault(s => s.Name == "State 1 - Country 1");

        var city = new List<City>
               {
                    new City { Name = "City 1 - State 1", StateId = state1.Id },
                    new City { Name = "City 2 - State 1", StateId = state1.Id },
               };
        context.Cities.AddRange(city);
            }
        context.SaveChanges();
            base.Seed(context);

        }
    }
}
