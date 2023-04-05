using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    internal class Prototype
    {
        public class PizzaBuilder
        {
            public string Flour { get; set; }
            public string Water { get; set; }
            public string Yeast { get; set; }
            public string Salt { get; set; }
            public string Sugar { get; set; }

            public PizzaBuilder(string flour, string water, string yeast, string salt, string sugar)
            {
                Flour = flour;
                Water = water;
                Yeast = yeast;
                Salt = salt;
                Sugar = sugar;
            }

            public PizzaBuilder Clone()
            {
                return (PizzaBuilder)this.MemberwiseClone();
            }
        }
        public class Pizza
        {
            public string Flour { get; set; }
            public string Water { get; set; }
            public string Yeast { get; set; }
            public string Salt { get; set; }
            public string Sugar { get; set; }

            public Pizza(PizzaBuilder builder)
            {
                Flour = builder.Flour;
                Water = builder.Water;
                Yeast = builder.Yeast;
                Salt = builder.Salt;
                Sugar = builder.Sugar;
            }

            public Pizza Clone()
            {
                return (Pizza)this.MemberwiseClone();
            }
        }

    }
}
