using System;
using System.Collections.Generic;
namespace Restaurant_Menu_Studio


{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }


        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;

        }
            public string IsItemNew() 
            {
                if (IsNew)
                {
                    return ("This item is new!");
                }
                else
                {
                    return ("This item is not new!");

                }
            }







        }
    }
